using ApplicationLayer;
using System;

namespace Calendar
{
    class Output
    {

        public static void Print(Arrays newTable, int day, int month, int year)
        {
            Console.Clear();
            Console.WriteLine("Your date is : {0}.{1}.{2} \n", day, month, year);

            Console.WriteLine(@"Monday     ");
            CheckedCurentDay(newTable.monday);

            Console.WriteLine(@"Tuesday     ");
            CheckedCurentDay(newTable.tuesday);

            Console.WriteLine(@"Wednesday     ");
            CheckedCurentDay(newTable.wednesday);

            Console.WriteLine(@"Thursday     ");
            CheckedCurentDay(newTable.thursday);

            Console.WriteLine(@"Friday     ");
            CheckedCurentDay(newTable.friday);

            Console.WriteLine(@"Saturday     ");
            CheckedCurentDay(newTable.saturday);

            Console.WriteLine(@"Sunday     ");
            CheckedCurentDay(newTable.sunday);

            

            void CheckedCurentDay(int[] arr)    
            {
                foreach (var v in arr)
                {
                    if (v == 0)
                    {
                        Console.Write("  {0}  ", " ");
                    }
                    else
                    {
                        if (v >= 1 && v <= 9)
                        {
                            if (v == day)
                            {
                                Console.Write(" [{0}] ", v);
                            }
                            else
                            {
                                Console.Write("  {0}  ", v);
                            }
                        }

                        else
                        {
                            if (v == day)
                            {
                                Console.Write("[{0}] ", v);
                            }
                            else
                            {
                                Console.Write(" {0}  ", v);
                            }
                        }
                    }
                }
            }
        }
    }
}
