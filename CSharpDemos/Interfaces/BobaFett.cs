using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos.Interfaces
{
    class BobaFett : IStarWarsCharacter
    {
        public BobaFett()
        {
            Episode = 5;
        }
        public void HuntHanSolo()
        {
            Console.WriteLine("!");
        }

        public void DoNothing()
        {
            
        }

        public int Episode { get; set; }
    }
}
