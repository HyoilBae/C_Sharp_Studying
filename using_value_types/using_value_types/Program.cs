using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using using_value_types.Classes;
using Microsoft.Office.Interop.Excel;


namespace using_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region valuetypes

            ////int myInt;
            //int myNewInt = new int();

            //System.Int32 myInt32 = new System.Int32();

            ////Console.WriteLine(myInt);

            //Console.WriteLine(myNewInt);

            //Console.WriteLine(myInt32);

            //#endregion valuetypes

            //#region junk
            ////declare some numeric data types
            //int myInt;
            //double myDouble;
            //byte myByte;
            //char myChar;
            //decimal myDecimal;
            //float myFloat;
            //long myLong;
            //short myShort;
            //bool myBool;

            //// assign values to these types and then
            //// print them out to the console window
            //// also use the sizeOf operator to determine
            //// the number of bytes taken up be each type

            //myInt = 5000;
            //Console.WriteLine("Integer");
            //Console.WriteLine(myInt);
            //Console.WriteLine(myInt.GetType());
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine();

            //myDouble = 5000.0;
            //Console.WriteLine("Double");
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDouble.GetType());
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine();

            //myByte = 254;
            //Console.WriteLine("Byte");
            //Console.WriteLine(myByte);
            //Console.WriteLine(myByte.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myChar = 'r';
            //Console.WriteLine("Char");
            //Console.WriteLine(myChar);
            //Console.WriteLine(myChar.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myDecimal = 20987.89756M;
            //Console.WriteLine("Decimal");
            //Console.WriteLine(myDecimal);
            //Console.WriteLine(myDecimal.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myFloat = 254.09F;
            //Console.WriteLine("Float");
            //Console.WriteLine(myFloat);
            //Console.WriteLine(myFloat.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myLong = 2544567538754;
            //Console.WriteLine("Long");
            //Console.WriteLine(myLong);
            //Console.WriteLine(myLong.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myShort = 3276;
            //Console.WriteLine("Short");
            //Console.WriteLine(myShort);
            //Console.WriteLine(myShort.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();

            //myBool = true;
            //Console.WriteLine("Boolean");
            //Console.WriteLine(myBool);
            //Console.WriteLine(myBool.GetType());
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine();
            #endregion

            #region InteropExcel

            //Opens excel and creates a new worksheet

            Microsoft.Office.Interop.Excel._Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets[1];

            excelApp.Visible = true;

            worksheet.Cells[1, 1].Value = "Value";
            worksheet.Cells[1, 2].Value = "Value Squared";

            for (int i = 0; i <= 10; i++)
            {
                worksheet.Cells[i + 1, 1].Value = i;
                worksheet.Cells[i + 1, 2].Value = (i * 1).ToString();
            }

            worksheet.Columns[1].AutoFit();
            worksheet.Columns[2].AutoFit();

            #endregion

            #region dynamic data types



            #endregion

        }
    }
}
