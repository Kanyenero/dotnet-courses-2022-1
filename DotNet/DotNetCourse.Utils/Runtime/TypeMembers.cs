using System.Reflection;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DotNetCourse.Utils.Runtime
{
    public static class TypeMembers
    {
        public static T GetAttribute<T>(this MemberInfo member, bool isRequired)
            where T : Attribute
        {
            var attribute = member.GetCustomAttributes(typeof(T), false).SingleOrDefault();

            if (attribute == null && isRequired)
                throw new ArgumentException(typeof(T).Name, member.Name);

            return (T)attribute!;
        }

        public static string GetPropertyDisplayName<T>(Expression<Func<T, object>> propertyExpression)
        {
            var memberInfo = GetPropertyInformation(propertyExpression.Body);

            if (memberInfo == null)
                throw new ArgumentException("No property reference expression was found.", nameof(propertyExpression));

            var attr = memberInfo.GetAttribute<DisplayNameAttribute>(false);

            if (attr == null)
                return memberInfo.Name;

            return attr.DisplayName;
        }

        public static MemberInfo GetPropertyInformation(Expression propertyExpression)
        {
            var memberExpr = propertyExpression as MemberExpression;

            if (memberExpr == null)
            {
                if (propertyExpression is UnaryExpression unaryExpr && unaryExpr.NodeType == ExpressionType.Convert)
                    memberExpr = unaryExpr.Operand as MemberExpression;
            }

            if (memberExpr == null || memberExpr.Member.MemberType != MemberTypes.Property)
                return null!;

            return memberExpr.Member;
        }

        public static bool TrySetProperty<T>(this T obj, string propertyName, object value)
            where T : class
        {
            var prop = obj.GetType().GetProperty(propertyName);

            if (prop != null && prop.CanWrite)
            {
                prop.SetValue(obj, value, null);

                return true;
            }

            return false;
        }
    }
}
