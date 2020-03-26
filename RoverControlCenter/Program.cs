using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            //Rover[] rovers = { lunokhod, apollo, sojourner };

            //DirectAll(rovers);


            //Object[] probes = { lunokhod, apollo, sojourner, sputnik };
            //Console.WriteLine($"Tracking a {lunokhod.GetType()}...");
            //Console.WriteLine($"Tracking a {probes[1]}...");
            //Console.WriteLine($"Tracking a {probes[2]}...");
            //Console.WriteLine($"Tracking a {probes[3]}...");


            IDirectable[] idirectables = { lunokhod, apollo, sojourner, sputnik };
            DirectAll(idirectables);

        }

        public static void DirectAll(IDirectable[] idirectables)
        {
            foreach (IDirectable idirectable in idirectables)
            {
                Console.WriteLine(idirectable.GetInfo());
                Console.WriteLine(idirectable.Explore());
                Console.WriteLine(idirectable.Collect());
            }
        }

    }
}
