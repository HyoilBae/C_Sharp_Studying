using System;


class Player
{
    public int ATT;
    public int HP;
    

    public void Fight()
    {
        Console.WriteLine("player is fighting");
    }
}
namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer = new Player();

            NewPlayer.ATT = 1000;
            NewPlayer.Fight();


            Console.WriteLine("Hello World!");
        }
    }
}
