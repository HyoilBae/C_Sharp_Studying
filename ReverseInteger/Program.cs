using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution();
            Console.Write("Enter the Number you want to reverse : ");
            int userInput = Int32.Parse((Console.ReadLine()));
            s1.Reverse(userInput);
            Console.WriteLine("");
            Console.WriteLine("Your input is {0} and your reverse input is {1}", userInput, s1.Reverse(userInput));
            Console.WriteLine("");
        }
    }

    public class Solution
    {

        public int Reverse(int x)
        {
            int reverseN = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;

                // if reverseN == reverseN * 10 + pop causes overflow, it must be reverseN >= int.MaxValue / 10
                // if reverseN > int.MaxValue / 10, then reverseN*10 + pop is guaranteed to overfolow
                // if reverseN == int.MaxValue / 10 , then reverseN*10 + pop will be overflow if and only if pop > 7 since int.MaxValue is 2147483647
                
                // similiar login will be applied when reverseN is negative, int.MinValue is -2147483412
                // if reverseN == reverseN * 10 + pop cause overflow it must be reverseN <= int.MinValue / 10
                // if reverseN < int.MinValue / 10, then reverseN*10 + pop is guranteed to overflow
                // if reverseN == int.MinValue / 10, then reverseN * 10 + pop will be overflow if and only if pop < -8

                // reverseN range should be in -214748364.8 ~ 214748364.7, if not it will overflow

                if ((reverseN > int.MaxValue / 10 )    ||     (reverseN == int.MaxValue / 10)  && (pop) > 7)
                    //Guaranteed overflow                       only if pop is over 7
                {
                    return 0;
                }
                else if ((reverseN < int.MinValue / 10)   ||    (reverseN == int.MinValue / 10)  &&  (pop) < -8)
                         //Guaranteed overflow                    only if pop is under -8
                {
                    return 0;
                }
                reverseN = (reverseN * 10) + pop;
            }
            return reverseN;


            //int reverseNumber = 0;
            //while (x != 0)
            //{
            //    reverseNumber = (reverseNumber * 10) + (x % 10);
            //    x /= 10;
            //    if (reverseNumber > int.MaxValue / 10 || (reverseNumber == int.MaxValue / 10 && (x % 10) > 7))
            //    {
            //        return 0;
            //    }
            //    else if (reverseNumber < int.MinValue / 10 || (reverseNumber == int.MinValue / 10 && (x % 10) < -8))
            //    {
            //        return 0;
            //    }
            //    reverseNumber = (reverseNumber * 10) + (x % 10);
            //}
            //return reverseNumber;


            //int reverseNumber = 0;
            //while (x !=0)
            //{
            //    reverseNumber = (reverseNumber * 10) + (x % 10);
            //    x /= 10;
            //}
            //if (reverseNumber < int.MinValue || int.MaxValue < reverseNumber)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return reverseNumber;
            //}


            //int reverseNumber = 0;
            //while (x > 0)
            //{
            //    reverseNumber = x % 10;
            //        x /= 10;
            //    Console.Write(reverseNumber);
            //}
            //return reverseNumber;
        }
    }
}
