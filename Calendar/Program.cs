using ApplicationLayer;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Calendar
{
    class Program
    {
        static void Main()
        {
            //Taking user's input

            Console.WriteLine("Please enter day:");
            string day = Console.ReadLine();
            Console.WriteLine("Please enter month:");
            string month = Console.ReadLine();
            Console.WriteLine("Please enter year:");
            string year = Console.ReadLine();

            //Validate the values are correct

            int number;
            int dayDigit = 0, monthDigit = 0, yearDigit = 0;

            if (Int32.TryParse(day, out number) && Int32.TryParse(month, out number) && Int32.TryParse(year, out number))     //Validate correct type
            {
                dayDigit = int.Parse(day);
                monthDigit = int.Parse(month);
                yearDigit = int.Parse(year);

                if (dayDigit >= 32 || monthDigit >= 13 || (yearDigit >= 2400 || yearDigit <= 1600))       //Validate conditions of the task
                {
                    Console.WriteLine("\n Not correct date. Please try again... ");
                    Clean.doClear();
                    Main();
                }
            }
            else
            {
                Console.WriteLine("\n Not correct date. Please try again... ");
                Clean.doClear();
                Main();
            }


            // List of varriable for building calendar table

            DateTime firstDayOfCurrentMonth = new DateTime(yearDigit, monthDigit, 1);     // First day of user's month
            int countOfDays = System.DateTime.DaysInMonth(firstDayOfCurrentMonth.Year, firstDayOfCurrentMonth.Month);    // Count of days in user's mounth
            DateTime selectedDate = new DateTime(yearDigit, monthDigit, dayDigit);

            //Variable "newTable" contains arrays of days of week

            var newTable = TableBuilder.Build(firstDayOfCurrentMonth, countOfDays);

            //This call of method printing array to console

            Output.Print(newTable, dayDigit, monthDigit, yearDigit);

            //Try again...

            Console.WriteLine("\n To continue press enter...");
            Clean.doClear();
            Main();
        }
    }
}
