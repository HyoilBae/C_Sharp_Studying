using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 14, "New York", "USA", "he/him");

            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts",
                "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice colums" });

            //sam.name = "Sam Drakkila";

            Console.WriteLine(sam.ViewProfile());
            //sam.ViewProfile();


        }
    }
}
