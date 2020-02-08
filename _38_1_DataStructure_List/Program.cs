using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{

}

class MyList<T>
{
    public int[] Arr = new int[0];
    public int Capa = 0;
    public int Count = 0;

    public void Add(T _Add)
    {
        if (Count + 1 >= Capa)
        {

        }
    }
}


namespace _38_1_DataStructure_List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> NewInt = new MyList<int>();

            NewInt.Add(100);

            NewList.Remove();


            //List<Item> NewList = new List<Item>();
            //NewList.Add(1000);

            List<int> NewList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + "Add");
                Console.WriteLine("Capa" + NewList.Capacity.ToString()); //배열의 크기
                Console.WriteLine("Capa" + NewList.Count.ToString()); //자료의 크기
                NewList.Add(i);
            }

            //내부에 자료가 있는지 없는지 확인하다.
            if (NewList.Contains(8))
            {

            }

            Console.WriteLine(NewList[5]);
        }
    }
}
