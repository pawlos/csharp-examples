using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDemos.Interfaces;

namespace CSharpDemos
{
    class PatternMatchingDemo
    {
        private static Random r = new Random((int)DateTime.Now.Ticks);
        public static void Show()
        {
            #region new

            int year = 2017;
            if (year is 2017)
            {
                Console.WriteLine("The year is 2017.");
            }

            var character = CharacterFactory();
            //(character as DarthVader)
            switch (character)
            {
                case DarthVader dv:
                    dv.Noooooooo();
                    break;
                case PrincessLeia pl:
                    pl.Say();
                    break;
                case BobaFett b when b.Episode == 5:
                    b.HuntHanSolo();
                    break;
                case BobaFett b:
                    b.DoNothing();
                    break;
                case R2D2 r2d2:
                    r2d2.Beep();
                    break;
            }
            #endregion
        }

        private static IStarWarsCharacter CharacterFactory()
        {
            var i = r.Next() % 5;
            if (i == 0)
                return new DarthVader();
            if (i == 1)
                return new BobaFett();
            if (i == 2)
                return new R2D2();

            return new PrincessLeia();
        }
    }
}
