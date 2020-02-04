using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자 정의자료형중 하나
//class 참조형 사용자 정의  
//struct 값형 사용자 정의
//enum 값형 사용자 정의

    enum ITEMTYPE
{
    Equip,
    Potion,
    Quest,
    NoneSelect
}

class Item
{
    public ITEMTYPE ItemType = ITEMTYPE.NoneSelect;

    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.Potion;
    }
}

namespace _22Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.Potion;

            Console.WriteLine(ITEMTYPE.Potion);

            ITEMTYPE Type = ITEMTYPE.Potion;

            switch (Type)
            {
                case ITEMTYPE.Equip:
                    break;
                case ITEMTYPE.Potion:
                    break;
                case ITEMTYPE.Quest:
                    break;
                case ITEMTYPE.NoneSelect:
                    break;
                default:
                    break;
            }
        }
    }
}
