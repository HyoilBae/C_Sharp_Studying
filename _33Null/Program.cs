using System;

class Player
{
    private int mAT;

    public int AT
    {
        get { return mAT; }
        set { mAT = value; }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

        //가르키는게 없이 비워놓겠다
        //참조형의 데이터 구조를 가리키는 자료형 클래스는 new 하게 되면
            Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer2.AT);

        //what's "NullREferenceException?
        Console.WriteLine(NewPlayer.AT);

    }
}
