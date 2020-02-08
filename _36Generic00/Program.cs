using System;

//정적 변수와 정적 함수만을 내부에 가질수 있고 생성자를 내부에 만들수가 없다
public static class GTest
{

    //Generic 문법
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);

        return _Value;
    }

    public static T ConsolePrint<T, U>(T _Value, U _Value2)
    {
        Console.WriteLine(_Value);
        Console.WriteLine(_Value2);

        return _Value;
    }

    class Inven<T>
    {
        T[] ArrInvenItem;

        public void ItemIn(T _Item)
        {

        }
    }

    public static void ConsolePrint(string _Text)
    {
        Console.WriteLine(_Text);
    }
}
    class Program
    {
        static void Main(string[] args)
        {

        float Value = 1.1323232323f;
        GTest.ConsolePrint(Value);

        GTest.ConsolePrint("lolololololol");

        GTest.ConsolePrint(13232313232);

        GTest.ConsolePrint("zzzzzzzzzzzz", "kkkkkkkkkk");

        //Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        //GameItem NewItem = new GameItem();
        //NewGameItemInven.ItemIn(NewGameItem)

        //Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        //CashItem NewItem = new CashItem();
        //NewCashItemInven.ItemIn(NewCashItem);
    }
}
