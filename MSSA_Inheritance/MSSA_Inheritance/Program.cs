using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

namespace MyNamespace
{
    public static class MyStaticClass
    {
        public static void MyMSSAMethod(this string s) //extension method
        {
            Console.WriteLine("MSSA called \"from\" MyMSSAMethod");
        }
    }
}

namespace MSSA_Inheritance
{
    class Program
    {
        private static List<int> myList;

        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.UserName = "userAlice";

            //User u1 = new User(); 
            User u2 = new Student();
            u2.UserName = "userBob";

            User myUser = new Administrator();
            //Administrator myUser = new User(); // does not compile
            //myUser.Department = "MSSA"; //does not compile
            ((Administrator)myUser).Department = "MSSA";
            myUser.MyMethod();

            List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            MyIntListClass myList2 = new MyIntListClass();
            myList2.Add(2);

            MyGenericListClass<int> myList3 = new MyGenericListClass<int>();
            myList3.Add(3);

            MyGenericListClass<Administrator> mylist4 = new MyGenericListClass<Administrator>();
            mylist4.Add(new Administrator("MSSA", "newUser", "passWord"));

            MyOwnList<int> myList5 = new MyOwnList<int>();
            myList5.Add(2020);

            //MyString myString = null;
            //myString.MyMethod();

            string str = "MSSA";
            str.MyMSSAMethod(); //extension method


            
        }
    }

    class MyString : List<int> //String //String is sealed
    {
        public void MyMethod()
        {

        }
    }

    class MyGenericListClass<T>: List<T>
    {

    }

    class MyIntListClass : List<int>
    {

    }

    class MyOwnList<T> : List<T>
    {
        public string MyProperty { get; set; }

        public void MyMethod()
        {
            throw new NotImplementedException("MyMethod is not implemented yet");
        }
    }

    class MyExceptionClass : Exception
    {
        public MyExceptionClass()
        {

        }

        public MyExceptionClass(string message) : base(message)
        {

        }

        public MyExceptionClass(string message, Exception inner) : base(message, inner)
        {

        }
    }

    abstract class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        protected int MyProtectedProperty { get; set; }
        private int  MyPrivateProperty { get; set; }

        public abstract void MyMethod();

        public virtual void HelloWorld()
        {
            Console.WriteLine("Hello from User Class");
        }

        public User()
        {

        }

        public User(string newUser, string newPass)
        {
            UserName = newUser;
            PassWord = newPass;
        }
    }

    class Administrator : User
    {
        public string Department { get; set; }

        public override void MyMethod()
        {
            MyProtectedProperty = 17;
            Console.WriteLine("Hello from Admin Class");
        }

        public override void HelloWorld()
        {
            base.HelloWorld();
        }

        public Administrator()
        {

        }

        public Administrator(string newDept, string newUser, string newPass) : base(newUser, newPass)
        {
            //UserName = newUser;
            //PassWord = newPass;
            Department = newDept;
        }
    }

    class Student : User
    {
        public string Major { get; set; }
        
        public override void MyMethod()
        {
            Console.WriteLine("Hello from Student class");
        }
    }
}
