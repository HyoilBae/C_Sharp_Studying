using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Generic
{
    class PrintClassGeneric<T>
    {
        private T var;

        public PrintClassGeneric(T param)
        {
            this.var = param;
        }

        public void printVar()
        {
            Console.WriteLine($"var = {var}");
        }
    }
}
