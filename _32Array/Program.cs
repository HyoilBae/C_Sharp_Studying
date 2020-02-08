using System;

namespace _32Array
{
    class Program
    {

        class Item
        {
           public string Name;
           public int AT;
           public int DF;
        }
        static void Main(string[] args)
        {
            int[] ArrInt = new int[10];

            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrInt[i]);
            }


            //아이템이라는 메모리를 가리킬수 있는 리퍼런스형이 10개 생겼다.
            Item[] ArrItem = new Item[10];

            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
            }

            ArrItem[0].Name = "Sword";
            ArrItem[1].Name = "Shield";
            ArrItem[2].Name = "Legendary";
            ArrItem[3].Name = "Potion";

            for (int i = 0; i < ArrItem.Length; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }

            //Console.WriteLine(ArrInt[0]);
        }
    }
}
