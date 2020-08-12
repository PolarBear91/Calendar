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

            if (day >= 32 || month >= 13 || (year >= 2400 || year <= 1600))
            {
                Console.WriteLine();
                Console.WriteLine("Not correct date.Please try again... ");
                Console.ReadKey();
                Console.Clear();
                Main();
            }

            int selectedDay = day;
            var dt = new DateTime(year, month, 1);
            DateTime SelectedDt;
            int countOfDays = System.DateTime.DaysInMonth(dt.Year, dt.Month);

            try
            {
                SelectedDt = new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine("To continue press enter...");
                Console.ReadKey();
                Console.Clear();
                Main();
            }

            TableBuilder.Build(dt);
        }
    }
}
