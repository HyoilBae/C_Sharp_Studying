using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GTest<T>
{
    public T Data;
}

namespace _38_DataStuructureEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> NewDic;
            List<Dictionary<string, int>> NewTest;

            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);


            DicTest.Add("one", 1);
            DicTest.Add("two", 2);
            DicTest.Add("three", 3);
            DicTest.Add("four", 4);
            DicTest.Add("five", 5);

            foreach (var item in ListTest)
            {
                Console.WriteLine(item);
            }

            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }

            //foreach (var item in DicTest)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
