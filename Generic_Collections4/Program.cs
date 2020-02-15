using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_Collections4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d1 = new Dictionary<string, string>();

            d1["Banana"] = "바나나";
            d1["Apple"] = "사과";

            Console.WriteLine(d1["Banana"]);
            Console.WriteLine(d1["Apple"]);
        }
    }
}
