using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter a secret message: ");
            string userMessage = (Console.ReadLine()).ToLower();

            char[] secretMessage = userMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretMessageChar = secretMessage[i];
                int secretMessageIndex = Array.IndexOf(alphabet, secretMessageChar);
                int charIndexPlus3 = (secretMessageIndex + 3) % alphabet.Length;
                char encryptedChar = alphabet[charIndexPlus3];
                encryptedMessage[i] = encryptedChar;
                //Console.Write(encryptedMessage[i]);
            }

            string msgString = String.Join("", encryptedMessage);
            Console.WriteLine(msgString);


            //The app doesn’t work with uppercase letters.Fix that by converting any message to lowercase.
            //The app doesn’t work with symbols, like !or?.Skip any symbols in your loop so that they are not encrypted.
            //Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array.
            //Write a Decrypt() method which takes a character array and key and returns a decrypted character array.


            //char[] secretMessage = { 'h', 'e', 'l', 'l', 'o' };

            //// encrypted should equal  {'k', 'h', 'o', 'o', 'r'}
            //string encrypted = Encrypt(secretMessage, 3);

            //// decrypted should equal {'h', 'e', 'l', 'l', 'o'}
            //string decrypted = Decrypt(encrypted, 3);


            //            Convert strings to lowercase with ToLower():

            //// quiet will be "hey"
            //string loud = "HEY";
            //            string quiet = loud.ToLower();
            //            Use if and else statements to perform different actions based on different character types.

            //Check if a character is a letter using Char.IsLetter():

            //// b will be false
            //char ch = "?";
            //            bool b = Char.IsLetter(ch);
        }
    }
}
