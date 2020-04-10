using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC440_Generics
{
    class Program
    {
        static IEnumerable Method()
        {
            int[] arr = { 1, 2, 5, 6, 7, 8, 2020, 212 };
            foreach (var x in arr)
            {
                yield return x;
            }
        }

        static void Main(string[] args)
        {
            foreach (var num in Method())
            {
                Console.WriteLine(num);
            }



            int[] nums = { 2, 4, 6, 7, 8, 10 }; //you can use for each to show the elements

            //But what is you have various variable types?

            Course CSC440 = new Course();
            CSC440.CourseName = "Intermediate C#";
            CSC440.AddStudent(new Student() { Name = "Alice", Major = "MSSA", GPA = 4.0 });
            CSC440.AddStudent(new Student() { Name = "Bucky", Major = "Chemistry", GPA = 3.0 });
            CSC440.AddStudent(new Student() { Name = "Bob", Major = "ComputerScience", GPA = 2.5 });
            CSC440.AddStudent(new Student() { Name = "Sammy", Major = "Geology", GPA = 3.1 });
            CSC440.AddStudent(new Student() { Name = "Tom", Major = "Mathmatics", GPA = 3.7 });

            foreach (Student student in CSC440.roster)
            {
            }
            foreach (Student student in CSC440)
            {
                Console.WriteLine(student.Name);
            }
            foreach (Student student in CSC440.GetBackEnumerator())
            {
                Console.WriteLine(student.Name);
            }


        }

        public class Student
        {
            public string Name { get; set; }
            public string Major { get; set; }
            public double GPA { get; set; }
        }
        public class Course : IEnumerable
        {
            public string CourseName { get; set; }
            public List<Student> roster;

            public void AddStudent(Student st)
            {
                roster.Add(st);
            }

            public IEnumerator GetEnumerator()
            {
                foreach (var st in roster)
                    yield return st;
            }

            public IEnumerable GetBackEnumerator()
            {
                for (int i = roster.Count - 1; i >= 0; i--)
                    yield return roster[i];
            }

            public Course()
            {
                roster = new List<Student>();
            }
        }

        public class MyList<T> : List<T>
        {

        }
        public class MyList : List<int>
        {

        }
    }
}
