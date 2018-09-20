using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// Generating SQL from expression trees, Part 2
    /// http://ryanohs.com/2016/04/generating-sql-from-expression-trees-part-2/#more-394
    /// </summary>
    public class WhereBuilder
    {
        private readonly char _columnBeginChar = '[';
        private readonly char _columnEndChar = ']';
        private System.Collections.ObjectModel.ReadOnlyCollection<ParameterExpression> expressParameterNameCollection;

        public WhereBuilder(char columnChar = '`')
        {
            this._columnBeginChar = this._columnEndChar = columnChar;
        }

        //public WhereBuilder(char columnBeginChar = '[', char columnEndChar = ']')
        //{
        //    this._columnBeginChar = columnBeginChar;
        //    this._columnEndChar = columnEndChar;
        //}

        /// <summary>
        /// LINQ转SQL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public WherePart ToSql<T>(Expression<Func<T, bool>> expression)
        {
            var i = 1;
            if (expression.Parameters.Count > 0)
            {
                this.expressParameterNameCollection = expression.Parameters;
            }
            return Recurse(ref i, expression.Body, isUnary: true);
        }

        /// <summary>
        /// LINQ转SQL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="i">种子值</param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public WherePart ToSql<T>(ref int i, Expression<Func<T, bool>> expression)
        {
            if (expression.Parameters.Count > 0)
            {
                this.expressParameterNameCollection = expression.Parameters;
            }
            return Recurse(ref i, expression.Body, isUnary: true);
        }

        /// <summary>
        /// LINQ转SQL
        /// </summary>
        /// <param name="i">种子值</param>
        /// <param name="expression"></param>
        /// <param name="isUnary"></param>
        /// <param name="prefix"></param>
        /// <param name="postfix"></param>
        /// <returns></returns>
        private WherePart Recurse(ref int i, Expression expression, bool isUnary = false, string prefix = null, string postfix = null)
        {
            if (expression is UnaryExpression)
            {
                var unary = (UnaryExpression)expression;
                return WherePart.Concat(NodeTypeToString(unary.NodeType), Recurse(ref i, unary.Operand, true));
            }
            if (expression is BinaryExpression)
            {
                var body = (BinaryExpression)expression;
                return WherePart.Concat(Recurse(ref i, body.Left), NodeTypeToString(body.NodeType), Recurse(ref i, body.Right));
            }
            if (expression is ConstantExpression)
            {
                var constant = (ConstantExpression)expression;
                var value = constant.Value;
                if (value is int)
                {
                    return WherePart.IsSql(value.ToString());
                }
                if (value is string)
                {
                    value = prefix + (string)value + postfix;
                }
                if (value is bool && isUnary)
                {
                    return WherePart.Concat(WherePart.IsParameter(i++, value), "=", WherePart.IsSql("1"));
                }
                return WherePart.IsParameter(i++, value);
            }
            if (expression is MemberExpression)
            {
                var member = (MemberExpression)expression;
                var memberExpress = member.Expression;
                if (member.Member is PropertyInfo && this.IsContainsParameterExpress(member))
                {
                    var property = (PropertyInfo)member.Member;
                    //var colName = _tableDef.GetColumnNameFor(property.Name);
                    var colName = property.Name;
                    if (isUnary && member.Type == typeof(bool))
                    {
                        return WherePart.Concat(Recurse(ref i, expression), "=", WherePart.IsParameter(i++, true));
                    }
                    return WherePart.IsSql(string.Format("{0}{1}{2}", this._columnBeginChar, colName, this._columnEndChar));
                }
                if (member.Member is FieldInfo || !this.IsContainsParameterExpress(member))
                {
                    var value = GetValue(member);
                    if (value is string)
                    {
                        value = prefix + (string)value + postfix;
                    }
                    return WherePart.IsParameter(i++, value);
                }
                throw new Exception($"Expression does not refer to a property or field: {expression}");
            }
            if (expression is MethodCallExpression)
            {
                var methodCall = (MethodCallExpression)expression;
                //方法表达式需要验证调用对象是否是属性表达式&&属性表达式中的参数表达式是否是表达式参数集合中的实例（或者表达式中包含的其他表达式中的参数表达式）
                if (methodCall.Object is MemberExpression && this.IsContainsParameterExpress(methodCall))
                {
                    // LIKE queries:
                    if (methodCall.Method == typeof(string).GetMethod("Contains", new[] { typeof(string) }))
                    {
                        return WherePart.Concat(Recurse(ref i, methodCall.Object), "LIKE", Recurse(ref i, methodCall.Arguments[0], prefix: "%", postfix: "%"));
                    }
                    if (methodCall.Method == typeof(string).GetMethod("StartsWith", new[] { typeof(string) }))
                    {
                        return WherePart.Concat(Recurse(ref i, methodCall.Object), "LIKE", Recurse(ref i, methodCall.Arguments[0], postfix: "%"));
                    }
                    if (methodCall.Method == typeof(string).GetMethod("EndsWith", new[] { typeof(string) }))
                    {
                        return WherePart.Concat(Recurse(ref i, methodCall.Object), "LIKE", Recurse(ref i, methodCall.Arguments[0], prefix: "%"));
                    }
                    // IN queries:
                    if (methodCall.Method.Name == "Contains")
                    {
                        Expression collection;
                        Expression property;
                        if (methodCall.Method.IsDefined(typeof(ExtensionAttribute)) && methodCall.Arguments.Count == 2)
                        {
                            collection = methodCall.Arguments[0];
                            property = methodCall.Arguments[1];
                        }
                        else if (!methodCall.Method.IsDefined(typeof(ExtensionAttribute)) && methodCall.Arguments.Count == 1)
                        {
                            collection = methodCall.Object;
                            property = methodCall.Arguments[0];
                        }
                        else
                        {
                            throw new Exception("Unsupported method call: " + methodCall.Method.Name);
                        }
                        var values = (IEnumerable)GetValue(collection);
                        return WherePart.Concat(Recurse(ref i, property), "IN", WherePart.IsCollection(ref i, values));
                    }
                }
                else
                {
                    var value = GetValue(expression);
                    if (value is string)
                    {
                        value = prefix + (string)value + postfix;
                    }
                    return WherePart.IsParameter(i++, value);
                }

                throw new Exception("Unsupported method call: " + methodCall.Method.Name);
            }
            if (expression is NewExpression)
            {
                var member = (NewExpression)expression;
                var value = GetValue(member);
                if (value is string)
                {
                    value = prefix + (string)value + postfix;
                }
                return WherePart.IsParameter(i++, value);
            }
            throw new Exception("Unsupported expression: " + expression.GetType().Name);
        }

        private bool IsContainsParameterExpress(Expression expression)
        {
            bool result = false;
            if (this.expressParameterNameCollection != null && this.expressParameterNameCollection.Count > 0 && expression != null)
            {
                if (expression is MemberExpression)
                {
                    if (this.expressParameterNameCollection.Contains(((MemberExpression)expression).Expression))
                    {
                        result = true;
                    }
                }
                else if (expression is MethodCallExpression)
                {
                    MethodCallExpression methodCallExpression = (MethodCallExpression)expression;
                    if (methodCallExpression.Object != null && methodCallExpression.Object is MemberExpression)
                    {
                        MemberExpression MemberExpression = (MemberExpression)methodCallExpression.Object;
                        if (MemberExpression.Expression != null && this.expressParameterNameCollection.Contains(MemberExpression.Expression))
                        {
                            result = true;
                        }
                    }
                    if (methodCallExpression.Arguments != null && methodCallExpression.Arguments.Count > 0 && methodCallExpression.Arguments[0] is MemberExpression)
                    {
                        MemberExpression memberExpression = (MemberExpression)methodCallExpression.Arguments[0];
                        if (memberExpression.Expression != null && this.expressParameterNameCollection.Contains(memberExpression.Expression))
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        private static object GetValue(Expression member)
        {
            // source: http://stackoverflow.com/a/2616980/291955
            var objectMember = Expression.Convert(member, typeof(object));
            var getterLambda = Expression.Lambda<Func<object>>(objectMember);
            var getter = getterLambda.Compile();
            return getter();
        }

        private static string NodeTypeToString(ExpressionType nodeType)
        {
            switch (nodeType)
            {
                case ExpressionType.Add:
                    return "+";
                case ExpressionType.And:
                    return "&";
                case ExpressionType.AndAlso:
                    return "AND";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Equal:
                    return "=";
                case ExpressionType.ExclusiveOr:
                    return "^";
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.Modulo:
                    return "%";
                case ExpressionType.Multiply:
                    return "*";
                case ExpressionType.Negate:
                    return "-";
                case ExpressionType.Not:
                    return "NOT";
                case ExpressionType.NotEqual:
                    return "<>";
                case ExpressionType.Or:
                    return "|";
                case ExpressionType.OrElse:
                    return "OR";
                case ExpressionType.Subtract:
                    return "-";
            }
            throw new Exception($"Unsupported node type: {nodeType}");
        }
    }

    public class WherePart
    {
        /// <summary>
        /// 含有参数变量的SQL语句
        /// </summary>
        public string Sql { get; set; }
        /// <summary>
        /// SQL语句中的参数变量
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

        public static WherePart IsSql(string sql)
        {
            return new WherePart()
            {
                Parameters = new Dictionary<string, object>(),
                Sql = sql
            };
        }

        public static WherePart IsParameter(int count, object value)
        {
            return new WherePart()
            {
                Parameters = { { count.ToString(), value } },
                Sql = $"@{count}"
            };
        }

        public static WherePart IsCollection(ref int countStart, IEnumerable values)
        {
            var parameters = new Dictionary<string, object>();
            var sql = new StringBuilder("(");
            foreach (var value in values)
            {
                parameters.Add((countStart).ToString(), value);
                sql.Append($"@{countStart},");
                countStart++;
            }
            if (sql.Length == 1)
            {
                sql.Append("null,");
            }
            sql[sql.Length - 1] = ')';
            return new WherePart()
            {
                Parameters = parameters,
                Sql = sql.ToString()
            };
        }

        public static WherePart Concat(string @operator, WherePart operand)
        {
            return new WherePart()
            {
                Parameters = operand.Parameters,
                Sql = $"({@operator} {operand.Sql})"
            };
        }

        public static WherePart Concat(WherePart left, string @operator, WherePart right)
        {
            return new WherePart()
            {
                Parameters = left.Parameters.Union(right.Parameters).ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
                Sql = $"({left.Sql} {@operator} {right.Sql})"
            };
        }
    }
}