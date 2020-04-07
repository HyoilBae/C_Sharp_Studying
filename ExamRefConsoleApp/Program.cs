using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace ExamRefConsoleApp
{
    class Program
    {
        static object lockingObject = new object();
        static long sharedTotal = 0;
        static int[] items = Enumerable.Range(0, 50000001).ToArray();
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            int rangeSize = 1000;
            int rangeStart = 0;

            AddItemsArray(items);
            Console.WriteLine(sharedTotal);
            sharedTotal = 0;

            while (rangeStart < items.Length)
            {
                int rangeEnd = rangeStart + rangeSize;

                if (rangeEnd > items.Length)
                {
                    rangeEnd = items.Length;
                }

                int rs = rangeStart;
                int re = rangeEnd;

                tasks.Add(Task.Run(() => addRangeOfValues(rs, re)));
                rangeStart = rangeEnd;
            }

            Task.WaitAll(tasks.ToArray());
            Console.WriteLine(sharedTotal);
        }

        public static void addRangeOfValues(int start, int end)
        {
            long subtotal = 0;
            while (start < end)
            {
                subtotal += items[start];
                start++;
            }
            lock (lockingObject)
            {
                sharedTotal += subtotal;
            }
        }

        public static void AddItemsArray(int[] integerArray)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                sharedTotal += integerArray[i];
            }
        }
    }
}
