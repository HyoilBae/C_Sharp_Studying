using System;

namespace _34BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                if (0 == i % 2)
                {
                    continue;
                    //만약 이 문장을 만나면 while 문에도 통한다
                    //반복문의 증감문으로 바로 이동한다
                }

                Console.WriteLine(i);

            }

            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
