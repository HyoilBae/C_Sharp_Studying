using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A Test1 = new B(); //B라는 객체를 생성하는데 A 클래스를 참조해서 불러낸다.
            Test1.Print();

            //Cast
            B Test2 = new B();
            A Test3 = (A)Test2;
            Test3.Print();
        }
    }
}
