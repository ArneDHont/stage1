using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Inspect.Framework.Data.EntityFramework
{
    public interface IDbContextBase : IDisposable, IEntityQueryModel
    {
        void ApplyChanges<TEntity>(TEntity root) where TEntity : class;

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        void SetAuditFields();

        void SetCommandTimeout(int timeout);
    }

    public class DbContextBase : DbContext, IDbContextBase
    {
        public DbContextBase(string nameOrConnectionString = "name=InspectConnectionString", bool emitOriginalValues = true) : base(nameOrConnectionString)
        {
            Initialize(emitOriginalValues);
        }

        public virtual void ApplyChanges<TEntity>(TEntity root) where TEntity : class
        {
            this.Set<TEntity>().Add(root);
            foreach (var entry in this.ChangeTracker.Entries<IObjectWithState>())
            {
                IObjectWithState stateInfo = entry.Entity;
                EntityState newState = ConvertState(stateInfo.State);
                try
                {
                    entry.State = newState;
                }
                catch (InvalidOperationException)
                {
                    // Currently there is no (performant) method to check if a duplicate primary key exists in a graph
                    // so When the state cannot be set (due to duplicate primary key) be sure to set it to detached.
                    entry.State = EntityState.Detached;
                }
                if (stateInfo.State == ObjectState.Unchanged && entry.State != EntityState.Detached)
                {
                    ApplyPropertyChanges(entry.OriginalValues, stateInfo.OriginalValues);
                }
            }

            // Take care of (special) relationships that were marked as Added using the Add() method above.
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            foreach (var relation in objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Where(x => x.IsRelationship))
            {
                EntityKey keyOne = (EntityKey)relation.CurrentValues[0];
                ObjectStateEntry stateOne = objectContext.ObjectStateManager.GetObjectStateEntry(keyOne);

                EntityKey keyTwo = (EntityKey)relation.CurrentValues[1];
                ObjectStateEntry stateTwo = objectContext.ObjectStateManager.GetObjectStateEntry(keyTwo);

                if (stateOne.State == EntityState.Unchanged && stateTwo.State == EntityState.Unchanged)
                {
                    if (relation.State != EntityState.Unchanged)
                    {
                        relation.ChangeState(EntityState.Unchanged);
                    }
                }
            }
        }

        public IQueryable<TEntity> Queryable<TEntity>() where TEntity : class
        {
            return new DataAccessQueryable<TEntity>(Set<TEntity>());
        }

        public override int SaveChanges()
        {
            int result = -1;

            // Set the audit fields when they are not set.
            this.SetAuditFields();

            try
            {
                result = base.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Optimistic concurrency conflict detected, get latest version from database - client wins
                foreach (var entry in ex.Entries)
                {
                    entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                }
                result = base.SaveChanges();
            }

            // Fix State and OriginalValues after SaveChanges.
            foreach (var entry in this.ChangeTracker.Entries<IObjectWithState>())
            {
                IObjectWithState stateInfo = entry.Entity;
                if (stateInfo.State == ObjectState.Added)
                {
                    stateInfo.State = ObjectState.Unchanged;
                }
                stateInfo.OriginalValues = BuildOriginalValues(entry.OriginalValues);
            }
            return result;
        }

        IDbSet<TEntity> IDbContextBase.Set<TEntity>()
        {
            return this.Set<TEntity>();
        }

        public virtual void SetAuditFields()
        {
            this.SetCreationField<IObjectWithDateCreated>(x => x.DateCreated = x.DateCreated ?? DateTimeOffset.Now);
            this.SetCreationField<IObjectWithUserCreated>(x => x.UserCreated = x.UserCreated ?? Environment.UserName);

            this.SetModificationField<IObjectWithDateModified>(x => x.DateModified = DateTimeOffset.Now);
            this.SetModificationField<IObjectWithUserModified>(x => x.UserModified = Environment.UserName);

            //this.SetDeletionField<IObjectWithDateDeleted>(x => x.DateDeleted = x.DateDeleted ?? DateTimeOffset.Now);
            //this.SetDeletionField<IObjectWithUserDeleted>(x => x.UserDeleted = x.UserDeleted ?? Environment.UserName);

            //this.ModifyEntityState<IObjectWithDateDeleted>(EntityState.Deleted, EntityState.Modified);
            //this.ModifyEntityState<IObjectWithUserDeleted>(EntityState.Deleted, EntityState.Modified);
        }

        public void SetCommandTimeout(int timeout)
        {
            Database.CommandTimeout = timeout;
        }

        private static void ApplyPropertyChanges(DbPropertyValues values, IDictionary<string, object> originalValues)
        {
            foreach (var originalValue in originalValues)
            {
                if (originalValue.Value is Dictionary<string, object>)
                {
                    ApplyPropertyChanges((DbPropertyValues)values[originalValue.Key], (IDictionary<string, object>)originalValue.Value);
                }
                else
                {
                    values[originalValue.Key] = originalValue.Value;
                }
            }
        }

        private static Dictionary<string, object> BuildOriginalValues(DbPropertyValues originalValues)
        {
            var result = new Dictionary<string, object>();
            foreach (var propertyName in originalValues.PropertyNames)
            {
                var value = originalValues[propertyName];
                if (value is DbPropertyValues)
                {
                    result[propertyName] = BuildOriginalValues((DbPropertyValues)value);
                }
                else
                {
                    result[propertyName] = value;
                }
            }
            return result;
        }

        private static Dictionary<string, object> BuildOriginalValues(DbDataRecord originalValues)
        {
            var result = new Dictionary<string, object>();
            for (int i = 0; i < originalValues.FieldCount; i++)
            {
                var propertyName = originalValues.GetName(i);
                var value = originalValues[i] == DBNull.Value ? null : originalValues[i];
                if (value is DbDataRecord)
                {
                    result[propertyName] = BuildOriginalValues((DbDataRecord)value);
                }
                else
                {
                    result[propertyName] = value;
                }
            }
            return result;
        }

        private static EntityState ConvertState(ObjectState state)
        {
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;

                case ObjectState.Deleted:
                    return EntityState.Deleted;

                case ObjectState.None:
                    return EntityState.Unchanged;

                default:
                    return EntityState.Unchanged;
            }
        }

        private void Initialize(bool emitOriginalValues, int commandTimeout = 300)
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            if (objectContext != null)
            {
                objectContext.ObjectMaterialized += (sender, args) =>
                {
                    if (args.Entity is IObjectWithState entity)
                    {
                        if (emitOriginalValues)
                        {
                            entity.State = ObjectState.Unchanged;
                            //entity.OriginalValues = BuildOriginalValues(this.Entry(entity).OriginalValues);
                            //Optimized performance: use ObjectState Manager instead of Entry() because Entry() calls DetectChanges()
                            entity.OriginalValues = BuildOriginalValues(objectContext.ObjectStateManager.GetObjectStateEntry(entity).OriginalValues);
                        }
                        else
                        {
                            entity.State = ObjectState.None;
                        }
                    }
                };
            }
        }

        private void ModifyEntityState<TEntity>(EntityState from, EntityState to) where TEntity : class
        {
            var entities = this.ChangeTracker.Entries<TEntity>().Where(x => x.State == from).ToList();
            entities.ForEach(x =>
            {
                x.State = to;
            });
        }

        private void SetCreationField<TEntity>(Action<TEntity> action) where TEntity : class
        {
            var entities = this.ChangeTracker.Entries<TEntity>().Where(x => x.State == EntityState.Added).ToList();
            entities.ForEach(x => action(x.Entity));
        }

        private void SetDeletionField<TEntity>(Action<TEntity> action) where TEntity : class
        {
            var entities = this.ChangeTracker.Entries<TEntity>().Where(x => x.State == EntityState.Deleted).ToList();
            entities.ForEach(x =>
            {
                action(x.Entity);
            });
        }

        private void SetModificationField<TEntity>(Action<TEntity> action) where TEntity : class
        {
            var entities = this.ChangeTracker.Entries<TEntity>().Where(x => x.State == EntityState.Modified).ToList();
            entities.ForEach(x => action(x.Entity));
        }
    }
}