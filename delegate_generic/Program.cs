using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_generic
{
    delegate T MyDelegate<T>(T a, T b);

    class Program
    {
        public static void Caculator<T> (T a, T b, MyDelegate<T> dele)
        {
            Console.WriteLine(dele(a, b));
        }

        public static int plus (int a, int b) { return a + b; }
        public static float plus (float a, float b) { return a + b; }
        public static double plus (double a, double b) { return a + b; }
        static void Main(string[] args)
        {
            MyDelegate<int> intPlus = new MyDelegate<int>(plus);
            MyDelegate<float> floatPlus = new MyDelegate<float>(plus);
            MyDelegate<double> doublePlus = new MyDelegate<double>(plus);

            Caculator(11, 22, intPlus);
            Caculator(11f, 22f, floatPlus);
            Caculator(11d, 22d, doublePlus);
        }
    }
}
