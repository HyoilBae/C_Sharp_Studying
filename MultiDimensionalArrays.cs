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
            Console.WriteLine("-------------Single Array Example-----------");
            int[] scoreArr = new int[] { 60, 50, 90, 80, 30 };
            int sum = 0;
            for (int i = 0; i < scoreArr.Length; i++)
            {
                sum += scoreArr[i];
            }
            float average = sum / 5;
            Console.WriteLine("Average : {0}", average);
            Console.WriteLine();

            //2D Array
            Console.WriteLine("-------------2D Array Example-----------");
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
            Console.WriteLine();

            //3D Array
            Console.WriteLine("-------------3D Array Example-----------");
            int[,,] _3Darray = new int[4, 3, 2]
            {
                {{1,2}, {3,4}, {5,6}},
                {{7,8}, {9,10}, {11,12}},
                {{13, 14 }, {15,16}, {17,18}},
                {{19,20}, {21,22}, {23,24}}
            };
            for (int i = 0; i < _3Darray.GetLength(0); i++)
            {
                for (int j = 0; j < _3Darray.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < _3Darray.GetLength(2); k++)
                    {
                        Console.Write("{0} ", _3Darray[i, j, k]);
                    }
                    Console.Write("} ");
                }
                Console.WriteLine();
            }
            foreach (var item in _3Darray)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();

            //Jagged Array
            Console.WriteLine("-------------Jagged Array Example-----------");
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
