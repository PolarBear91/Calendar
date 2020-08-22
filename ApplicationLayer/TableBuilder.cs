using System;

namespace ApplicationLayer
{
    public class TableBuilder
    {
        public static Arrays Build(DateTime selectedDate, int countOfDays)
        {
            Arrays newTable = new Arrays();
            int counter = 0;
            bool isSundayDone = false; //Shows when the sundays array is done  

            while (counter != 7 || counter < 7)
            {
                /* 
                To fill arrays need to check:
                1) The 1st part of condition checks which day of week is the current day
                2) The 2nd part - is sundays array not empty, is the current array empty
                */

                if ((int)selectedDate.DayOfWeek + counter == 1 || (newTable.sunday[0] != 0 && newTable.monday[0] == 0))
                {
                    TableFill.Fill(newTable.monday, ++counter, isSundayDone, countOfDays);
                }

                if ((int)selectedDate.DayOfWeek + counter == 2 || (newTable.sunday[0] != 0 && newTable.tuesday[0] == 0))
                {
                    TableFill.Fill(newTable.tuesday, ++counter, isSundayDone, countOfDays);
                }

                if ((int)selectedDate.DayOfWeek + counter == 3 || (newTable.sunday[0] != 0 && newTable.wednesday[0] == 0))
                {
                    TableFill.Fill(newTable.wednesday, ++counter, isSundayDone, countOfDays);
                }

                if ((int)selectedDate.DayOfWeek + counter == 4 || (newTable.sunday[0] != 0 && newTable.thursday[0] == 0))
                {
                    TableFill.Fill(newTable.thursday, ++counter, isSundayDone, countOfDays);
                }

                if ((int)selectedDate.DayOfWeek + counter == 5 || (newTable.sunday[0] != 0 && newTable.friday[0] == 0))
                {
                    TableFill.Fill(newTable.friday, ++counter, isSundayDone, countOfDays);
                }

                if ((int)selectedDate.DayOfWeek + counter == 6 || (newTable.sunday[0] != 0 && newTable.saturday[0] == 0))
                {
                    TableFill.Fill(newTable.saturday, ++counter, isSundayDone, countOfDays);
                }

                if (((int)selectedDate.DayOfWeek + counter == 0 || (int)selectedDate.DayOfWeek + counter == 7) && (newTable.sunday[0] == 0))
                {
                    TableFill.Fill(newTable.sunday, ++counter, isSundayDone, countOfDays);
                    isSundayDone = true;
                }
            }
            return newTable;
        }
    }
}