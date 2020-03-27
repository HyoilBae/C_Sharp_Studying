using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Storm = new string[10];
            int stormIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Storm[stormIndex]);
                stormIndex++;
            }
            

            Storm storm1 = new Storm("wind", false, "Zul'rajas", "Seoul");
            Console.WriteLine(storm1.Announce());

            Pupil pupil1 = new Pupil("Mezil-kree", "Suwon");
            Console.WriteLine((pupil1.CastWindStorm()).Announce());

            Mage mage1 = new Mage("Gul'dan", "Masan");
            Console.WriteLine((mage1.CastRainStorm()).Announce());

            Archmage archmage1 = new Archmage("Nielas Aran", "Jejudo");
            Console.WriteLine((archmage1.CastRainStorm()).Announce());
            Console.WriteLine((archmage1.CastLightningStorm()).Announce());

        }
    }
}



/*
 * 
 * 
 * If you’d like more practice, try these optional challenges:

In Program.cs, store the Storm objects in an array instead of separate variables.
Add a string Origin property and a new constructor to the Pupil class. 
The constructor should have two parameters, one for Title and one for Origin. 
Add a similar constructor to Mage and Archmage. In other words, you should be able to run this code in Program.cs:
Pupil p = new Pupil("Mezil-kree", "Icecrown");
Mage m = new Mage("Gul'dan", "Draenor");
Archmage a = new Archmage("Nielas Aran", "Stormwind");
3. Define an abstract class Spell with Essence, IsStrong, and Caster properties and an abstract Announce() method. 
Make Storm inherit from Spell. A Spell.cs file is included in the workspace — find it by clicking the folder icon at the top of the text editor
*
* 
* 
* 
* You’ll need to define an array of type Storm[] and use an index to keep track of the last filled space in the array. For example:

Storm[] storms = new Storm[10];
int stormsIndex = 0;
Use a for loop to call Announce() on each object in the array.

The new constructors in Mage and Archmage should have two parameters and use base to call the superclass constructor.

The Spell class should be labeled abstract because its member Announce() is abstract. 
If Pupil inherits from Spell, then you can move the properties from Pupil to Spell. Change any private modifiers to protected. 
You must also label Pupil.Announce() with override.

    */