using System;

namespace CSharp72Demos
{
    class NonTrailingNamedArguments
    {
        public static void Show()
        {
            FunctionWithNamedArguments(5, 2, c: 2);

            #region new
            FunctionWithNamedArguments(a: 5, 2, c: 2);
            #endregion
        }

        public static void FunctionWithNamedArguments(int a, int b, int c)
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }

    }
}
