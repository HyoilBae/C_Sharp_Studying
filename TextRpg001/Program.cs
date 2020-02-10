using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int m_MAXHP = 100;

    public int MAXHP
    {
        set
        {
            m_MAXHP = value;
        }

        get
        {
            return m_MAXHP;
        }
    }

    public bool IsDeath()
    {
        //bool boolDeath = HP <= 0;
        return HP <= 0;
    }

    public void SetName(string _Name)
    {
        name = _Name;
    }

    public void StatusRender()
    {
        Console.WriteLine(name + "has abilities --------------");
        Console.WriteLine("Attack : " + AT.ToString());
        Console.WriteLine("Health : " + HP.ToString() + "/" + m_MAXHP.ToString());
        Console.WriteLine("-----------------------------------");
    }

    public void Damage(FightUnit _OtherUnit)
    {
        Console.Write(name);
        Console.Write(" ");
        Console.Write(_OtherUnit.AT);
        Console.Write(" ");
        Console.WriteLine("has been damaged");
        Console.ReadKey();
        HP -= _OtherUnit.AT;
    }
}

class Player : FightUnit
{

    private Inven PlayerInven = new Inven(5, 3);
    public Inven PInven
    {
        get
        {
            return PlayerInven;
        }
    }
        

    public void PrintHP()
    {
        Console.WriteLine("");
        Console.Write("Player's HP is ");
        Console.Write(HP);
        Console.ReadKey();
    }

    public void MaxHeal(/*Player this*/)
    {

        if (HP >= m_MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("You're fully recovered!");
            Console.ReadKey();
        }
        else
        {
            this.HP = m_MAXHP;
            PrintHP();
        }
        return;
    }
    public Player()
    {
        name = "Player";
    }



}



class Monster : FightUnit
{
    public Monster(string _Name)
    {
        name = _Name;
    }
}


//에러나 잘못된 선택에 관한것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONSELECT,
}

namespace TextRpg001
{
    class Program
    {
        //마을로 갈지 싸움터로 갈지 정해주는 함수
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("1. Town");
            Console.WriteLine("2. Battle");
            Console.WriteLine("Where do you want to go?");

            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Heading to Town.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("Heading to Battle");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("Wrong selection");
                    Console.ReadKey();
                    return STARTSELECT.NONSELECT;
            }
        }

        static void Shop(Player _Player, Inven _ShopInven)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Shopper's List");
                _ShopInven.Render();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Player's List");
                _Player.PInven.Render();
                Console.ReadKey();
            }
        }

        static STARTSELECT Town(Player _Player)
        {

            Inven ShopInven = new Inven(5, 3);

            ShopInven.ItemIn(new Item("Iron Sword", 500));
            ShopInven.ItemIn(new Item("Iron Shield", 500));

            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("What do you want to do in this town?");
                Console.WriteLine("1. Taking a rest");
                Console.WriteLine("2. Visiting Merchants");
                Console.WriteLine("3. Getting out of the twon");

                //ConsoleKey CK = Console.ReadKey().Key;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        _Player.PrintHP();
                        break;
                    case ConsoleKey.D2:
                        Shop(_Player, ShopInven);
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONSELECT;
                }
            }
        }

        static STARTSELECT Battle(Player _Player)
        {
            //Console.WriteLine("Battle Field hasn't opened yet");
            //Console.ReadKey();
            Monster NewMonster = new Monster("Goblin");

            while (/*둘중 누군가 죽을때까지*/false == NewMonster.IsDeath()
                && false == _Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();

                NewMonster.Damage(_Player);
                if (false == NewMonster.IsDeath())
                {
                    _Player.Damage(NewMonster); //업캐스팅
                }
                //Console.ReadKey();

                //싸우게 만들어보세요. 한쪽의 HP가 0이 되면 된다.
                //1. 죽을때까지 싸우게 만들어라.
                //1-1. 권장 플레이어 한대 몬스터 한대
                //2. 한쪽이 죽으면 (나간다) 마을로 자동이송.
                //2-1. 그냥 나간다.
                //2-2 마을로 나간다.
            }

            Console.WriteLine("The Fight is done");

            if (true == NewMonster.IsDeath())
            {
                Console.WriteLine("Player killed Monster");
            }
            else
            {
                Console.WriteLine("Player was killed by Monster");
            }
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
        }








        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //NewPlayer.MAXHP

            STARTSELECT SelectCheck = STARTSELECT.NONSELECT;

            while (true)
            {

                switch (SelectCheck)
                {
                    case STARTSELECT.NONSELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;

                    default:
                        break;
                }
            }


            //저는 마을과 싸움터로 나눠서 입장하게 하고 싶다면 조건문을 써야한다
            /* while (true)
             {
                 ConsoleKeyInfo KeyInfo = Console.ReadKey();
                 Console.WriteLine(KeyInfo.Key);
             }
             */

        }
    }
}
