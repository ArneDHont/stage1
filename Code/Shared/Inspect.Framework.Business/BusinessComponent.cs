using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Inspect.Framework.Business
{
    public class BusinessComponent : IBusinessComponent
    {
        private IDataAccessComponent mDataAccessComponent;

        private IValidatorFactory mValidatorFactory;

        public BusinessComponent(IDataAccessComponent dataAccessComponent)
        {
            mDataAccessComponent = dataAccessComponent;
        }

        public BusinessComponent(IDataAccessComponent dataAccessComponent, IValidatorFactory validatorFactory)
        {
            mDataAccessComponent = dataAccessComponent;
            mValidatorFactory = validatorFactory;
        }

        public IDataAccessComponent DataAccessComponent
        {
            get
            {
                return mDataAccessComponent;
            }
            set
            {
                mDataAccessComponent = value;
            }
        }

        public IValidatorFactory ValidatorFactory
        {
            get
            {
                return mValidatorFactory = mValidatorFactory ?? new AttributedValidatorFactory();
            }
            set
            {
                mValidatorFactory = value;
            }
        }

        public int Count<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class
        {
            return DataAccessComponent.Count(specification);
        }

        public int Count<TEntity>(IEntityQuery<TEntity> query) where TEntity : class
        {
            return DataAccessComponent.Count(query);
        }

        public TEntity Find<TEntity>(params object[] keyValues) where TEntity : class
        {
            return mDataAccessComponent.Find<TEntity>(keyValues);
        }

        public IEnumerable<TEntity> Get<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class
        {
            return mDataAccessComponent.Get(query);
        }

        public IEnumerable<TEntity> Get<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class
        {
            return mDataAccessComponent.Get(specification);
        }

        public IEnumerable<TEntity> List<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class
        {
            return mDataAccessComponent.List(specification);
        }

        public IEnumerable<TEntity> List<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class
        {
            return mDataAccessComponent.List(query);
        }

        public TEntity SingleOrDefault<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class
        {
            return mDataAccessComponent.SingleOrDefault(query);
        }

        public TEntity SingleOrDefault<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class
        {
            return mDataAccessComponent.SingleOrDefault(specification);
        }

        public ValidationResult Validate<TEntity>(TEntity entity)
        {
            return ValidatorFactory.GetValidator<TEntity>()?.Validate(entity);
        }

        public void ValidateAndThrow<TEntity>(TEntity entity, string ruleSet = null)
        {
            ValidatorFactory.GetValidator<TEntity>()?.ValidateAndThrow(entity, ruleSet);
        }

        public ValidationResult ValidateProperties<TEntity>(TEntity entity, params string[] properties)
        {
            return ValidatorFactory.GetValidator<TEntity>()?.Validate(entity, properties);
        }

        public ValidationResult ValidateProperties<TEntity>(TEntity entity, params Expression<Func<TEntity, object>>[] propertyExpressions)
        {
            return ValidatorFactory.GetValidator<TEntity>()?.Validate(entity, propertyExpressions);
        }

        public ValidationResult ValidateRuleSets<TEntity>(TEntity entity, params string[] ruleSets)
        {
            return ValidatorFactory.GetValidator<TEntity>()?.Validate(entity, ruleSet: string.Join(",", ruleSets));
        }
    }
}