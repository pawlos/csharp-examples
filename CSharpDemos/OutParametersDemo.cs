using System;

namespace CSharpDemos
{
    class OutParametersDemo
    {
        public static void Show()
        {
            #region old
            {
                int year = 0;
                if (int.TryParse("1977", out year))
                {
                    Console.WriteLine($"Ok! year: {year}");
                }
            }

            #endregion
            #region new
            {
                if (int.TryParse("1977", out int year))
                {
                    Console.WriteLine($"Ok! year: {year}");
                }
            }
            #endregion
            #region skip
            {
                if (int.TryParse("1977", out _))
                {
                    Console.WriteLine("Ok. But now year {_}");
                }
            }
            #endregion
        }
    }
}
