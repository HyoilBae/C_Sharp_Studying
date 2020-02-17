using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda
{
    class Program
    {
        delegate int MyDelegate(int a, int b);
        delegate void MyDelegate2();
        delegate void MyDelegateCompare(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate add = (a, b) => a + b;
            MyDelegate2 lamda = () => Console.WriteLine("Lamda");

            Console.WriteLine("11 + 22 = {0}", add(11, 22));
            lamda();


            MyDelegateCompare Compare = (a, b) =>
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} is bigger than {b}");
                }
                else if (a < b)
                {
                    Console.WriteLine($"{b} is bigger than {a}");
                }
                else
                {
                    Console.WriteLine($"{a} and {b} are equal");
                }
            };

            Compare(11, 22);
        }
    }
}
