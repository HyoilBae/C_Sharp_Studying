using System;
using System.Collections.Generic;
using System.Text;


//인벤토리는 만드는 순간 [생성자], 인벤토리가 최대 몇개를 담을 수 있는 지부터 정해야한다
//숫자가 두개 필요한데 X와 Y다. 담을 수 있는 아이템의 총 개수는? X*Y

class Inven
{
    int SelectIndex;

    Item[] ArrItem;
    int ItemX;


    //인벤토리를 new 하려면 int X 와 int Y를 넣어주는 방법밖에 없게 만들었다.
    public Inven(int _X, int _Y)
    {
        if (1 > _X)
        {
            _X = 1;
        }

        if (1 > _Y)
        {
            _Y = 1;
        }

        ItemX = _X;
        ArrItem = new Item[(_X * _Y)];
    }


    //객체의 교류
    //인벤은 아이템이 필요해요 인자값은?
    public void ItemIn(Item _Item)
    {
        int Index = 0;

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                Index = i;
                break;
            }

        }

        ArrItem[Index] = _Item;

    }

    public void ItemIn(Item _Item, int _Order)
    {
        if (null != ArrItem[_Order])
        {
            //System.IndexOutOfRsangeException 방어코드 만들어 보세요

            return;
        }

        ArrItem[_Order] = _Item;
    }
    
   

    //셀렑트 인덱스가 화면 바깥으로 넘어갔는가?
    public bool OverCheck(int _SelectIndex)
    {
        return false;
    }


    //인자값으로 어느 방향으로 움직였는지 줘야한다
    public void SelecMove()
    {

    }

    public void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;

        if (true == OverCheck(SelectIndex))
        {
            return;
        }

        SelectIndex -= 1;
    }

    public void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;

        if (true == OverCheck(SelectIndex))
        {
            return;
        }

        SelectIndex += 1;
    }

    public void SelectMoveUp()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= ItemX;

        if (true == OverCheck(SelectIndex))
        {
            return;
        }

        SelectIndex -= ItemX;

    }

    public void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += ItemX;


        if (true == OverCheck(SelectIndex))
        {
            return;
        }

        SelectIndex += ItemX;

    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (0 != i && 0 == i % ItemX)
            {
                Console.WriteLine("");
            }


            //아이템을 가질 수 있는 인벤, i 번째에 아이템이 있니?
            if (SelectIndex == i)
            {
                Console.Write("*");
            }
            else if (null == ArrItem[i])
            {
                Console.Write("O");
            }
            else
            {
                Console.Write("X");
            }
        }

        Console.WriteLine("");

        if (null != ArrItem[SelectIndex])
        {

            Console.WriteLine("Currently this item is selected");
            Console.WriteLine("ItemName : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("ItemPrice : " + ArrItem[SelectIndex].Gold);
        } else
        {
            Console.WriteLine("Currently this item is Selected");
            Console.WriteLine("Nothing");
        }


    }
}
