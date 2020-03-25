using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Name: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Your name is {0}", userName);
            //Console.WriteLine($"Your name is {userName}");

            int n1 = 10;
            int n2 = 5;
            int n3;
            n3 = 20;
            int n4 = 5;

            if (n1 > n2 && n2 < n3)
            {
                Console.WriteLine("n1 > n2 AND n2 < n3");
            }

            if (n1 > n2 || n2 < n3)
            {
                Console.WriteLine("n1 > n2 OR n2 < n3");
            }

            if (n1 == n2)
            {
                Console.WriteLine("n1 is equls to n2");
            }
            else if (n1 == n3)
            {
                Console.WriteLine("n1 is equals to n3");
            }
            else if (n1 == n4)
            {
                Console.WriteLine("n1 is euqals to n3");
            }

            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("n1 equals to n2");
                    break;
                case 2:
                    Console.WriteLine("n21 equals to n3");
                    break;
                default:
                    break;
            }



        }
    }
}
