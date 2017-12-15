using System;

namespace CSharpDemos
{
    class TupleDemo
    {
        public static void Show()
        {
            #region old
            var t2 = Tuple.Create("ala", "kota");
            Console.WriteLine(t2.Item1);
            Console.WriteLine(t2.Item2);
            #endregion

            #region new
            var t = (a: "ala", ma: "kota");
            Console.WriteLine(t.a);
            Console.WriteLine(t.ma);

            var count = 5;
            var alamakota = (a:"ala", count: count);
            Console.WriteLine(alamakota.a);
            #endregion

            #region deconstruct
            var (a, ma) = t;
            Console.WriteLine(a);
            Console.WriteLine(ma);
            #endregion

            #region ignore

            var user = (firstName: "Paweł", lastName: "Łukasik");
            var (firstname, _) = user;
            Console.WriteLine(firstname);
            Console.WriteLine(/*_*/);
            #endregion
        }
    }
}
