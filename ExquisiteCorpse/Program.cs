using System;

namespace ExquisiteCorpse
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to build your own ghost or a random one?");
            Console.WriteLine("YES : You create your monster, N0: randomly selected");
            string yourChoice = (Console.ReadLine()).ToUpper();
            switch (yourChoice)
            {
                case "YES":
                    Console.WriteLine("Choose a head, a body, and a feet from Ghost, Bug, Monster");
                    Console.WriteLine("First, Choose a head from 'ghost', 'monster', and 'bug': ");
                    string headChoice = (Console.ReadLine()).ToLower();
                    Console.WriteLine("Second, Choose a body from 'ghost', 'monster', and 'bug': ");
                    string bodyChoice = (Console.ReadLine()).ToLower();
                    Console.WriteLine("Last, Choose a feet from 'ghost', 'monster', and 'bug': ");
                    string feetChoice = (Console.ReadLine()).ToLower();

                    Console.WriteLine("This is your creature: ");
                    BuildACreature(headChoice, bodyChoice, feetChoice);
                    break;
                case "NO":
                    Console.WriteLine("This is a random creature");
                    RandomMode();
                    break;
                default:
                    Console.WriteLine("Please choose either YES or NO");
                    break;
            }

          


            //BuildACreature("ghost", "monster", "ghost");
            //BuildACreature("monster", "ghost", "bug");

            //SwitchCase(1, 3, 1);
            //RandomMode();



        }

        //static void BuildACreature(string head, string body)
        //{
        //    Random randomBodyPart = new Random();
        //    int head = randomBodyPart.Next(1, 4);
        //    int body = randomBodyPart.Next(1, 4);
        //    int feet = randomBodyPart.Next(1, 4);


        //    int headNum = TranslateToNumber(head);
        //    int bodyNum = TranslateToNumber(body);

        //    SwitchCase(headNum, bodyNum, feetNum);
        //}

        static void BuildACreature(string head, string body, string feet)
        {
            Random randomBodyPart = new Random();
            int headNum, bodyNum, feetNum;

            if (head == "")
            {
                headNum = randomBodyPart.Next(1, 4);
            }
            else
            {
                headNum = TranslateToNumber(head);
            }

            if (body == "")
            {
                bodyNum = randomBodyPart.Next(1, 4);
            }
            else
            {
                bodyNum = TranslateToNumber(body);
            }

            if (feet == "")
            {
                feetNum = randomBodyPart.Next(1, 4);
            }
            else
            {
                feetNum = TranslateToNumber(feet);
            }

            SwitchCase(headNum, bodyNum, feetNum);

            //switch (head)
            //{
            //    case "ghost":
            //        GhostHead();
            //        break;
            //    case "bug":
            //        BugHead();
            //        break;
            //    case "monster":
            //        MonsterHead();
            //        break;
            //    default:
            //        Console.WriteLine("you didn't type anything");
            //        break;
            //}

            //switch (body)
            //{
            //    case "ghost":
            //        GhostBody();
            //        break;
            //    case "bug":
            //        BugBody();
            //        break;
            //    case "monster":
            //        MonsterBody();
            //        break;
            //    default:
            //        Console.WriteLine("you didn't type anything");
            //        break;
            //}

            //switch (feet)
            //{
            //    case "ghost":
            //        GhostFeet();
            //        break;
            //    case "bug":
            //        BugFeet();
            //        break;
            //    case "monster":
            //        MonsterFeet();
            //        break;
            //    default:
            //        Console.WriteLine("you didn't type anything");
            //        break;
            //}
        }

        static void SwitchCase(int headNum, int bodyNum, int feetNum)
        {
            switch (headNum)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
                default:
                    break;
            }

            switch (bodyNum)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
                default:
                    break;
            }

            switch (feetNum)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
                default:
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            SwitchCase(head, body, feet);
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
