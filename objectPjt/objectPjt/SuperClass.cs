using System;

namespace objectPjt
{
    public class SuperClass
    {
        public int iNum = 10;
        private int jNum = 20;

        public static int kNum = 30; 

        public SuperClass()
        {
            Console.WriteLine(" === SuperClass CONSTRUCTOR === ");
        }

        public int GetJNum(string masterId)
        {
            if(masterId == "admin")
            {
                return jNum;
            }

            return 0;
        }
        public void doPublicMethod()
        {
            Console.WriteLine(" === doPublicMethod() START === ");
            //doPrivateMethod();
        }

        private void doPrivateMethod()
        {
            Console.WriteLine(" === doPrivateMethod() START === ");
        }

        public static void doStaticMethod()
        {
            Console.WriteLine(" === doStaticMethod() START === ");
        }
    }
}

