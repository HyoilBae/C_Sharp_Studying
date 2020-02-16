using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class A
    {
        private int[] number = new int[5];
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            for (int i = 0; i < 5; i++)
            {
                test[i] = i;
                Console.WriteLine(test[i]);
            }
        }
    }
}
