using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PeldaExpressionTree
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Lamba stílusú kifejezés fa építés
            Expression<Func<int, int, int>> osszead = (a, b) => a + b;

            //Kifejezés fa fordítása
            Func<int, int, int> osszeadLambda = osszead.Compile();

            //Meghívása
            int eredmeny = osszeadLambda(1, 2);

            Console.WriteLine("1 + 2 = {0}", eredmeny);

            //Komplex példa
            var HelloLambda = Hello();
            Console.WriteLine("Hello(\"Olvaso\") = {0}", HelloLambda("Olvaso"));

            Console.ReadKey();
        }

        private static Func<string, string> Hello()
        {
            ParameterExpression neve = Expression.Parameter(typeof(string), nameof(neve));

            MethodInfo IsNullOrEmptyMetodus = 
                typeof(string)
                .GetMethod(nameof(string.IsNullOrWhiteSpace));

            UnaryExpression feltetel 
                = Expression.Not(Expression.Call(IsNullOrEmptyMetodus, neve));

            var concatMetodus = 
                typeof(string).GetMethod(nameof(string.Concat), 
                new[] 
                { 
                    typeof(string),
                    typeof(string) 
                });

            var igazEset = 
                Expression.Call(concatMetodus, Expression.Constant("Hello, "), neve);

            ConstantExpression hamisEset = Expression.Constant(null, typeof(string));

            var lambda =
                Expression.Lambda<Func<string, string>>(
                    Expression.Condition(feltetel, igazEset, hamisEset),
                    neve);

            return lambda.Compile();
        }
    }
}