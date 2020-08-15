using ApplicationLayer;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Calendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter day:");
            string day = Console.ReadLine();
            Console.WriteLine("Please enter month:");
            string month = Console.ReadLine();
            Console.WriteLine("Please enter year:");
            string year = Console.ReadLine();

            int number;
            int dayDigit = 0, monthDigit = 0, yearDigit = 0;

            //Validate the values are correct

            if (Int32.TryParse(day, out number) && Int32.TryParse(month, out number) && Int32.TryParse(year, out number))
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

            DateTime firstDayOfCurrentMonth = new DateTime(yearDigit, monthDigit, 1);
            int countOfDays = System.DateTime.DaysInMonth(firstDayOfCurrentMonth.Year, firstDayOfCurrentMonth.Month);
            DateTime selectedDate = new DateTime(yearDigit, monthDigit, dayDigit);

            //Varible "newTable" contain arrays-horisontal string of calendar.

            var newTable = TableBuilder.Build(firstDayOfCurrentMonth, countOfDays);

            //This call of method printing array to console.

            Output.Print(newTable, dayDigit, monthDigit, yearDigit);

            //Try again...

            Console.WriteLine("\n\n To continue press enter...");
            Clean.doClear();
            Main();
        }
    }
}
