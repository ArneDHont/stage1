using FluentValidation;
using FluentValidation.Results;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Inspect.Framework.Business
{
    public interface IBusinessComponent
    {
        IDataAccessComponent DataAccessComponent { get; set; }

        IValidatorFactory ValidatorFactory { get; set; }

        int Count<TEntity>(IEntityQuery<TEntity> query) where TEntity : class;

        int Count<TEntity>(IEntitySpecification<TEntity> specification = null) where TEntity : class;

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;

        IEnumerable<TEntity> Get<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class;

        IEnumerable<TEntity> Get<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class;

        IEnumerable<TEntity> List<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class;

        IEnumerable<TEntity> List<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class;

        TEntity SingleOrDefault<TEntity>(IEntitySpecification<TEntity> specification) where TEntity : class;

        TEntity SingleOrDefault<TEntity>(IEntityQuery<TEntity> query = null) where TEntity : class;

        ValidationResult Validate<TEntity>(TEntity entity);

        void ValidateAndThrow<TEntity>(TEntity entity, string ruleSet = null);

        ValidationResult ValidateProperties<TEntity>(TEntity entity, params string[] properties);

        ValidationResult ValidateProperties<TEntity>(TEntity entity, params Expression<Func<TEntity, object>>[] propertyExpressions);

        ValidationResult ValidateRuleSets<TEntity>(TEntity entity, params string[] ruleSets);
    }
}