using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zone
{
    public string Name = "None";

    public List<Zone> LinkZone = new List<Zone>();
}
class Node<T>
{

    //몇개가 되건 상관이 없다
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkedList<T>
{
    public Node<T> First;
        public Node<T> Last;
}

namespace LinkedStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> LList = new LinkedList<int>();

            /*노드들을 관리해주는 : LinkedList<int>;
             *                     LList.First
             *                    LList.Last
             *                    
             *노드사시아싱를 타고 다니느 클래스
             *                      LinkedListNode<int>
             *                      */

            LList.AddFirst(10);
            LList.AddFirst(20);
            LList.AddFirst(33);

            //LList.Remove(10);

            //LList.RemoveFirst();
            //LList.RemoveLast();

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;
            LList.AddAfter(Cur, 999);

            LList.Clear();

            for (LinkedListNode<int> StartNode = LList.First;
                null != StartNode; 
                StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }


            for (LinkedListNode<int> StartNode = LList.Last;
                null != StartNode;
                StartNode = StartNode.Previous)
            {
                Console.WriteLine(StartNode.Value);
            }

            // LinkedListNode<int> StartNode = LList.First;




        }
    }
}
