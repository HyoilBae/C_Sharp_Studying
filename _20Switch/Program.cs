using System;

namespace _20Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            int SwitchTest = 70;
                
            switch (SwitchTest)
            {
                case 0:
            break;
                case 10:
            break;
                case 100:
            Console.WriteLine("Switch Test is 100");
            break;

                case 1000:
                case 10000:
                    Console.WriteLine("SwitchTest is 1000 or 10000");
                    break;


             default: //else 의 역할
                    Console.WriteLine("the answer is default");
             break;
            }
        }
    }
}
