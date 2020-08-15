using ApplicationLayer;
using System;

namespace Calendar
{
    class Output
    {
        public static void Print(Arrays newTable, int day, int month, int year)
        {
            void CheckedCurrentDay(int[] arr)
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
                Console.WriteLine();
            }

            Console.Clear();
            Console.WriteLine("Your date is : {0}.{1}.{2} \n", day, month, year);

            Console.Write(@"Monday    ");
            CheckedCurrentDay(newTable.monday);

            Console.Write(@"Tuesday   ");
            CheckedCurrentDay(newTable.tuesday);

            Console.Write(@"Wednesday ");
            CheckedCurrentDay(newTable.wednesday);

            Console.Write(@"Thursday  ");
            CheckedCurrentDay(newTable.thursday);

            Console.Write(@"Friday    ");
            CheckedCurrentDay(newTable.friday);

            Console.Write(@"Saturday  ");
            CheckedCurrentDay(newTable.saturday);

            Console.Write(@"Sunday    ");
            CheckedCurrentDay(newTable.sunday);     
        }
    }
}
