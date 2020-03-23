using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Generic
{
    class PrintMethod
    {
        public PrintMethod()
        {

        }

        public void DoPrint(int param)
        {
            Console.WriteLine($"param : {param}");
        }

        public void DoPrint(double param)
        {
            Console.WriteLine($"param : {param}");
        }

        public void DoPrint(string param)
        {
            Console.WriteLine($"param : {param}");
        }
    }
}
