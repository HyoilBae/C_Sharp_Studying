using System;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {

    }
}

class Player :FightUnit
{

    //생성자라고 합니다.
    //리턴값이 없어요. 만들어 질때 한번 실행되어지는 함수

    //눈에 보이지 않지만 만들지 않아도 이 함수는 만들어진다
    //무조건 신의 클래스의 메모리를 리턴해주는 함수이다.
    //리턴값은 없어도 접근 제한 지정자는 있다.
    public Player()
    {
        AT = 100;

    }
}
namespace _24ClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
        }
    }
}
