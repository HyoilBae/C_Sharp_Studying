using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.NameGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Name
            string name = "Farhad Hesam Abbasi";

            // Get first letter
            int charPosition = name.IndexOf("F");  //Locate the first Letter of his first name
            Console.WriteLine(charPosition);
            char firstLetter = name[charPosition];
            Console.WriteLine(firstLetter);

            // Get last name
            charPosition = name.IndexOf("Abbasi");
            Console.WriteLine(charPosition);
            string lastName = name.Substring(charPosition);   //show the string of name from charPosition
            Console.WriteLine(lastName);

            // Print results
            Console.WriteLine($"{firstLetter}. {lastName}");




            string msg = "Yabba dabba doo!";

            charPosition = msg.IndexOf("Y");
            char firstChar = msg[charPosition];
            Console.WriteLine(firstChar);
        }
    }
}
