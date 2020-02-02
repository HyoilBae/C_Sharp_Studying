using System;


public class Player
{

    //접근 제한 지정자 라도 같은 플레이어 라는 클래스에 있기 때문에 객체화를 하지 않아도 접근 제한 지정자의 영향을 받지 않는다//
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    private int AT = 100;
    private int HP = 100;
    public void Damage(int _Dmg)
    {

        HP -= 100;
    }
}

public class Monster
{

}


namespace _14StaticFunc
{
    class Program
    {

        //어떤 클래스에 존재하는 Main의 이름을 가진 정적 멤버함수로부터 C# 프로그램은 시작한다//
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Static Methods");

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            //마찬가지로 그 클래스 속하지만 객체를 굳이 만들지 않고도 사용 할 수 있는 함수를 정적멤버 함수라고 한다//
            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer1.Damage(100);


        }
    }
}
