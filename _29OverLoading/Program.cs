using System;

public enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG,
}
class Player
{
   

    int FireDef = 5;
    int WaterDef = 5;
    int PhyDef = 5;

    int HP = 100;

    public Player()
    {

    }

    public Player(int _HP)
    {
        HP = _HP;
    }


    //함수 오버로딩
    public void Damage(int _Damage)
    {

    }

    public void Damage(float _dddd, int _Type)
    {

    }
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                break;
            case DMGTYPE.FIREDMG:
                break;
            case DMGTYPE.ICEDMG:
                break;
            default:
                break;
        }
        
        Damage(_Damage);
    }

}


namespace _29OverLoading
{

    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);

            

            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
        }
    }

}

