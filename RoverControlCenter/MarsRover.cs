using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class MarsRover : Rover
    {
        public MarsRover(string alias, int yearLanded): base(alias, yearLanded)
        {

        }

        public override string Explore()
        {
            return "Mars rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Mars rover is collecting rocks!";
        }
    }
}
