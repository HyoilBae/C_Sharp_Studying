using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PassWordChecker

//In this project you’ll make a program that measures the strength of any given password based on the following criteria.A strong password:

//is at least 8 characters long
//has lowercase letters
//has uppercase letters
//has numerical digits
//has symbols, like #, ?, !

//The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.


{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = uppercase.ToLower();
            Console.WriteLine(lowercase);
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*()<>?,./:";

            Console.WriteLine("Enter Your PassWord: ");
            string passWord = Console.ReadLine();

            int score = 0;

            if ((int)passWord.Length >= minLength)
            {
                score++;
            }


            if (passWord.Contains(uppercase))
            {
                score++;
            }
            Console.WriteLine(score);

            switch (score)
            {
                case 1:
                    Console.WriteLine("Your password is too weak");
                    break;
                default:
                    break;
            }




        }
    }
}
