using System.Linq.Expressions;
using System.Reflection;

namespace DotNetCourse.Utils.Expressions
{
    public class GenericFilter<TItem>
    {
        public enum FilterType
        {
            Equal,
            LessThan,
            GreaterThan
        }

        private readonly ParameterExpression _parameterExpression;

        public GenericFilter()
        {
            _parameterExpression = Expression.Parameter(typeof(TItem), nameof(TItem));
        }

        private Expression _expression = default!;

        public IQueryable<TItem> Apply(IQueryable<TItem> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            if (_expression == null)
                return collection;

            var lambda = Expression.Lambda<Func<TItem, bool>>(
                _expression,
                new[] { _parameterExpression });

            var methodCallResult = Expression.Call(
                typeof(Queryable),
                "Where",
                new Type[] { typeof(TItem) },
                collection.Expression,
                lambda);

            return collection.Provider.CreateQuery<TItem>(methodCallResult);
        }

        public void AddFilter<TValue>(string propName, FilterType filterType, TValue arg)
            where TValue : IComparable<TValue>
        {
            var methodCallResult = CallMethod("CompareTo", propName, arg);

            var negative = Expression.Constant(-1, typeof(int));
            var zero = Expression.Constant(0, typeof(int));
            var positive = Expression.Constant(1, typeof(int));

            Expression localExpression = null!;

            switch (filterType)
            {
                case FilterType.Equal:
                    localExpression = Expression.Equal(methodCallResult, zero);
                    break;

                case FilterType.LessThan:
                    localExpression = Expression.Equal(methodCallResult, negative);
                    break;

                case FilterType.GreaterThan:
                    localExpression = Expression.Equal(methodCallResult, positive);
                    break;
            }

            _expression = CombineExpressions(_expression, localExpression);
        }

        public void AddRangeFilter<TValue>(string propName, TValue left, TValue right)
            where TValue : IComparable<TValue>
        {
            int argsCompareResult = left.CompareTo(right);

            if (argsCompareResult < 0)
            {
                AddFilter(propName, FilterType.GreaterThan, left);
                AddFilter(propName, FilterType.LessThan, right);
                return;
            }

            if (argsCompareResult > 0)
            {
                AddFilter(propName, FilterType.LessThan, left);
                AddFilter(propName, FilterType.GreaterThan, right);
                return;
            }
        }

        public void AddContainsFilter<TValue>(string propName, TValue arg)
            where TValue : IComparable<TValue>
        {
            var methodCallResult = CallMethod("Contains", propName, arg);
            var localExpression = Expression.Equal(methodCallResult, Expression.Constant(true, typeof(bool)));

            _expression = CombineExpressions(_expression, localExpression);
        }

        public void Flush()
        {
            _expression = null!;
        }

        private MethodCallExpression CallMethod<TValue>(string method, string prop, TValue arg)
        {
            var argType = typeof(TValue);
            var argValue = Expression.Constant(arg, argType);

            var propInfo = GetProperty<TItem>(prop);
            var propValue = Expression.MakeMemberAccess(_parameterExpression, propInfo);

            var methodInfo = GetMethodInfo<TValue>(method, new Type[] { argType });
            return Expression.Call(propValue, methodInfo, argValue);
        }

        private static PropertyInfo GetProperty<T>(string name)
        {
            var type = typeof(T);
            var propInfo = type.GetProperty(name);
            return propInfo ?? throw new NullReferenceException(nameof(propInfo));
        }

        private static MethodInfo GetMethodInfo<T>(string name, Type[] types)
        {
            var type = typeof(T);
            var method = type.GetMethod(name, types);
            return method ?? throw new NullReferenceException(nameof(method));
        }

        private static Expression CombineExpressions(Expression left, Expression right)
        {
            if (left == null && right == null)
                throw new ArgumentNullException($"[{nameof(left)}, {nameof(right)}]", "was null");

            if (left == null)
            {
                left = right;
                return left;
            }

            if (right == null)
                return left;

            return Expression.And(left, right);
        }
    }
}
