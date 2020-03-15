using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumTwoIntWithOutPlusSign
{
    class Solution
    {
        public int Getsum(int a, int b)
        {
            int[] intSum = new int[2];
            intSum[0] = a;
            intSum[1] = b;
            int result = intSum.Sum();
            return result;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Getsum(7, 2));
        }
    }
}
