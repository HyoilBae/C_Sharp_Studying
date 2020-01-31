using System;

namespace _10Memory00_Func_
{

    class Player
    {
        int HP = 100;
        int AT = 10;

        public void Damage(int _Dmg)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int Value = 0;

            Player NewPlayer = new Player();

            NewPlayer.Damage(10);
        }
    }
}
