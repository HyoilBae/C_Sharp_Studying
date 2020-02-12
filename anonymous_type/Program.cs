using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_type
{
    delegate int Mydelegate(int a, int b);
    class Program
    {
        

        static void Main(string[] args)
        {
            var anony = new { age = 11, name = "ABC" };

            Console.WriteLine("Age: {0}, Name: {1}", anony.age, anony.name);

            var anonyArray = new
            {
                Int = new int[] { 1, 2, 3, 4, 5 },
                Float = new float[] { 1.1f, 2.2f, 3.3f, 4.4f }
            };

            foreach (var element in anonyArray.Int)
            {
                Console.WriteLine("{0}", element);
            }

            foreach (var element in anonyArray.Float)
            {
                Console.WriteLine("{0}", element);
            }



            Mydelegate add;
            add = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(add(11, 22));
        }
    }
}
