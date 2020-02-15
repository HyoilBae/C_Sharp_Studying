using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();

            list1.Add(11);
            list1.Add(22);
            list1.Add(33);
            list1.RemoveAt(1);
            list1.Remove(11);
            list1.Insert(0, 44);

            foreach (int element in list1)
            {
                Console.WriteLine("{0} ", element);
            }

            List<string> list2 = new List<string>();
            list2.Add("A");
            list2.Add("B");
            list2.Add("C");
            list2.RemoveAt(0);
            list2.Remove("B");
            list2.Insert(1, "D");

            foreach (string element in list2)
            {
                Console.WriteLine("{0} ", element);
            }
        }
    }
}
