using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Days_To_A_Date
{
    class Program
    {
        /// <summary>
        /// AddDays method to take year, month, day, and days, then add days to the date.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        private string AddDays(int year, int month, int day, int days)
        {
            days += ToDays(year, month, day); //adding julian days converted by ToDay method and add days to be added
            while (GetDays(year) < days) //it will iterate until the days are within the year
            {
                days -= GetDays(year);
                year++;
            }
            return ToDate(year, days); //return julian day format to string
        }

        /// <summary>
        /// Take year and return the days in the year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        private int GetDays(int year)
        {
            return (year % 4 == 0) ? 366 : 365; //if it is a leap year, return 366 days. otherwise, 365 days
        }

        /// <summary>
        /// GetMonthDay memthod to take year and month to and convert to julian days.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        private int ToDays(int year, int month, int day)
        {
            int days = 0;
            for (int m = 1; m < month; m++)
            {
                days += GetMonthDay(year, m); //adding whole month until days are smaller than the month.
            }
            days += day;
            return days;
        }

        /// <summary>
        /// Take year and julian date convert to string format.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        private string ToDate(int year, int days)
        {
            int month = 1;
            while (GetMonthDay(year, month) < days)
            {
                days -= GetMonthDay(year, month);
                month++;
                if (month == 13) //If month is 13, then it starts over from Jan.
                    month = 1;
            }
            string sDate = year.ToString() + "-" + month.ToString() + "-" + days.ToString();
            return sDate;
        }

        /// <summary>
        /// Take year and month to return the days in the month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        private int GetMonthDay(int year, int month)
        {
            //If month is less or equal to 7, odd month is 31 and the others are 30 except Feb.
            if (month <= 7)
            {
                if (month == 2)
                {
                    if (year % 4 == 0) //Leap year has 29 days. otherwise, 28 days.
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else if (month % 2 == 0)
                {
                    return 30;
                }
                return 31;
            }
            else //If month is not less or equal to 7, odd month is 30 and the others are 31.
            {
                if (month % 2 == 0)
                {
                    return 31;
                }
                return 30;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Please Enter Year");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Month");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Date");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Days to Add");
            int days = Int32.Parse(Console.ReadLine());
            Console.WriteLine(p.AddDays(year, month, day, days));
        }
    }
}