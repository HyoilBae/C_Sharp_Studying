using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//This program will delete even numbers in the list and will print out the numbers after the first odd number

namespace Delete_starting_evens
{
    class Solution
    {
        public void deleteEvens(int[] nums)
        {
            //this function will get rid of all even numbers...this is what I want
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(nums[i]);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        if (nums[i]%2 != 0)
            //        {
            //            Console.WriteLine(nums[j]);
            //        }
            //    }
            //}


            //or
            //foreach (int num in nums)
            //{
            //    if (num%2 != 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(num);
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 4, 8, 10, 11, 12, 15 };
            Solution s = new Solution();
            s.deleteEvens(Numbers);

            //ArrayList list = new ArrayList();
            //list.Add(4);
            //list.Add(8);
            //list.Add(10);
            //list.Add(11);
            //list.Add(12);
            //list.Add(15);

            Queue que = new Queue();
            que.Enqueue(4);
            que.Enqueue(8);
            que.Enqueue(10);
            que.Enqueue(11);
            que.Enqueue(12);
            que.Enqueue(15);
            //que.Dequeue();
            //que.Enqueue(4.4);
            //que.Dequeue();
            //que.Enqueue("ABC");
            Console.WriteLine("--------------Queue--------------");
          
            //while (que.Count > 0)
            //{
            //    //Console.WriteLine(que.Dequeue());
            //    Console.WriteLine(que);
            //}
            




        }
    }
}
