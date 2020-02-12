using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addGreetings
{
    class Solution
    {
        public void AddGreetings(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] Names = { "Owen", "Max", "Sophie" };
            s.AddGreetings(Names);
        }
    }
}
