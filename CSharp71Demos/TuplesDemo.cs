using System;

namespace CSharp71Demos
{
    class TuplesDemo
    {
        public static void Show()
        {
            #region new
            var count = 5;
            var alamakota = (a: "ala", count);
            Console.WriteLine(alamakota.count);
            #endregion
        }
    }
}
