using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        //Constructor
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("************** \nNumbers of * are not same as your password length");
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
            Console.WriteLine("Password has been reset.");
        }
    }
}
