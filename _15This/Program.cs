using System;


class Player
{
    private int HP = 100;

   public void Damage(int _Dmg)
    {
        // -= _Dmg;

        this.HP -= _Dmg;
    }

    public static void PVP(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;
    }

    public void Heal(/*player this,*/ int _Heal) //문법적으로 편의성을 주기 위해서 this를 쓴다
    {
        //멤버 함수에서 멤버 변수를 쓴다면 눈에 보이지는 않지만 앞에 this. 생략된 것이다.
        this.HP += _Heal;
    }

    //같은 정적 멤버변수만을 정적 멤버 함수에서 사용 할 수 있다
    private static int StTest = 100;
    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        //HP = 10000;
    }
}
namespace _15This
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Damage(100);

            NewPlayer2.Heal(100);

            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}
;