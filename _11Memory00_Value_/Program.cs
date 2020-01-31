using System;


class Player
{
    int AT;
    int HP;

    public int Test(int _Dmg)
    {
        //이 안에 지역변수 안에서 일어지는 일은 이 함수 안에서만 벌어지는 일//
        _Dmg = 1000;

        return _Dmg;
    }
}
namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Value = 0;
            Player NewPlayer = new Player();
            NewPlayer.Test(Value);


            //값형의 처리 이래야 테스트 클래스의 리턴 값을 받는다//
            Value = NewPlayer.Test(Value);

            Console.WriteLine(Value);

        }
    }
}
