using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> que1 = new Queue<int>();

            que1.Enqueue(11);
            que1.Enqueue(22);
            que1.Enqueue(33);

            while (que1.Count > 0)
            {
                Console.WriteLine("{0} ", que1.Dequeue());
            }

            Queue<string> que2 = new Queue<string>();

            que2.Enqueue("ABC");
            que2.Enqueue("DEF");

            while (que2.Count > 0)
            {
                Console.WriteLine("{0} ", que2.Dequeue());
            }

        }
    }
}
