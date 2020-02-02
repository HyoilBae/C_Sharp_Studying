using System;

struct StrucData
{
    //클래스와 비슷한데 안되는 것이 있다. 리터럴 초기화가 되지 않는다
    // = 0 이 기본이기 때문에
   public int a;
   public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}


namespace _12Struct_Enum
{
    class Program
    {
        static void Test(StrucData _Data)
        {
            _Data.a = 1000;
        }

        static void TestNumber(int _Number)
        {
            _Number = 1000;
        }

        static void Main(string[] args)
        {
            int Number = 100; //지역변수 메인 함수 안에서만 존재하기때문에 다른 함수에서는 쓸 수가 없다. 값형.

            StrucData NewData = new StrucData();

            NewData.a = 10;
            NewData.b = 10;

            Test(NewData); //클래스처럼 생겼고 레퍼런스형 같지만 값형이다. 그래서 값이 바뀌지 않는다

            int TestNewNumber = 100;

            TestNumber(TestNewNumber);
        }
    }
}
