using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos.Interfaces
{
    class PrincessLeia : IStarWarsCharacter
    {

        public void Say()
        {
            Console.WriteLine("Why, you stuck up, half-witted, scruffy-looking Nerf herder.");
        }
    }
}
