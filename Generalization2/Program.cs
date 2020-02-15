using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generalization2
{
    class List <T>
    {
        public T[] arr;

        public List() { arr = new T[1]; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.arr[0] = 10;
            List<float> list2 = new List<float>();
            list2.arr[0] = 2.2f;
            List<string> list3 = new List<string>();
            list3.arr[0] = "ABC";

            Console.WriteLine(list1.arr[0]);
            Console.WriteLine(list2.arr[0]);
            Console.WriteLine(list3.arr[0]);
        }
    }
}
