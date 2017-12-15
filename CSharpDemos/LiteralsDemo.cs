using System;

namespace CSharpDemos
{
    class LiteralsDemo
    {


        public static void Show()
        {
            #region new
            int binary = 0b1_1_1_0000;
            Console.WriteLine(binary);
            int number = 123_0_2_35;
            Console.WriteLine(number);
            #endregion
        }

    }
}
