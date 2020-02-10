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
    protected int MAXHP = 100;

    public void SetName(string _Name)
    {
        name = _Name;
    }

    public void StatusRender()
    {
        Console.WriteLine(name);
        Console.WriteLine("-----------------------------------");
        Console.Write("Attack : ");
        Console.WriteLine(AT);

        Console.Write("Health : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("-----------------------------------");
    }
}

class Player : FightUnit
{
    public void PrintHP()
    {
        Console.WriteLine(" ");
        Console.Write("Player's HP is ");
        Console.Write(HP);
        Console.ReadKey();
    }

    public void MaxHeal(/*Player this*/)
    {

        if (HP >= MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("You're fully recovered!");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
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

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("What do you want to do in this town?");
                Console.WriteLine("1. Taking a rest");
                Console.WriteLine("2. Upgrading Weapons");
                Console.WriteLine("3. Getting out of the twon");

                //ConsoleKey CK = Console.ReadKey().Key;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        _Player.PrintHP();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static void Battle(Player _Player)
        {
            //Console.WriteLine("Battle Field hasn't opened yet");
            //Console.ReadKey();
            Monster NewMonster = new Monster("Goblin");

            while (/*둘중 누군가 죽을때까지*/true)
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                //싸우게 만들어보세요. 한쪽의 HP가 0이 되면 된다.
                //1. 죽을때까지 싸우게 만들어라.
                //2. 한쪽이 죽으면 마을로 자동이송.
                Console.ReadKey();
            }
        }








        static void Main(string[] args)
        {
            Player NewPlayer = new Player();



            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(NewPlayer);
                        break;
                    case STARTSELECT.NONSELECT:
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
