using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        

        //Constructor
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
           
        }

        public void Add(string todo)
        {
            //if (Todos.Length < 5)
            //{
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            //}
            //else
            //{
            //    //Console.WriteLine("Too many Todo List");
            //}
        }

        public void Display()
        {
            
            
            foreach (string todo in Todos)
            {
                if (String.IsNullOrEmpty(todo))
                {
                    Console.WriteLine("[]");
                }
                Console.WriteLine(todo);
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
          
        }
    }
}
