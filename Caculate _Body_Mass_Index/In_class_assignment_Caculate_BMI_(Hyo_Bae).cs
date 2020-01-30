using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program is to calculate BMI using Userinput weight in pounds and Userheight in inches to tell user what classification a person is in

namespace Caculate_Body_Mass_Index
{
    public class BMI
    {
        //HOW?
        //This method will caculate BMI using two parameters (double weight and double heihgt)
        //and it will tell you which categories using if, if else, else statements
        //by using if else statements, you can set up the ragne among those each categories that are related with the caculated BMI number

        //WHY?
        //two parameters will use double data types because you can use either float or double data type for scientific data
        public void Caculate(float weight, float height)
        {
            //This will show you ALL categories
            Console.WriteLine("----------BMI Norms Table-----------");
            Console.WriteLine(" Classification   |    BMI(kg/m*2)  ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("    Underweight   |   Less than 18.5");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Severe thinness  |   Less than 16");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Moderate thinness |   16 - 16.99");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Mild thinness   |   17 - 18.49");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Normal weight   |   18.5 - 24.9");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("    Overweight    |   25 - 29.9");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("    Obese         |   More than 30");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Obese class I   |   30 - 34.9");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Obese class II  |   35 - 39.9");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Obese class III |   More than 40");
            Console.WriteLine("------------------------------------");


            float calculatedBMI = (weight * 703) / (float)((Math.Pow(height, 2)));

            //it will compare each range with calculatedBMI and will show output
            if (calculatedBMI >= 40)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Obese, " + "Obese class III");
            }
            else if (calculatedBMI >= 35 && calculatedBMI < 40)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Obese, " + "Obese class II");
            }
            else if (calculatedBMI >= 30 && calculatedBMI < 35)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Obese, " + "Obese class I");
            }
            else if (calculatedBMI >= 25 && calculatedBMI < 30)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Overweight");
            }
            else if (calculatedBMI >= 18.5 && calculatedBMI < 25)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Normal weight");
            }
            else if (calculatedBMI >= 17 && calculatedBMI < 18.50)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Underweight, " + "Mild thinness");
            }
            else if (calculatedBMI >= 16 && calculatedBMI < 17)
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Underweight, " + "Moderate thinness");
            }
            //if calculatedBMI doesn't belong to any other ranges above
            else
            {
                Console.WriteLine($"Your BMI is {calculatedBMI}");
                Console.WriteLine("Underweight, " + "Severe thinness");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //this will instatiate studentA in BMI class
            BMI studentA = new BMI();

            //this will ask enter your weight in pounds
            Console.WriteLine("Enter your weight in pounds : ");
            //convert string user input value to float value and set this value to inputWeight
            float inputWeight = float.Parse(Console.ReadLine());

            //this will ask enter your height in inches
            Console.WriteLine("Enter your height in inches : ");
            //convert string user input value to float value and set this value to inputHeihgt
            float inputHeight = float.Parse(Console.ReadLine());

            //this will caculate BMI using the method 'Caculate' with two float parameters; user input weight and heihgt
            studentA.Caculate(inputWeight, inputHeight);
        }
    }
}
