using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Public, Protected, Private Class
    class A
    {
        int number;
        protected string name = "Hello";
        public A (int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        string name = "World";
        public B(int num): base(num)
        {

        }

        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B(3);
            Test.PrintA();
            Test.PrintB();
        }
    }
}
