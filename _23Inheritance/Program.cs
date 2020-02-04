using System;


class FightUnit
{
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(FightUnit _OtherUnit)
    {

    }
}
class Player : FightUnit    //C#에서는 오직 단하나의 클래스만 상속 받을 수 있다
{
    int Lv = 1;

    void Heal()
    {
        HP = 100; 
    }
}

class Monster : FightUnit
{
   
}
namespace _23Inheritance
    //상속이란 코드 재활용성을 향상시키기 위해서 똑같은 코드를 2번씩 치기 싫기 때문에...
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();
            //NewPlayer.Damage(10);
            //FightUnit FU = NewPlayer;
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
            
        }
    }
}
