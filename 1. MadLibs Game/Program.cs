using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MadLibs_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs has started ");


            // Give the Mad Lib a title:
            string title = "TITLE";

            Console.WriteLine(title);
            // Define user input and variables:


            // The template for the story:

            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

            Console.Write("enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("enter adj1");
            string adj1 = Console.ReadLine();
            Console.WriteLine("enter adj2");
            string adj2 = Console.ReadLine();
            Console.WriteLine("enter adj3");
            string adj3 = Console.ReadLine();

            Console.WriteLine("enter verb");
            string verb = Console.ReadLine();

            Console.WriteLine("enter noun1");
            string noun1 = Console.ReadLine();
            Console.WriteLine("enter noun2");
            string noun2 = Console.ReadLine();

            Console.WriteLine("enter animal");
            string animal = Console.ReadLine();
            Console.WriteLine("enter food");
            string food = Console.ReadLine();
            Console.WriteLine("enter fruit");
            string fruit = Console.ReadLine();
            Console.WriteLine("enter superhero");
            string superhero = Console.ReadLine();
            Console.WriteLine("enter country");
            string country = Console.ReadLine();
            Console.WriteLine("enter dessert");
            string dessert = Console.ReadLine();
            Console.WriteLine("enter year");
            string year = Console.ReadLine();

            story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            Console.WriteLine(story);
        }

    }
    
}
