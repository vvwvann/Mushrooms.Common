using Microsoft.EntityFrameworkCore;
using Mushrooms.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;

namespace Mushrooms.Core.Helpers
{
    public class DynamicExpressionParser
    {
        private static readonly string StringStr = nameof(String).ToLower();
        private static readonly string BooleanStr = nameof(Boolean).ToLower();
        private static readonly string Number = nameof(Number).ToLower();
        private static readonly string In = nameof(In).ToLower();
        private static readonly string And = nameof(And).ToLower();

        private readonly MethodInfo MethodContains = typeof(Enumerable).GetMethods(
                        BindingFlags.Static | BindingFlags.Public)
                        .Single(m => m.Name == nameof(Enumerable.Contains)
                            && m.GetParameters().Length == 2);

        private delegate Expression Binder(Expression left, Expression right);

        // operators

        public delegate BinaryExpression BinExp(Expression left, Expression right);

        private Expression ParseExpresion<T>(ParameterExpression parm, string op, string field, object value)
        {
            if (op == "LIKE")
            {
                var efLikeMethod = typeof(DbFunctionsExtensions).GetMethod("Like",
           BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic,
           null,
           new[] { typeof(DbFunctions), typeof(string), typeof(string) },
           null);

                // We make a pattern for the search
                var pattern = Expression.Constant($"%{value}%", typeof(string));

                // Here we will collect a single search request for all properties
                Expression body = Expression.Constant(false);

                // Get property from our object
                var prop = Expression.Property(parm, field);

                // Сall the method with all the required arguments
                Expression expr = Expression.Call(efLikeMethod,
                        Expression.Property(null, typeof(EF), nameof(EF.Functions)), prop, pattern);

                // Add to the main request
                return Expression.OrElse(body, expr);
            }

            BinExp binExp = op switch
            {
                "GT" => Expression.GreaterThan,
                "GE" => Expression.GreaterThanOrEqual,
                "LT" => Expression.LessThan,
                "LE" => Expression.LessThanOrEqual,
                "EQ" => Expression.Equal,
                _ => null
            };

            if (binExp == null) return null;


            var property = Expression.Property(parm, field);
            var constant = Expression.Constant(value);
            var right = binExp(property, constant);

            return right;
        }

        private Expression ParseTree<T>(
            JsonElement condition,
            ParameterExpression parm)
        {
            Expression left = null;
            var gate = condition.GetProperty(nameof(condition)).GetString();

            JsonElement rules = condition.GetProperty(nameof(rules));

            Binder binder = gate == And ? (Binder)Expression.And : Expression.Or;

            Expression bind(Expression left, Expression right) =>
                left == null ? right : binder(left, right);

            foreach (var rule in rules.EnumerateArray())
            {
                if (rule.TryGetProperty(nameof(condition), out JsonElement check))
                {
                    var right = ParseTree<T>(rule, parm);
                    left = bind(left, right);
                    continue;
                }

                string @operator = rule.GetProperty(nameof(@operator)).GetString();
                string type = rule.GetProperty(nameof(type)).GetString();
                string field = rule.GetProperty(nameof(field)).GetString();

                JsonElement value = rule.GetProperty(nameof(value));

                var property = Expression.Property(parm, field);

                if (@operator == In)
                {
                    var contains = MethodContains.MakeGenericMethod(typeof(string));
                    object val = value.EnumerateArray().Select(e => e.GetString())
                        .ToList();
                    var right = Expression.Call(
                        contains,
                        Expression.Constant(val),
                        property);
                    left = bind(left, right);
                }
                else
                {
                    object val = (type == StringStr || type == BooleanStr) ?
                        (object)value.GetString() : value.GetDecimal();
                    var toCompare = Expression.Constant(val);

                    var right = Expression.Equal(property, toCompare);
                    left = bind(left, right);
                }
            }

            return left;
        }

        public Expression<Func<T, bool>> ParseExpressionOf<T>(JsonDocument doc)
        {
            var itemExpression = Expression.Parameter(typeof(T));
            var conditions = ParseTree<T>(doc.RootElement, itemExpression);
            if (conditions.CanReduce)
            {
                conditions = conditions.ReduceAndCheck();
            }

            Console.WriteLine(conditions.ToString());

            var query = Expression.Lambda<Func<T, bool>>(conditions, itemExpression);
            return query;
        }


        //public Expression<Func<T, bool>> ParseExpressionOf<T>(BinExp binExp, string field, int value, Expression left = null)
        //{
        //    var itemExpression = Expression.Parameter(typeof(T));

        //    var conditions = ParseExpresion<T>(itemExpression, binExp, field, value, left);
        //    if (conditions.CanReduce)
        //    {
        //        conditions = conditions.ReduceAndCheck();
        //    }

        //    Console.WriteLine(conditions.ToString());

        //    var query = Expression.Lambda<Func<T, bool>>(conditions, itemExpression);
        //    return query;
        //}


        public Func<T, bool> ParsePredicateOf<T>(JsonDocument doc)
        {
            var query = ParseExpressionOf<T>(doc);
            return query.Compile();
        }

        //public Func<T, bool> ParsePredicateOf<T>(BinExp binExp, string field, int value, Expression left = null)
        //{
        //    var query = ParseExpressionOf<T>(binExp, field, value, left);
        //    return query.Compile();
        //}

        public Expression<Func<T, bool>> GenerateExp<T>(QueryStandart query)
        {
            var filters = query.FilterArgs(
                out Dictionary<string, PropertyInfo> dict);

            if (filters.Count == 0) return x => true;

            var parameter = Expression.Parameter(typeof(T));

            Expression conditions = null;
            Binder binder = Expression.And;

            Expression bind(Expression left, Expression right) =>
                left == null ? right : binder(left, right);

            foreach (var item in filters)
            {
                if (dict.TryGetValue(item.key, out var prop))
                {
                    object val = prop.PropertyType == typeof(int) ? int.Parse(item.val) : item.val;
                    var rigth = ParseExpresion<T>(parameter, item.op, prop.Name, val);
                    conditions = bind(conditions, rigth);
                }
            }

            if (conditions == null)
            {
                return x => true;
            }

            if (conditions.CanReduce)
            {
                conditions = conditions.ReduceAndCheck();
            }

            var res = Expression.Lambda<Func<T, bool>>(conditions, parameter);
            return res;
        }
    }
}
