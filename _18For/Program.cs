using System;

namespace _18For
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 하고 for 는 함수 안에서만 쓸 수 있다

            
            //for (초기화문; 조건문; 증감문) for 문의 장점은 접근성
            //{
                //실행코드
            //}

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            //이렇게 쓰면 While 이 된다
            for (; true;)
            {
                Console.WriteLine(100);
            }
        }
    }
}
