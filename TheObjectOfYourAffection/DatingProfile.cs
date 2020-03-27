using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Profile
    {
        private string name;
        private int age;
        //private int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (age >= 18)
        //        {
        //            age = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You must be over 18 yrs old to join us.");
        //        }
        //    }
        //}

        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name = "n/a", int age = 0, string city = "n/a", string country = "n/a", string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;

            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { };
        }
        public void SetHobbies(string[] hobbies)
            {
            this.hobbies = hobbies;
            }

        public string ViewProfile()
        {
            string currentHobbies = " ";

            foreach (string hobby in hobbies)
            {
                if (hobbies.Length > 0)
                {
                    currentHobbies += hobby + ", ";
                }
            }

            string bio = $"Name : {name}, \nAge: {age}, \nCity: {city}, \nCountry: {country}, \nHobbies: {currentHobbies}";

            //Console.WriteLine(bio);
            return bio;
          
        }

    }
}
