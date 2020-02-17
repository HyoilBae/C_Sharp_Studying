using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace reverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            ////##########Solution#1###############
            //for (int i = 0; i < s.Length/2; i++)
            //{
            //    var tmp = s[i];
            //    s[i] = s[s.Length - (i + 1)];
            //    s[s.Length - (i + 1)] = tmp;
            //}
            //Console.WriteLine(s);

            //Solution#2
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char tmp = s[left];
                s[left++] = s[right];
                s[right--] = tmp;
            }
            Console.WriteLine(s);

            //####This works but I don't know why LeetCode makes errors?
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int j = s.Length - (i + 1);
            //    Console.Write(s[j]);
            //}
            //Console.WriteLine("");

            //Console.WriteLine("foreach loop");
            //foreach (char element in s)
            //{
            //    Console.Write(element);
            //}

            //Console.WriteLine("for loop");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine($"char[] s char{(i)} = {s[i]}");
            //}


            //char[] reverseS = Array.Reverse(s);
            //Console.WriteLine(reverseS);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //solution.ReverseString(alphabet);

            Console.WriteLine("Enter : ");
            string userInput = Console.ReadLine();
            //Console.WriteLine(userInput.GetType());
            char[] userInputChar = userInput.ToCharArray();
            solution.ReverseString(userInputChar);

            //Console.WriteLine(alphabet);
            //Array.Reverse(alphabet);
            //Console.WriteLine(alphabet);
            //Console.WriteLine(alphabet.GetType());


            //Console.WriteLine("Enter a string");
            //string userString = (Console.ReadLine()).ToLower();
            //char[] userStringChar = userString.ToCharArray();
            //char[] reverseString = new char[userStringChar.Length];
            //for (int i = 0; i < userStringChar.Length; i++)
            //{

            //}

        }
    }
}
