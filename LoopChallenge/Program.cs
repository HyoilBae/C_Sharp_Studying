using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcd efg hijk lmnop";
            string[] arrAlphabet = alphabet.Split(' ');
            
            //foreach (var str in arrAlphabet)
            //{
            //    Console.WriteLine(str);
            //}

            for (int i = 0; i < arrAlphabet.Length; i++)
            {
                string temp;
                temp = arrAlphabet[arrAlphabet.Length - 1];
                arrAlphabet[arrAlphabet.Length -1] = arrAlphabet[0];
                arrAlphabet[0] = temp;
                Console.Write(arrAlphabet[i] + " ");
            }

            

        }
    }
}
