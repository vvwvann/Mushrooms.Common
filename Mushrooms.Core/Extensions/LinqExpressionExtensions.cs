using Mushrooms.Core.Models;
using Mushrooms.Core.Helpers;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Mushrooms.Core.Extensions
{
    public static class LinqExpressionExtensions
    {
        private static readonly string[,] METHODS = new string[,]
            {
                { "OrderBy", "OrderByDescending" },
                { "ThenBy", "ThenByDescending" }
            };

        public static IQueryable<T> Filter<T>(this IQueryable<T> source, QueryStandart query)
        {
            query.Build<T>();
            var filter = new DynamicExpressionParser().GenerateExp<T>(query);

            return source.Where(filter);
        }

        public static IQueryable<T> OderByFields<T>(this IQueryable<T> source, QueryStandart query)
        {
            if (query == null) return source;

            var columns = query.SortArgs<T>();

            if (columns.Count == 0) return source;

            ParameterExpression parameter = Expression.Parameter(typeof(T));
            Expression exp = source.Expression;

            int index = 0;

            foreach (var (name, desc) in columns)
            {
                exp = OrderBy(source, exp, parameter, name, index, desc);
                index = 1;
            }

            return source.Provider.CreateQuery<T>(exp);
        }

        public static IQueryable<T> OderByFields<T>(this IQueryable<T> source,
            QueryStandart query,
            Func<string, LambdaExpression> lambdaCondition)
        {
            Dictionary<string, bool> sorts = query.SortArgs<T>();

            if (sorts.Count == 0) return source;

            var orderExp = new OrderExpHelper<T>(source);

            foreach (var (name, desc) in sorts)
            {
                LambdaExpression exp = lambdaCondition(name);
                if (exp == null)
                {
                    orderExp.OrderBy(name, desc);
                }
                else
                {
                    orderExp.OrderBy(exp, desc);
                }
            }

            return orderExp.Compile();
        }

        public static Expression OrderBy<T>(this IQueryable<T> source, Expression exp, ParameterExpression parameter,
            string columnName,
            int level = 0,
            bool desc = false)
        {
            MemberExpression property = Expression.Property(parameter, columnName);
            LambdaExpression lambda = Expression.Lambda(property, parameter);


            string methodName = METHODS[level, desc ? 1 : 0];

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                  new Type[] { source.ElementType, property.Type },
                                  exp, Expression.Quote(lambda));

            return methodCallExpression;
        }

        public static Expression OrderBy<T>(this IQueryable<T> source, Expression exp, LambdaExpression lambda,
            int level = 0,
            bool desc = false)
        {
            string methodName = METHODS[level, desc ? 1 : 0];

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                  new Type[] { source.ElementType, lambda.Body.Type },
                                  exp, lambda);

            return methodCallExpression;
        }
    }
}
