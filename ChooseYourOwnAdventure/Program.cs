using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?: ");
            Console.WriteLine("\n");

            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("\n");

            Console.WriteLine("It begins on a cold rainy night. " +
                               "You're sitting in your room and hear a noise coming from down the hall. " +
                               "Do you go investigate?");
            Console.WriteLine("\n");

            Console.WriteLine("Type YES or NO: ");
            Console.WriteLine("\n");
            string noiseChoise = (Console.ReadLine()).ToUpper();
            if (noiseChoise == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("---------------------THE END------------------------");
                return;
            }
            else if (noiseChoise == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. you walk toward it. Do you open or knocks?");
            }
            Console.WriteLine("\n");

            Console.WriteLine("TYPE OPEN or KNOCK");
            string doorChoice = (Console.ReadLine()).ToUpper();
            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks." +
                                  "It says, \"Answer this riddle: \"" +
                                  "Poor people have it. Rich people need it. If you eat it you die. What is it?");
                Console.WriteLine("\n");
                Console.WriteLine("Type your answer: ");
                string riddelAnswer = (Console.ReadLine()).ToUpper();
                if (riddelAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("THE END.");
                    return;
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    return;
                }


            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it");
                Console.WriteLine("Enter a number (1-3)");
                string keyChoice = (Console.ReadLine()).ToUpper();
                switch (keyChoice)
                {
                    case "1":                            
                        Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...THE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second the door doesn't open. THE END");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END");
                        break;
                }
            }






        }
    }
}
