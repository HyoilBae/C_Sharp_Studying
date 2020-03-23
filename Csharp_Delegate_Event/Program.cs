using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Delegate_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleCalculator circleCalculator = new CircleCalculator();

            CircleDelegate circleDelegate = new CircleDelegate(circleCalculator.GetArea);
            double circleArea = circleDelegate(10);
            Console.WriteLine($"circleArea : {circleArea}");

            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("2019-000001", new Student("2019-000001", 80));
            students.Add("2019-000002", new Student("2019-000002", 90));
            students.Add("2019-000003", new Student("2019-000003", 75));
            students.Add("2019-000004", new Student("2019-000004", 69));
            students.Add("2019-000005", new Student("2019-000005", 91));

            Score score = new Score(80);
            ScoreCompare scoreCompare = new ScoreCompare(score.PassStudent);
            score.GetRequiedScore(students, scoreCompare);

            score.PASS_SCORE = 70;
            scoreCompare = new ScoreCompare(score.PassStudent);
            score.GetRequiedScore(students, scoreCompare);

            scoreCompare = new ScoreCompare(score.FailStudent);
            score.GetRequiedScore(students, scoreCompare);


        }
    }
}
