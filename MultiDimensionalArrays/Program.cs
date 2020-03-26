using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single-Dimensional Array Example
            int[] scoreArr = new int[] { 60, 50, 90, 80, 30 };
            int sum = 0;
            for (int i = 0; i < scoreArr.Length; i++)
            {
                sum += scoreArr[i];
            }
            float average = sum / 5;
            Console.WriteLine("Average : {0}", average);


        }
    }
}
