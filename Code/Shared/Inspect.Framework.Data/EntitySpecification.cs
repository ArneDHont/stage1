using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data
{
    public static class EntitySpecification
    {
        public static IEntitySpecification<TEntity> Default<TEntity>(bool defaultValue = true)
        {
            return new DefaultEntitySpecification<TEntity>(defaultValue);
        }

        public static IEntitySpecification<TEntity> And<TEntity>(this IEntitySpecification<TEntity> left, IEntitySpecification<TEntity> right)
        {
            return new AndEntitySpecification<TEntity>(left, right);
        }

        public static bool IsSatisfiedBy<TEntity>(this IEntitySpecification<TEntity> specification, TEntity entity)
        {
            return new[] { entity }.AsQueryable().Any(specification.ToExpression());
        }

        public static IEntitySpecification<TEntity> Not<TEntity>(this IEntitySpecification<TEntity> entitySpecification)
        {
            return new NotSpecification<TEntity>(entitySpecification);
        }

        public static IEntitySpecification<TEntity> Or<TEntity>(this IEntitySpecification<TEntity> left, IEntitySpecification<TEntity> right)
        {
            return new OrEntitySpecification<TEntity>(left, right);
        }

        public static IQueryable<TEntity> SatisfyingItemsFrom<TEntity>(this IEntitySpecification<TEntity> specification, IQueryable<TEntity> queryable)
        {
            return queryable.Where(specification.ToExpression());
        }

        private sealed class DefaultEntitySpecification<TEntity> : IEntitySpecification<TEntity>
        {
            private bool mDefaultValue;

            public DefaultEntitySpecification(bool defaultValue)
            {
                mDefaultValue = defaultValue;
            }
            public Expression<Func<TEntity, bool>> ToExpression()
            {
                return x => mDefaultValue;
            }
        }

        private sealed class AndEntitySpecification<TEntity> : IEntitySpecification<TEntity>
        {
            private readonly IEntitySpecification<TEntity> mLeft;

            private readonly IEntitySpecification<TEntity> mRight;

            public AndEntitySpecification(IEntitySpecification<TEntity> left, IEntitySpecification<TEntity> right)
            {
                this.mLeft = left;
                this.mRight = right;
            }

            public Expression<Func<TEntity, bool>> ToExpression()
            {
                Expression<Func<TEntity, bool>> leftExpression = mLeft.ToExpression();
                Expression<Func<TEntity, bool>> rightExpression = mRight.ToExpression();

                var firstExpressionParameter = leftExpression.Parameters[0];
                var parameterReplaceVisitor = ParameterRebinder.CreateFor(leftExpression, rightExpression);
                var updatedSecondExpression = (LambdaExpression)parameterReplaceVisitor.Visit(rightExpression);

                BinaryExpression andExpression = Expression.AndAlso(leftExpression.Body, updatedSecondExpression.Body);
                return Expression.Lambda<Func<TEntity, bool>>(andExpression, firstExpressionParameter);
            }
        }

        private sealed class NotSpecification<TEntity> : IEntitySpecification<TEntity>
        {
            private readonly IEntitySpecification<TEntity> mEntitySpecification;

            public NotSpecification(IEntitySpecification<TEntity> entitySpecification)
            {
                mEntitySpecification = entitySpecification;
            }

            public Expression<Func<TEntity, bool>> ToExpression()
            {
                Expression<Func<TEntity, bool>> expression = mEntitySpecification.ToExpression();
                var firstExpressionParameter = expression.Parameters[0];
                var notExpression = Expression.Not(expression.Body);
                return Expression.Lambda<Func<TEntity, bool>>(notExpression, firstExpressionParameter);
            }
        }

        private sealed class OrEntitySpecification<TEntity> : IEntitySpecification<TEntity>
        {
            private readonly IEntitySpecification<TEntity> mLeft;

            private readonly IEntitySpecification<TEntity> mRight;

            public OrEntitySpecification(IEntitySpecification<TEntity> left, IEntitySpecification<TEntity> right)
            {
                this.mLeft = left;
                this.mRight = right;
            }

            public Expression<Func<TEntity, bool>> ToExpression()
            {
                Expression<Func<TEntity, bool>> leftExpression = mLeft.ToExpression();
                Expression<Func<TEntity, bool>> rightExpression = mRight.ToExpression();

                var firstExpressionParameter = leftExpression.Parameters[0];
                var parameterReplaceVisitor = ParameterRebinder.CreateFor(leftExpression, rightExpression);
                var updatedSecondExpression = (LambdaExpression)parameterReplaceVisitor.Visit(rightExpression);

                BinaryExpression andExpression = Expression.OrElse(leftExpression.Body, updatedSecondExpression.Body);
                return Expression.Lambda<Func<TEntity, bool>>(andExpression, firstExpressionParameter);
            }
        }

        private class ParameterRebinder : ExpressionVisitor
        {
            private readonly Dictionary<ParameterExpression, ParameterExpression> mParameterMap;

            public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> parameterMap)
            {

                this.mParameterMap = parameterMap ?? new Dictionary<ParameterExpression, ParameterExpression>();
            }

            public static ParameterRebinder CreateFor<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
            {
                var map = left.Parameters.Select((f, i) => new { f, s = right.Parameters[i] }).ToDictionary(p => p.s, p => p.f);
                return new ParameterRebinder(map);
            }

            protected override Expression VisitParameter(ParameterExpression p)
            {
                if (mParameterMap.TryGetValue(p, out ParameterExpression replacement))
                {
                    p = replacement;
                }
                return base.VisitParameter(p);
            }
        }
    }
}