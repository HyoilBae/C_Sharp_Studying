using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printNumbersAfterFirstOddNumber
{
    public class Solution
    {
        public void afterOdd(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 4, 8, 10, 11, 12, 15 };
            Solution s = new Solution();
            s.afterOdd(Numbers);
        }
    }
}
