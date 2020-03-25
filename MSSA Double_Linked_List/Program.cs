using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Double_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> myList = new LinkedList<int>();
            //myList.AddFirst(1);
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            //myList.AddFirst(4);
            //Console.WriteLine(string.Join(" ", myList));

            LinkedList2<int> myList2 = new LinkedList2<int>();
            myList2.AddFirst(1);
            myList2.AddFirst(2);
            myList2.AddFirst(3);
            myList2.AddFirst(4);
            Console.WriteLine(myList2);

            Stack<string> mystack = new Stack<string>();
            mystack.Push("Saint");
            mystack.Push("Martin");
            mystack.Push("2020");
            //Console.WriteLine(mystack.Pop());
            //Console.WriteLine(mystack.Pop());
            //Console.WriteLine(mystack.Pop());
            //Console.WriteLine(mystack.Pop());

            Console.WriteLine(mystack);

            //application for queues : reverse the contents of a file
            StreamReader inFile = new StreamReader("input.txt");
            Stack<string> myStack2 = new Stack<string>();

            string line = inFile.ReadLine();
            while (line != null)
            {
                myStack2.Push(line);
                line = inFile.ReadLine();
            }
            Console.WriteLine(myStack2);
            inFile.Close();

            StreamWriter outFile = new StreamWriter("output.txt");
            while (myStack2.Peek() != null)
            {
                outFile.WriteLine(myStack2.Pop());
            }
            outFile.Close();


            Queue myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());


            Stack<int> myStack4 = new Stack<int>();
            myStack4.Push(10);
            myStack4.Push(20);
            myStack4.Push(30);
            myStack4.Push(40);
            Console.WriteLine(myStack4.Pop());
            Console.WriteLine(myStack4.Pop());
            Console.WriteLine(myStack4.Pop());
            Console.WriteLine(myStack4.Pop());
        }

        class LinkedList2<T> : LinkedList<T>
        {
            public override string ToString()
            {
                string ret = "";
                //foreach (var value in this)
                //{
                //    ret += value + " ";
                //}
                ret = string.Join(",", this);
                return ret;
            }
        }

        class Stack<T>
        {
            //data
            LinkedList<T> allValues;
            public void Push(T newValue)
            {
                allValues.AddFirst(newValue);
            }

            public T Pop()
            {
                if (allValues.Count > 0)
                {

                T first = Peek();
                allValues.RemoveFirst();
                return first;
                }
                else
                {
                    throw new Exception("the stack is empty... you can't pop elements from it");
                }
            }

            public T Peek()
            {
                if (allValues.Count > 0)
                {
                    return allValues.First();
                }
                else
                {
                    Object result = null;
                    return (T)result;
                }
                
            }

            public Stack()
            {
                allValues = new LinkedList<T>();
            }

            public override string ToString()
            {
                string ret = "";
                foreach (var val in allValues)
                {
                    ret = ret + "\n" + val;
                }
                return ret;
            }

        }

        class Queue
        {
            LinkedList<int> allValues;

            public void Enqueue(int value)
            {
                allValues.AddFirst(value);
            }
            public int Dequeue()
            {
                int LastValue = Peek();
                allValues.RemoveLast();
                return LastValue;
            }
            public int Peek()
            {
                return allValues.Last();
            }

            public Queue()
            {
                allValues = new LinkedList<int>();
            }
        }
    }
}
