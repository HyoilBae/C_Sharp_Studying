using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("2019-0000G1", "Park", 20, "Baseball");
            Console.WriteLine($"student1.GetId()\t: {student1.GetId()}");
            Console.WriteLine($"student1.GetName()\t: {student1.GetName()}");
            Console.WriteLine($"student1.GetAge()\t: {student1.GetAge()}");
            Console.WriteLine($"student1.GetMajor()\t: {student1.GetMajor()}");
        }
    }
}
