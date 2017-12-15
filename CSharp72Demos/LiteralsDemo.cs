using System;

namespace CSharp72Demos
{
    class LiteralsDemo
    {


        public static void Show()
        {
            #region new
            int binary = 0b_111000;
            Console.WriteLine(binary);
            int number = 0x_123_0_235;
            Console.WriteLine(number);
            #endregion
        }

    }
}
