using System;

namespace objectPjt
{
    class ObjectEx
    {
        static void Main(string[] args)
        {
            // 상속(Inheritance)
            Child child = new Child();

            Console.WriteLine();

            Console.WriteLine($"child.strOfChild : {child.strOfChild}");
            Console.WriteLine($"child.strOfParents : {child.strOfParents}");

            Console.WriteLine();

            child.methodOfChild();
            child.methodOfParents();

            Console.WriteLine();

            // 오버라이딩(Overriding)
            ChildClass childClass = new ChildClass();
            childClass.makeJjajang();

            ParentsClass parentsClass = childClass;
            parentsClass.makeJjajang();

            Console.WriteLine();

            // Method hiding
            childClass.makeJjamppong();
            parentsClass.makeJjamppong();

            // private, static
            SubClass subClass = new SubClass();
            Console.WriteLine($"subClass.iNum : {subClass.iNum}");
            //Console.WriteLine($"subClass.jNum : {subClass.jNum}");
            Console.WriteLine($"subClass.GetJNum() : {subClass.GetJNum("admin")}");
            Console.WriteLine($"subClass.GetJNum() : {subClass.GetJNum("ad")}");
            //Console.WriteLine($"subClass.kNum : {subClass.kNum}");
            Console.WriteLine($"SuperClass.kNum : {SuperClass.kNum}");

            subClass.doPublicMethod();
            //subClass.doPrivateMethod();
            //subClass.doStaticMethod();
            SuperClass.doStaticMethod();

        }
    }

    class Parents
    {
        public string strOfParents = "strOfParents";
        public int intOfParents = 100;

        public Parents()
        {
            Console.WriteLine(" === Parents Class CONSTRUCTOR === ");
        }

        public void methodOfParents()
        {
            Console.WriteLine(" === methodOfParents START === ");
        }
    }

    class Child : Parents
    {
        public string strOfChild = "strOfChild";
        public int intOfChild = 200;

        public Child()
        {
            Console.WriteLine(" === Child Class CONSTRUCTOR === ");
        }

        public void methodOfChild()
        {
            Console.WriteLine(" === methodOfChild START === ");
        }
    }
}
