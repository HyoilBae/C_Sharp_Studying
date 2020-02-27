using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single-Dimensional Array Example
            int[] scoreArr = new int[] { 60, 50, 90, 80, 30 };
            int sum = 0;
            for (int i = 0; i < scoreArr.Length; i++)
            {
                sum += scoreArr[i];
            }
            float average = sum / 5;
            Console.WriteLine("Average : {0}", average);

            //2D Array
            int[,] arrScore = new int[2, 5] { { 90, 80, 70, 42, 30},
                                              { 24, 50, 100, 52, 70 } };
            int[] arrSum = new int[2] { 0, 0 };
            for (int n = 0; n < 2; n++)
            {
                for (int m = 0; m < 5; m++)
                {
                    arrSum[n] += arrScore[n, m];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                average = arrSum[i] / 5;
                Console.WriteLine("Average[" +i+ "] : " + average);
            }

            //Jagged Array
            int[][] jaggedArr = new int[3][]
            {
                new int[] {31, 32, 33 },
                new int[] {41, 42, 43, 44, 45, 46, 48, 70, 71, 72, 74, 76},
                new int[] {0, 1, 5, 7, 2, 1}
            };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("jaggedArr[" +i+ "] : ");
                int size = jaggedArr[i].Length;
                for (int j = 0; j < size; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
