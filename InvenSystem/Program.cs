using System;

class Program
{
    static void Main(string[] args)
    {
        Inven NewInven = new Inven(5, 3);

        Item NewItem = new Item("IronSword", 100);


        //뭐가 있어야 겠다
        //클래스 속성들이 있다
        //아이템 배열을 멤버변수로 가졌다
        //인벤에 아이템을 넣는다

        NewInven.ItemIn(new Item("IronSword", 100));
        NewInven.ItemIn(new Item("IronShield", 100));

        NewInven.ItemIn(new Item("Potion", 100), 6);
       


        while (true)
        {
            Console.Clear();

            NewInven.Render();

            ConsoleKeyInfo CheckKey = Console.ReadKey();

            switch (CheckKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    NewInven.SelectMoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.SelectMoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    NewInven.SelectMoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    NewInven.SelectMoveDown();
                    break;

                default:
                    break;
            }
        }
    }
}

