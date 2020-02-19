using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarCaculator
{
    class Calculator
    { 
        public void CalendarCalc(int month, int day, int year, int addDays)
        {
            //use switch statement because each month has different days.
            switch (month)
            {
                case 1:
                    //Jan
                    if (day + addDays > 31)
                    {
                        //month will be added if (day + addDays) over 31 beacuse Jan has 31 days.
                        month = month + ((day + addDays) / 31);
                        //day will be coverted to the left days after divide (day + addDays)
                        day = ((day + addDays) % 31);
                        //calculated day after the days are added to today's date
                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    else
                    {
                        //if (day+addDays) is less than days of the month you will have the same month but different days
                        day = day + addDays;

                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    break;
                 
                case 2:
                    //Feb
                    if (day + addDays > 29)
                    {
                        //month will be added if (day + addDays) over 29 beacuse Feb in 2020 has 29 days.
                        month = month + ((day + addDays) / 29);
                        //day will be coverted to the left days after divide (day + addDays)
                        day = ((day + addDays) % 29);


                        if (month == 4)
                        {
                            month = month + (day / 31);
                            day = (day % 31);
                        }


                        //calculated day after the days are added to today's date
                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    else
                    {   //if (day+addDays) is less than days of the month you will have the same month but different days
                        day = day + addDays;

                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    break;

                case 3:
                    //Mar
                    break;

                case 4:
                    //Apr
                    if (day + addDays > 30)
                    {
                        month = month + ((day + addDays) / 30);
                        day = ((day + addDays) % 30);
                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    else
                    {
                        day = day + addDays;

                        string calcDate = month + "-" + day + "-" + year;
                        Console.WriteLine("{0} days from today's date is {1}.\n", addDays, calcDate);
                    }
                    break;
                  
                case 5:
                    //May
                    break;

                case 6:
                    //Jun
                    break;

                case 7:
                    //Jul
                    break;

                case 8:
                    //Aug
                    break;

                case 9:
                    //Sep
                    break;

                case 10:
                    //Oct
                    break;

                case 11:
                    //Nov
                    break;

                case 12:
                    //Dec
                    break;

                default:
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ask user today's date

            Console.Write("What month is this? (please enter numeric number between 1 - 12): ");
            string month = Console.ReadLine();
            //Convert string value to int value
            int monthInt = int.Parse(month);

            Console.Write("What day is today? (please enter numeric number between 1 - 31): ");
            string day = Console.ReadLine();
            //Convert string value to int value
            int dayInt = int.Parse(day);

            //user enters the date (year, month, day)
            Console.Write("What year is this? (please enter numeric number): ");
            string year = Console.ReadLine();
            ////Convert string value to int value
            int yearInt = int.Parse(year);
            //int yearInt = 2020;

            //define todayDate with input year, month, day
            string todayDate = month + "-" + day + "-" + year;
            //string todayDate = month + "-" + day + "-" + yearInt;

            //ask user how many days want to add?
            Console.Write("\nHow many day do you want to add from today's date? ");
            //user enter the days to add 
            string daysAdd = Console.ReadLine();
            int daysAddInt = int.Parse(daysAdd);

            //Show today's date and days user wants to add from today's date
            Console.WriteLine("\nToday's date is {0}. \nWhat's the date if you add {1} days from today? ", todayDate, daysAdd);

            //instantiate calc in Calculator class
            Calculator calc = new Calculator();
            //using CalendarCalc function to get the result
            calc.CalendarCalc(monthInt, dayInt, yearInt, daysAddInt);
        }
    }
}
