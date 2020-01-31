using System;


class Player
{
    private int LV = 1;
    private int AT = 10;
    private int HP = 100;


    public int GetLv()
    {

        LV = 10000;
        return LV;
    }
    public void LVUP()
    {
        HP = 1000;
        AT = 100;
    }

    public void SetHP(int _HP)
    {
        HP = _HP;
    }

    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    //return 값은 자신이 리턴해주려는 자료형과 동일한 자료형 이어야 한다//
    public int DamageToHPReturn(int _Dmg, int _Dmg1, int _Dmg3)
    {
        HP = HP - _Dmg;
        return HP;
    }
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
}
namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();

            NewPlayer.SetHP(1000);
            NewPlayer.LVUP();

            NewPlayer.Damage1(10);
            NewPlayer.Damage1(20);
            NewPlayer.Damage2(10, 20);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(50, 20, 30));
            
            Console.WriteLine("Hello World!");
        }
    }
}
