using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_chain
{
    delegate void MyDelegate();
    class Program
    {
        public static void method1() { Console.WriteLine("Method1"); }
        public static void method2() { Console.WriteLine("Method2"); }
        public static void method3() { Console.WriteLine("Method3"); }

        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(method1);
            del1 += method2;
            del1 += method3;

            del1();

            del1 -= method2;
            del1 -= method3;

            del1();
        }
    }
}
