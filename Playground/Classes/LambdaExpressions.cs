using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class LambdaExpressions
    {
        public static void WriteToConsole(string message)
        {
            Console.WriteLine("LambdaExp: {0}", message);
        }

        public static void WriteToConsoleInReverse(string message)
        {
            char[] mCharArray = message.ToCharArray();
            Array.Reverse(mCharArray);
            Console.WriteLine("LambdaExp Reverse: {0}", new string(mCharArray));
        }
    }
}
