using System;

class Monster
{
    public int AT = 10;
    public int HP = 100;

    public void ATT(Player _Player)
    {
        _Player.HP -= AT;
    }
}
    class Player
{
    public int AT = 10;
    public int HP = 100;

    public void ATT(Monster _Monster) 
    {
        _Monster.HP -= AT; //몬스터의 체력은 플레이어의 공격력으로 마이너스 시키겠다//
    }
}
namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster NewMonster = new Monster(); //객체화가 된다//
            Player NewPlayer = new Player(); //자기가 만든 클ㄹ래스를 뉴 클래스명() 해서 만든것은 그 클래스명에 받으면 레퍼런스형

            NewMonster.ATT(NewPlayer); //리퍼런스 값은 클래스의 위치는 가르켜서 그 값으 쓰는 것//
            NewPlayer.ATT(NewMonster);
        }
    }
}
