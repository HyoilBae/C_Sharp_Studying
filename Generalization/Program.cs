using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Program
    {
        static void print <T> (T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int age = 29;
            float height = 178.1f;
            string name = "Mr. W";

            print<int>(age);
            print<float>(height);
            print<string>(name);
        }
    }
}
