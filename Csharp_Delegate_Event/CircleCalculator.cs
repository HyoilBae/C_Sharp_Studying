using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Delegate_Event
{
    delegate double CircleDelegate(double r);
    class CircleCalculator
    {
        double circleRatio = 3.14d;
        public CircleCalculator()
        {
            //default constructor
        }

        public double GetArea(double r)
        {
            return r * r * circleRatio;
        }

        public double GetLength(double r)
        {
            return 2 * circleRatio * r;
        }
    }
}
