using System;

class Node<T>
{
    public T Data;

    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}


namespace _38_2_DataStructure_Nod
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Node1 = new Node<int>(10);
            Node<int> Node2 = new Node<int>(999);
            Node<int> Node3 = new Node<int>(578);

            Node1.Next = Node2;
            Node2.Next = Node3;

            Node3.Prev = Node2;
            Node2.Prev = Node1;

            Node<int> CurNode = Node1;

            while (CurNode != null)
            {
                Console.WriteLine(CurNode.Data);
                CurNode = CurNode.Next;
            }

            Node<int> RCurNode = Node3;

            while (RCurNode != null)
            {
                Console.WriteLine(RCurNode.Data);
                RCurNode = RCurNode.Prev;
            }

        }   
    }
}
