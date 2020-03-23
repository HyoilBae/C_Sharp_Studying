using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class Forest
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.Trees = 0;

            Forest f2 = new Forest("Rendlesham");
            Console.WriteLine(f2.Biome);

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
        }



        public int age;
        private string biome;

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
        }

        public Forest(string name) : this(name, "Unknown")
        {
            Console.WriteLine("the second propert is not specified. Value defaulted to 'Unkown'");
        }

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }

}
