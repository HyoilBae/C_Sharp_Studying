using System;

class FightUnit
{
    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;


    //이 문법의 핵심은 자식에서 만약 나의 Methods 나 Property 를 재구현했다면
    //자식의 형태의 GetAT를 호출해 주세요.
    //오버라이딩

   public virtual int GetAT()
    {
        Console.WriteLine("FightUnit's GetAT");
        return AT;
    }


    public void Damage(FightUnit _OtherFightUnit)
    {
        //각자 플레이어의 것이 되어야한다
        int AT = _OtherFightUnit.GetAT();

        Console.WriteLine(AT + _OtherFightUnit.Name + "Damage");
        HP -= AT;
    }

}

class Player : FightUnit
{
    int ItemAt = 5;

    public override int GetAT()
    {
        Console.WriteLine("Player's GetAT");
        return AT + ItemAt;
    }

    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster's GetAT");
        return AT + MonsterLv;
    }
    public Monster(string _Name /*int _MonsterStartLv*/)
    {

      Name = _Name;
    }
}
namespace _30OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("Player");

            Monster NewMonster = new Monster("Monster");

            //NewPlayer.GetAT();

            NewMonster.Damage(NewPlayer);
            NewPlayer.Damage(NewMonster);

        }
    }
}
