using System;

namespace _19If
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test = 100;
            if (Test == 100)
            {
                Console.WriteLine("The Answer is 100");
            }

            int ElseIfTest = 10;
            if (ElseIfTest == 100)
            {
                Console.WriteLine("The Answer is not 100");
            }
            else if (ElseIfTest == 10)
            {
                Console.WriteLine("The Answer is 10");
            }

            int ElseTest = 5;
            if (ElseTest == 10)
            {
                Console.WriteLine("ElseTest는 10이 아닙니다");
            }
            else if (ElseTest == 100)
            {
                Console.WriteLine("ElseTest 는 100이 아닙니다");

            }
            else
            {
                Console.WriteLine("ElseTest 는 5입니다");
            }
        }
    }
}
