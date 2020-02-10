using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TETRISSCREEN
{
    List<List<int>> List = new List<List<int>>();

    public void Render()
    {
        for (int y = 0; y < List.Count; ++y)
        {
            for (int x = 0; x < List[y].Count; ++x)
            {
                Console.Write(List[y][x]);
            }
        }Console.WriteLine();
    }

    public TETRISSCREEN(int _X, int _Y)
    {
        for (int y = 0; y < _Y; ++y)
        {
            List.Add(new List<int>());
            for (int x = 0; x < _X; ++x)
            {
                List[y].Add(0);
            }
        }
    }
}

namespace Tetris
{
    class Program
    {
       
        static void Main(string[] args)
        {
            TETRISSCREEN NewSC = new TETRISSCREEN(5, 5);

            NewSC.Render();

            Console.ReadKey();





            //int Arr[][] = new [15][10];

            //Arr[]

            //string Str = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    if (true)
            //    {
            //        Str += "*";
            //    }
            //}



            //for (int y = 0; y < 15; ++y)
            //{
            //    for (int i = 0; i < 10; ++i)
            //    {
            //        if (y == 0 || y == 14)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(".");
            //        }
                  
            //    }

            //    Console.WriteLine("");
            //}

            //Console.CursorLeft = 6;
            //Console.CursorTop = 6;
            //Console.WriteLine("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 7;
            //Console.WriteLine("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 8;
            //Console.WriteLine("O");
            //Console.CursorLeft = 6;
            //Console.CursorTop = 9;
            //Console.WriteLine("O");

            //while (true)
            //{
            //    Console.ReadKey();
            //}
        }
    }
}
