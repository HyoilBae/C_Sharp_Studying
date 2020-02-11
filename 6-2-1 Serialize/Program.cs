using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _6_2_1_Serialize
{
    class Program
    {
        [Serializable]
        struct DATA
        {
            public int var1;
            public float var2;
            public string str1;
        }
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str1 = "test2";

            using (FileStream fs1 =
                new FileStream("test.dats", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            DATA[] resultdata;

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                resultdata = (DATA[])bf2.Deserialize(fs2);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}", resultdata[i].var1, resultdata[i].var2, resultdata[i].str1);
            }
        }
    }
}
