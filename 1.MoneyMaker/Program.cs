using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("How much coin do you have?");
            string howMuch = Console.ReadLine();
            double howMuchDouble = Convert.ToDouble(howMuch);

            Console.WriteLine($"{howMuchDouble} cents is equal to...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoin = Math.Floor(howMuchDouble / goldValue);
            double leftOver = Math.Floor(howMuchDouble % goldValue);
            double silverCoin = Math.Floor(leftOver / silverValue);
            leftOver = Math.Floor(leftOver % silverValue);

            Console.WriteLine($"Gold coins : {goldCoin}");
            Console.WriteLine($"Silver coins : {silverCoin}");
            Console.WriteLine($"Bronze coins : {leftOver}");




        }
    }
}
