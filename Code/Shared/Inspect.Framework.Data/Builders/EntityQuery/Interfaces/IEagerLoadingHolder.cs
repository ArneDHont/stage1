using System;
using System.Linq.Expressions;

namespace Inspect.Framework.Data.Builders.EntityQuery.Interfaces
{
    public interface IEagerLoadingHolder<TEntity> where TEntity : class
    {
        IAdditionalEagerLoadingHolder<TEntity> WithEagerLoading(string path);

        IEntityQueryBuilder<TEntity> WithNoEagerLoading();
    }

    public static class EagerLoadingHolderExtensions
    {
        public static IAdditionalEagerLoadingHolder<TEntity> AndEagerLoading<TEntity, TProperty>(this IAdditionalEagerLoadingHolder<TEntity> instance, Expression<Func<TEntity, TProperty>> path) where TEntity : class
        {
            string include;
            if (!TryParsePath(path.Body, out include) || include == null)
            {
                throw new ArgumentException("The Include path expression must refer to a navigation property defined on the type. Use dotted paths for reference navigation properties and the Select operator for collection navigation properties.", "path");
            }
            return instance.AndEagerLoading(include);
        }

        public static IAdditionalEagerLoadingHolder<TEntity> WithEagerLoading<TEntity, TProperty>(this IEagerLoadingHolder<TEntity> instance, Expression<Func<TEntity, TProperty>> path) where TEntity : class
        {
            string include;
            if (!TryParsePath(path.Body, out include) || include == null)
            {
                throw new ArgumentException("The Include path expression must refer to a navigation property defined on the type. Use dotted paths for reference navigation properties and the Select operator for collection navigation properties.", "path");
            }
            return instance.WithEagerLoading(include);
        }

        private static Expression RemoveConvert(Expression expression)
        {
            while ((expression != null)
                   && (expression.NodeType == ExpressionType.Convert
                       || expression.NodeType == ExpressionType.ConvertChecked))
            {
                expression = RemoveConvert(((UnaryExpression)expression).Operand);
            }

            return expression;
        }

        private static bool TryParsePath(Expression expression, out string path)
        {
            path = null;
            var withoutConvert = RemoveConvert(expression);
            var memberExpression = withoutConvert as MemberExpression;
            var callExpression = withoutConvert as MethodCallExpression;

            if (memberExpression != null)
            {
                var thisPart = memberExpression.Member.Name;
                string parentPart;
                if (!TryParsePath(memberExpression.Expression, out parentPart))
                {
                    return false;
                }
                path = parentPart == null ? thisPart : (parentPart + "." + thisPart);
            }
            else if (callExpression != null)
            {
                if (callExpression.Method.Name == "Select"
                    && callExpression.Arguments.Count == 2)
                {
                    string parentPart;
                    if (!TryParsePath(callExpression.Arguments[0], out parentPart))
                    {
                        return false;
                    }
                    if (parentPart != null)
                    {
                        var subExpression = callExpression.Arguments[1] as LambdaExpression;
                        if (subExpression != null)
                        {
                            string thisPart;
                            if (!TryParsePath(subExpression.Body, out thisPart))
                            {
                                return false;
                            }
                            if (thisPart != null)
                            {
                                path = parentPart + "." + thisPart;
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            return true;
        }
    }
}