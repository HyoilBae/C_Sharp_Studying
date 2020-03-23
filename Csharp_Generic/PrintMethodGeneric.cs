using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Generic
{
    class PrintMethodGeneric
    {
        public PrintMethodGeneric()
        {

        }

        public void doPrint<T>(T param)
        {
            Console.WriteLine($"param : {param}");
        }
    }
}
