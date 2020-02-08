using System;

interface QuestUnit
{
    // int A = 0; 멤버 변수 할 수 없다

    //함수의 형태만 물려 줄수 있는 문법이다
    void Talk(QuestUnit questUnit);
}

interface QuestUnit2
{
    // int A = 0; 멤버 변수 할 수 없다

    //함수의 형태만 물려 줄수 있는 문법이다
    void Talk(QuestUnit questUnit);
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}

class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit
{


}

class NPC : FightUnit, QuestUnit
{

    public void Talk(QuestUnit _OtherUnit)
    {

    }

}


namespace _31InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NPC NewNPC = new NPC();


            QuestUnit NewQuestUnit = NewNPC;

            //업캐스팅이 된다
            NewPlayer.Talk(NewNPC);
        }
    }
}
