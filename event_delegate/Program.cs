using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_delegate
{
    delegate void MyDelegate(int a);

    class EventManager
    {
        public event MyDelegate eventCall;

        public void NumberCheck(int num)
        {
            if (num%2 == 0)
            {
                eventCall(num);
            }
        }
    }
    class Program
    {
        static void EvenNumber (int num)
        {
            Console.WriteLine("{0} is even number", num);
        }
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.eventCall += new MyDelegate(EvenNumber);

            for (int i = 0; i < 10; i++)
            {
                eventManager.NumberCheck(i);
            }

        }
    }
}
