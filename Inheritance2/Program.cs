using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    abstract class A
    {
        int number = 3;
        public abstract void Print();
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintNumber();
        }
    }
}
