using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72Demos
{
    readonly struct ROExample
    {
        
    }
    struct Point3D
    {
        public Point3D(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public  int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private static Point3D origin = new Point3D();
        public static ref Point3D Origin => ref origin;
    }
    class ReferenceSemanticsDemo
    {
        public static void Input(in Point3D p)
        {
            /*p = new Point3D();*/
        }

        public static void Input(in ROExample roE)
        {
            
        }

        private static ROExample Example = new ROExample();

        public static void Show()
        {
            Input(new Point3D());
            var originValue = Point3D.Origin;
            ref var originReference = ref Point3D.Origin;
            originReference.X = 12;
            ref ROExample roExample = ref Example;
            Input(roExample);
        }
    }
}
