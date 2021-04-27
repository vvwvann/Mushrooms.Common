using Mushrooms.Core.Extensions;
using System.Linq;
using System.Linq.Expressions;

namespace Mushrooms.Core.Helpers
{
    public class OrderExpHelper<T>
    {
        private readonly IQueryable<T> _source;
        private readonly ParameterExpression _parameter;
        private Expression _exp;
        private int _level;

        public OrderExpHelper(IQueryable<T> source)
        {
            _source = source;
            _parameter = Expression.Parameter(typeof(T));
            _exp = source.Expression;
        }

        public void OrderBy(string columnName, bool desc = false)
        {
            _exp = _source.OrderBy(_exp, _parameter, columnName, _level, desc);
            _level = 1;
        }

        public void OrderBy(LambdaExpression lambda, bool desc = false)
        {
            _exp = _source.OrderBy(_exp, lambda, _level, desc);
            _level = 1;
        }

        public IQueryable<T> Compile()
        {
            return _source.Provider.CreateQuery<T>(_exp);
        }
    }
}
