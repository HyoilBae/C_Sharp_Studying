using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMethod printMethod = new PrintMethod();
            printMethod.DoPrint(10);
            printMethod.DoPrint(3.14);
            printMethod.DoPrint("Hello World");

            Console.WriteLine();

            PrintMethodGeneric printMethodGeneric = new PrintMethodGeneric();
            printMethodGeneric.doPrint(10);
            printMethodGeneric.doPrint(3.14);
            printMethodGeneric.doPrint("Hello World");

            Console.WriteLine();

            PrintClassGeneric<int> printClassGeneric = new PrintClassGeneric<int>(10);
            printClassGeneric.printVar();
            PrintClassGeneric<double> printClassGenericDouble = new PrintClassGeneric<double>(10.3);
            printClassGenericDouble.printVar();

        }
    }
}
