using System;

namespace _17While
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Check = true;
            while (Check)
            {
                Console.WriteLine("infinite");
                Check = false;
            }

            int CountWhile = 0;
            while (CountWhile <= 5)
            {
                Console.WriteLine(CountWhile);
                CountWhile = CountWhile + 1;
            }

            Check = false;
            do
            {
                Console.WriteLine("infinite");
            } while (Check);

            int Count = 0;
            do
            {
                Count = Count + 1;
                Console.WriteLine(Count);

            } while (Count < 100);
        }
    }
}
