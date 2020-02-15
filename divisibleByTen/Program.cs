using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibleByTen
{
    class Solution
    {
        public int DivideByTen(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num%10 == 0)
                {
                    count++;
                }
            }
            return count;
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] test = new int[]{ 20, 25, 30, 35, 40 };

            Console.WriteLine(s.DivideByTen(test));
        }
    }
}
