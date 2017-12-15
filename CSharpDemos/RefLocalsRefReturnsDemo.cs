using System;
using System.Drawing;

namespace CSharpDemos
{
    
    class RefLocalsRefReturnsDemo
    {
        static Point _p = new Point(100, 100);

        public static ref Point GetHalfPoint()
        {
            return ref _p;
        }

        public static void Show()
        {
            ref var p1 = ref GetHalfPoint();
            p1.X = 12;
            Console.WriteLine($"Point: {_p}");
            Console.WriteLine($"Point: {p1}");
        }
    }

    
}
