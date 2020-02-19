using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Try_Catch
             * Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
             * 
             */
            ////--------------Example #1-----------------------
            //int n;//set variable n as integer
            //try//try to see if variable n has a value of 123
            //{
            //    // Do not initialize this variable here.
            //    n = 123;
            //}
            //catch
            //{
            //}
            //// Error: Use of unassigned local variable 'n'.
            ////Console.Write(n);
            //Console.WriteLine("This will have an error since n has no value");


            //--------------Example #2-----------------------
            string s = null; // For demonstration purposes.

            try
            {
                //Calling ProcessString method to check s is null or not
                ProcessString(s);
            }
            //if Exception has happened print out a message
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        //static function to processstring value
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
