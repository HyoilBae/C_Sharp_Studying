using System;

class Player
{

    //멤버 변수 클래스 안에 있음//
    int Att;
    int HP;

    void Fight()
    {
        Console.WriteLine("Player is Fighting");
    }
}
namespace _06LocalVar
{
    class Program
    {
        static void Main(string[] args)
        {
            //지역변수 함수안에 있음//
            //지역변수 규칙 함수 내부에서만 사용한다//
            //지역변수는 메모리화 되고 실행되는 순간 사라진다//
            int ATT = 0;
            ATT = 50;

            Player NewPlayer = new Player();

            //Console.WriteLine("Hello World!");//
        }
    }
}
