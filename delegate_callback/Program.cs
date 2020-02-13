using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_callback
{
    delegate int MyDelegate(int a, int b);

    class Program
    {
        public static void Calculator (int a, int b, MyDelegate Mydele)
        {
            Console.WriteLine(Mydele(a, b));
        }

        public static int plus (int a, int b)
        {
            return a + b;
        }

        public static int minus (int a, int b)
        {
            return a - b;
        }

        public static int multiply (int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            MyDelegate Plus = new MyDelegate(plus);
            MyDelegate Minus = new MyDelegate(minus);
            MyDelegate Mutiply = new MyDelegate(multiply);

            Calculator(11, 22, Plus);
            Calculator(11, 22, Minus);
            Calculator(11, 22, Mutiply);

           
        }
    }
}
