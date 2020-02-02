using System;

/* 
 * 코드: 상수, 클래스 선언 그 자체 함수의 내용 그 자체 수정이 불가능한 녀석들.
 * 
 * 데이터: 정적 멤버 변수
 * 
 * 힙 : new 클래스명() 만들어진 클래스 객체들의 본체가 여기있다.
 * 
 * 스택 : 함수이 실행 메모리 영역 (그 박스 안에 들어있는 지역변수) 지역변수 레퍼런스들은 힙영역에 있는 위치를 가르킬뿐
 */


class Monster
{
    static int MonsterDeathCount; //이렇게 지정해주면 몬스터가 카운터 될때마다 업데이트 되어서 카운트에 증가//

    public void Death()
    {
        MonsterDeathCount += 1; //이렇게 하면 각자의 객체가 스택에만 저장되어 1만 저장되고 없어진다
    }
}

class Player
{
    //데이터 영역에 들어가게 된다 이 정적 멤버변수는//
    public static int PlayerCount = 0;             //정적 멤버변수는 일반적인 멤버변수와는 다르게 객체화를 하지 않고도 쓸 수 있다//

    public int AT = 10;
    public int HP = 100;

    public void Setting(int _AT, int _HP)
    {
        PlayerCount = 100;

        AT = _AT;
        HP = _HP;
    }
}
namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;  //이런 식으로 정적 멤버변수는 객체화를 하지 않고도 쓸 수 있다//
            //이런 정적 멤버 변수는 데이터 영역에 들어가게 된다//

            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            //모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다//
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}
