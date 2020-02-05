using System;

class Player
{
    int AT = 10;

    public int HP = 20;

    static int m_StaticValue = 100;
    public static int StaticValue
    {
        get
        {
            return m_StaticValue;
        }

        set
        {
            m_StaticValue = value;
        }
    }

    //자료형을 선언했다면 이는 int와 관련된 함수라고 명시하는것
    public int ProAT
    {

        //프로퍼티의 get 함수는 무조건 int 를 리턴한다고 보고
        get
        {
            if (999 < AT)
            {
                Console.WriteLine("Maximum Attack Level has reached");
                while (true)
                {
                    Console.ReadKey();
                }
            }
            return AT;
        }

        //무조건 int 하나가 들어온다고 생각한다.
        //그런 외부 값들을 프로퍼티에서는 Value라고 기호로 정희해 놨다.
        set
        {
            AT = value;
        }
    }

    public int GetAT()
    {
        if (999 < AT)
        {
            Console.WriteLine("Maximum Attack Level has reached");
            while (true)
            {
                Console.ReadKey();
            }
        }
        return AT;
    }

   public void SetAT(int _Value)
    {
        if (999 < _Value)
        {
            Console.WriteLine("Maximum Attack Level has reached");
            //while (true) { Console.ReadKey(); }
            
        }
        AT = _Value;
    }
}



namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Player.StaticValue = 200;

            NewPlayer.HP = 80;

            NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;

            //NewPlayer.SetAT(99999999);

        }
    }
}
