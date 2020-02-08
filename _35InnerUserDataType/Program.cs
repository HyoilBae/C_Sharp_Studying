using System;


class Player
{
    //그 클래스가 자기만 사용할때 Inner enum
   public enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE,
    }

    PLAYERJOB Job = PLAYERJOB.NOVICE;

    void ClassChange()
    {

    }
}
class Inven
{
    private int SelectIndex = 0;

    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();
        NewInvenSlot.Select(this);
    }

    public class InvenSlot
    {
        int index;
        public void Select(Inven _inven)
        {
            //자신을 가지고 클래스의  멤버변수를 마치public 처럼 쓸 수 있다
            _inven.SelectIndex = 100;
        }

    }

    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN,
    }
    void SelectMove()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();


        Inven NewInven = new Inven();

        NewInven.InnerClassTest();

        Inven.INVENDIR IDIR = Inven.INVENDIR.ID_LEFT;


    }
}

