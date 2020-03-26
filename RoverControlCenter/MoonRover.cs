using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class MoonRover : Rover
    {
        public MoonRover(string alias, int yearLanded) : base(alias, yearLanded)
        {

        }

        public override string Explore()
        {
            return $"Moon rover {Alias} is exploring the surface!";
        }

        public override string Collect()
        {
            return $"Moon rover {Alias} is collecting rocks!";
        }
    }
}
