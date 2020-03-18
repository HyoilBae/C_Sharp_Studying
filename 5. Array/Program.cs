using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] summerStrut;

            //summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            //int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            //int threeRating = Array.IndexOf(ratings, 3);

            //Console.WriteLine($"Song number {threeRating + 1} is rated three stars");

            //string tenSong = Array.Find(summerStrut, song => song.Length > 10);
            //Console.WriteLine($"The first song that has more tha 10 characters in the title is {tenSong}");

            //Array.Sort(summerStrut);
            //string firstSong = summerStrut[0];
            //string lastSong = summerStrut[7];
            //Console.WriteLine(firstSong);
            //Console.WriteLine(lastSong);




            //string[] summerStrut;

            string[] summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            string[] summerStrutCopy = new string[summerStrut.Length];
            //string[] stringArray = new string[Array]
            //string[] stringArray = new string[]
            //string[] stringArray;
            //stringArray = new String

            Array.Copy(summerStrut, summerStrutCopy, summerStrut.Length);

            Console.WriteLine(summerStrutCopy[0]);
            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0] + "\n" + summerStrut[7]);
            //Console.WriteLine(summerStrut[7]);      
            Array.Clear(ratings, 0, ratings.Length);
            Console.WriteLine(ratings[0]);
        }
    }
}
