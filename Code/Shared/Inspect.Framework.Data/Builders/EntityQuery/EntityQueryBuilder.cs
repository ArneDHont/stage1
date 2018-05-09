using Inspect.Framework.Data.Builders.EntityQuery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data.Builders.EntityQuery
{
    public class EntityQueryBuilder
    {
        public static IEntitySpecificationHolder<TEntity> QueryFor<TEntity>() where TEntity : class
        {
            return new EntityQueryBuilder<TEntity>();
        }
    }

    public class EntityQueryBuilder<TEntity> : IEntitySpecificationHolder<TEntity>, ISortDefinitionHolder<TEntity>, IAdditionalSortDefinitionHolder<TEntity>, IPageSizeHolder<TEntity>, IPageNumberHolder<TEntity>, IEagerLoadingHolder<TEntity>, IAdditionalEagerLoadingHolder<TEntity>, IEntityQueryBuilder<TEntity>
        where TEntity : class
    {
        private List<string> IncludePaths { get; set; } = new List<string>();

        private int? PageNumber { get; set; }

        private int? PageSize { get; set; }

        private Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> SortDefinition { get; set; }

        private IEntitySpecification<TEntity> Specification { get; set; }

        public IAdditionalEagerLoadingHolder<TEntity> AndEagerLoading(string path)
        {
            return WithEagerLoading(path);
        }

        public IEntityQueryBuilder<TEntity> AndNoMoreEagerLoading()
        {
            return this;
        }

        public IAdditionalSortDefinitionHolder<TEntity> AndThenBy<TProperty>(Expression<Func<TEntity, TProperty>> property)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = x => SortDefinition(x).ThenBy(property)
            };
        }

        public IAdditionalSortDefinitionHolder<TEntity> AndThenByDescending<TProperty>(Expression<Func<TEntity, TProperty>> property)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = x => SortDefinition(x).ThenByDescending(property)
            };
        }

        public IPageSizeHolder<TEntity> AndThenNoMoreSorting()
        {
            return this;
        }

        public IEntityQuery<TEntity> Build()
        {
            return new DelegateEntityQuery<TEntity>(db =>
            {
                var q = db.Queryable<TEntity>();

                q = Specification.SatisfyingItemsFrom(q);

                foreach (var includePath in IncludePaths)
                {
                    q = q.Include(includePath);
                }

                if (SortDefinition != null)
                {
                    q = SortDefinition(q.OrderBy(x => 0));
                }
                else
                {
                    q = q.OrderBy(x => 0);
                }

                if (PageSize.HasValue)
                {
                    int pageNumber = PageNumber ?? 1;
                    int skipItems = (pageNumber - 1) * PageSize.Value;
                    q = q.Skip(skipItems).Take(PageSize.Value);
                }

                return q;
            });
        }

        public IAdditionalEagerLoadingHolder<TEntity> WithEagerLoading(string path)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = SortDefinition,
                PageSize = PageSize,
                PageNumber = PageNumber,
                IncludePaths = new List<string>(IncludePaths) { path }
            };
        }

        public IEntityQueryBuilder<TEntity> WithNoEagerLoading()
        {
            return this;
        }

        public IEagerLoadingHolder<TEntity> WithNoSorting()
        {
            throw new NotImplementedException();
        }

        public IAdditionalSortDefinitionHolder<TEntity> WithOrderBy<TProperty>(Expression<Func<TEntity, TProperty>> property)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = x => x.OrderBy(property)
            };
        }

        public IAdditionalSortDefinitionHolder<TEntity> WithOrderByDescending<TProperty>(Expression<Func<TEntity, TProperty>> property)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = x => x.OrderByDescending(property)
            };
        }

        public IEagerLoadingHolder<TEntity> WithoutPaging()
        {
            return this;
        }

        public IEagerLoadingHolder<TEntity> WithPageNumber(int pageIndex)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = SortDefinition,
                PageSize = PageSize,
                PageNumber = pageIndex
            };
        }

        public IPageNumberHolder<TEntity> WithPageSize(int pageSize)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = Specification,
                SortDefinition = SortDefinition,
                PageSize = pageSize
            };
        }

        public ISortDefinitionHolder<TEntity> WithSpecification(IEntitySpecification<TEntity> specification)
        {
            return new EntityQueryBuilder<TEntity>()
            {
                Specification = specification
            };
        }

        private class DelegateEntityQuery<T> : IEntityQuery<T> where T : class
        {
            private Func<IEntityQueryModel, IQueryable<T>> mQueryDelegate;

            public DelegateEntityQuery(Func<IEntityQueryModel, IQueryable<T>> queryDelegate)
            {
                mQueryDelegate = queryDelegate;
            }

            public IQueryable<T> Execute(IEntityQueryModel db)
            {
                return mQueryDelegate(db);
            }
        }
    }
}