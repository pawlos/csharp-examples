using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos.Interfaces
{
    class R2D2 : IStarWarsCharacter
    {
        public void Beep()
        {
            Console.WriteLine("Beep, Beep, Boop");
        }
    }
}
