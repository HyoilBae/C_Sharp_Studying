using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);
    class Program
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
   
        static void Main(string[] args)
        {
            MyDelegate calculate = new MyDelegate(Plus);
            int sum = calculate(11, 22);
            Console.WriteLine(sum);

            calculate = new MyDelegate(Minus);
            Console.WriteLine(calculate(22, 11));
        }
    }
}
