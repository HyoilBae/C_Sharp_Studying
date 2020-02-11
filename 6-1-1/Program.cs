using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6_1_1
{
    struct GRADE
    {
        public int kor, eng, math, total;
        public int average;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            float average;

            Console.Write("How many students?");
            int StudentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("KOR ENG MATH");
            GRADE[] Grade = new GRADE[StudentCount];

            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("Student Number: {0}", StudentCount);

            for (int i = 0; i < StudentCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                Grade[i].kor = int.Parse(DataString[0]);
                Grade[i].eng = int.Parse(DataString[1]);
                Grade[i].math = int.Parse(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
                average = Grade[i].total / 3.0f;
                Grade[i].average = (int)Math.Round(average);
            }

            for (int i = 0; i < StudentCount; i++)
            {
                sw.WriteLine("{0}, {1}, {2}, {3}, {4:f1}", Grade[i].kor, Grade[i].eng, Grade[i].math, 
                    Grade[i].total, Grade[i].average);
            }
            sw.Close();
        }
    }
}
