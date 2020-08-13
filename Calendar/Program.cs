using ApplicationLayer;
using System;

namespace Calendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter year:");
            int year = int.Parse(Console.ReadLine());

            if (day >= 32 || month >= 13 || (year >= 2400 || year <= 1600))       //Validate of date.
            {
                Console.WriteLine("\n Not correct date.Please try again... ");
                Console.ReadKey();
                Console.Clear();
                Main();
            }

            // List of varriable for building calendar table

            DateTime firstDayOfCurrentMonth = new DateTime(year, month, 1);
            int countOfDays = System.DateTime.DaysInMonth(firstDayOfCurrentMonth.Year, firstDayOfCurrentMonth.Month);
            DateTime selectedDate = new DateTime(year, month, day);    
            
            //Varible "newTable" contain arrays-horisontal string of calendar.

            var newTable = TableBuilder.Build(firstDayOfCurrentMonth, countOfDays);      
            
            //This call of method printing array to console.

            Output.Print(newTable, day, month, year);

            //Try again...
          
            Console.WriteLine("\n\n To continue press enter...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
