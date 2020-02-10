using System;

namespace objectPjt
{
    class ObjectEx
    {
        static void Main(string[] args)
        {
            // 클래스
            Grandeur myGrandeur = new Grandeur();
            Console.WriteLine($"grandeur.Color : {myGrandeur.Color}");
            Console.WriteLine($"grandeur.Price : {myGrandeur.Price}");
            myGrandeur.Drive();

            Grandeur friendGrandeur = new Grandeur();
            Console.WriteLine($"grandeur.Color : {friendGrandeur.Color}");
            Console.WriteLine($"grandeur.Price : {friendGrandeur.Price}");
            friendGrandeur.Drive();

            Robot myRobot = new Robot();
            myRobot.Work();
            myRobot.GetInfoRobot();

            Robot friendRobot = new Robot("Terminator", "Black", 100000000);
            friendRobot.Work();
            friendRobot.GetInfoRobot();

            // 겍체 복사
            CopyObject myCopyObject;
            CopyObject friendCopyObject;

            myCopyObject = new CopyObject();
            myCopyObject.SetProperty("Mr. Kim", 20, "M");

            friendCopyObject = new CopyObject();
            friendCopyObject.SetProperty("Mr. Lee", 40, "W");

            myCopyObject.GetInfor();
            friendCopyObject.GetInfor();

            if (myCopyObject == friendCopyObject)
            {
                Console.WriteLine("myCopyObject == friendCopyObject");
            }
            else
            {
                Console.WriteLine("myCopyObject != friendCopyObject");
            }

            friendCopyObject = myCopyObject;

            myCopyObject.GetInfor();
            friendCopyObject.GetInfor();

            if (myCopyObject == friendCopyObject)
            {
                Console.WriteLine("myCopyObject == friendCopyObject");
            }
            else
            {
                Console.WriteLine("myCopyObject != friendCopyObject");
            }
        }
    }

    class Grandeur
    {
        public string Color;
        public string Price;

        public Grandeur()
        {
            Console.WriteLine(" === CONSTRUCTOR === ");
            Color = "RED";
            Price = "30,000,000";
        }

        public void Drive()
        {
            Console.WriteLine(" === Drive() START === ");
            Console.WriteLine("Go Go sing~~~");
        }
    }

    class Robot
    {
        public string Name;
        public string Color;
        public int Price;

        public Robot()
        {
            Console.WriteLine(" === DEFAULT CONSTRUCTOR === ");
        }

        public Robot(string Name, string Color, int Price)
        {
            Console.WriteLine(" === CONSTRUCTOR === ");
            this.Name = Name;
            this.Color = Color;
            this.Price = Price;
        }

        public void Work()
        {
            Console.WriteLine(" === Work() START === ");
        }

        public void GetInfoRobot()
        {
            Console.WriteLine(" === GetInfoRobot() START === ");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Price : {Price}");
        }
    }

    class CopyObject
    {
        public string Name;
        public int Age;
        public string Gender;

        public void SetProperty(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public void GetInfor()
        {
            Console.WriteLine(" === GetInfor() START === ");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
}