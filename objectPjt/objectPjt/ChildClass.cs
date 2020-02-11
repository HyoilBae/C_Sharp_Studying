using System;

namespace objectPjt
{
    public class ChildClass : ParentsClass
    {
        public ChildClass()
        {
            Console.WriteLine(" === ChildClass CONSTRUCTOR === ");
        }

        public override void makeJjajang()
        {
            //base.makeJjajang();
            Console.WriteLine(" === makeJjajang() of ChildClass START === ");
        }

        public new void makeJjamppong()
        {
            Console.WriteLine(" === Jjamppong() of ChildClass START === ");
        }
    }

}