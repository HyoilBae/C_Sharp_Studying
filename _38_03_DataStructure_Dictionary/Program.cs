using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_03_DataStructure_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> NewDic = new Dictionary<string, int>();

            NewDic.Add("number 1", 1);
            NewDic.Add("number 2", 2);
            NewDic.Add("what number is this?", 877978);

            Console.WriteLine(NewDic["number 1"]);

            string Key = "it doens't exist";

            if (true == NewDic.ContainsKey(Key))
            {
                Console.WriteLine(NewDic[Key]);
            }

        }
    }
}
