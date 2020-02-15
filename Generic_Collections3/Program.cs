using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();

            stack1.Push(11);
            stack1.Push(22);
            stack1.Push(33);

            while (stack1.Count > 0)
            {
                Console.WriteLine("{0} ", stack1.Pop());
            }


            Stack<string> stack2 = new Stack<string>();

            stack2.Push("ABC");
            stack2.Push("DEF");

            while (stack2.Count > 0)
            {
                Console.WriteLine("{0} ", stack2.Pop());
            }
        }
    }
}
