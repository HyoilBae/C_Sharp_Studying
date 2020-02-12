using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.RemoveAt(0);

            list.Insert(0, 2.3f);
            list.Add("ABC");
            list.Add("DEF");

            //컬렉션의 모든 요소는 object 타입으로 저장된다.
            Console.WriteLine("------------ArrayList-------------");
            foreach (object obj in list)
            {
                
                Console.WriteLine("{0} ", obj);
                Console.WriteLine();
            }

            
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Dequeue();
            que.Enqueue(4.4);
            que.Dequeue();
            que.Enqueue("ABC");
            Console.WriteLine("--------------Queue--------------");
            while (que.Count > 0)
            {
                
                Console.WriteLine(que.Dequeue());
                Console.WriteLine();
            }
            Console.WriteLine();



            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            stack.Pop();
            stack.Push(4.4);
            stack.Push("ABC");
            Console.WriteLine("------------stack------------");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine();



            Hashtable ht = new Hashtable();
            ht["Apple"] = "사과";
            ht["Banana"] = "바나나";
            ht["Orange"] = "오렌지";

            Console.WriteLine("------------Hashtable------------");
            Console.WriteLine(ht["Apple"]);
            Console.WriteLine(ht["Banana"]);
            Console.WriteLine(ht["Orange"]);
        }
    }
}
