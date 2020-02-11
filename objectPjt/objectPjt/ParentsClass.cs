using System;

namespace objectPjt
{
    public class ParentsClass
    {
        public ParentsClass()
        {
            Console.WriteLine(" === ParentsClass CONSTRUCTOR === ");
        }

        public virtual void makeJjajang()
        {
            Console.WriteLine(" === makeJjajang() of ParentsClass START === ");
        }

        public void makeJjamppong()
        {
            Console.WriteLine(" === Jjamppong() of ParentsClass START === ");
        }
    }
}

