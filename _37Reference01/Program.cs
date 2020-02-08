using System;

class Player
{
    public int HP = 100;
    public int AT = 10;

    public bool IsDeath()
    {
        Console.WriteLine("this method is showing if Player is dead or not");
        return HP <= 0;
    }

    public void TestFunc(Player _player)
    {
        TestFuncPart1(_player);
    }
    public void TestFuncPart1(Player _player)
    {
        TestFuncPart2(_player);
    }
    public void TestFuncPart2(Player _player)
    {
        TestFuncPart3(_player);
    }

    public void TestFuncPart3(Player _player)
    {
        _player.AT = 20;
    }
}

namespace _37Reference01
{

  
    class Program
    {
        static int Number = 100;


        static void ArrTest(int[] _ArrTest)
        {
            //_Test.AT = 10000;
            _ArrTest[0] = 99999;
        }

        static void ClassTest(Player _Test)
        {
            _Test.AT = 10000;
        }

        static void AtTest(Player _Test)
        {
            Console.WriteLine("Testing At Damage");

            _Test.AT = 10000;
        }
        static void Main(string[] args)
        {

            //Player NewPlayer 이 변수는 할수 있는 일이 어떤 녀석을 가르키는 일밖에 하지 못한다.
            //또다른 이미로 이것은 다른 녀석을 가리킬 수 있다.
            Player NewPlayer = new Player();
            NewPlayer.AT = 50;

            NewPlayer.TestFunc(null);

            Player NewPlayer2 = NewPlayer;
            NewPlayer2.AT = 999;    //---------->NewPlayer will be changed as well
            //NewPlayer = new Player(); ------> AT = 10;
            ClassTest(NewPlayer);


            //배열 또한 레퍼런스형
            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrTest(ArrNumber);

            //PlayerTest(NewPlayer);


            //AtTest(null);

            Player NewPlayer3 = null;

            NewPlayer3.IsDeath();
        }
    }
}

