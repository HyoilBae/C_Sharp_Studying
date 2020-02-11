using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6_0_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = (sr.ReadLine());
            //sr.Close();
            Console.WriteLine("{0) {1} {2}", value, value2, str1);


            //using (StreamReader sr = new StreamReader(new FileStream("test.txt", FileMode.Open)))
            //{
            //    int value = int.Parse(sr.ReadLine());
            //    float value2 = float.Parse(sr.ReadLine());
            //    string str1 = sr.ReadLine();
            //    Console.WriteLine("{0) {1} {2}", value, value2, str1);
            //}


            //StreamReader sr1 = new StreamReader("test.txt");
            //int value3 = int.Parse(sr1.ReadLine());
            //float value4 = float.Parse(sr1.ReadLine());
            //string str2 = sr1.ReadLine();
            //Console.WriteLine("{0) {1} {2}", value3, value4, str2);
        }
    }
}
