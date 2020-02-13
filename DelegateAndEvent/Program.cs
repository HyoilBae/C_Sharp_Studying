using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    delegate void DelegateType(string str);

    class A
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelMethod1 = new DelegateType(Test.Print);
            DelMethod1("Hello World1");

            DelegateType DelMethod2 = Test.Print;
            DelMethod2("Hello World2");
        }
    }
}
