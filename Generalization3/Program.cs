using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization3
{
    class Parent
    {
        public string name { set; get; }

        public Parent() { name = "Parent Class";  }
    }
    class Children : Parent
    {
        public Children() { name = "Children Class"; }
    }

    class List<T> where T : Parent
    {
        public T[] array;

        public List() { array = new T[2]; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Parent> list = new List<Parent>();

            list.array[0] = new Parent();
            list.array[1] = new Children();

            Console.WriteLine(list.array[0].name);
            Console.WriteLine(list.array[1].name);
        }
    }
}
