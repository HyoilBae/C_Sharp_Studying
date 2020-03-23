using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architect_Arithmetic
{
    class Program
    {
        static double RectArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return (Math.PI) * (Math.Pow(radius, 2));
        }

        static double TriArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static void Main(string[] args)
        {
            double RTeo = RectArea(4, 5);
            double RC = CircleArea(4);
            double RT = TriArea(10, 9);

            //total Area of Teotihuacan = 1 triangle + 1 half circle + 1 big Rectangular
            double totalArea = RTeo + RC + RT;

            //Flooring plan = total Area * 180 Mexican Pesos
            double tileCost = 180;
            double flooringPlan = totalArea * tileCost;

            double result = Math.Round(flooringPlan, 2);

            Console.WriteLine($"{result} pesos");

            //result = Math.Round((totalArea*tileCost), 2)
        }
    }
}
