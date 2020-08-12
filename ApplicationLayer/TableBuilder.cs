using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer
{
    public class TableBuilder
    {
        public static void Build(DateTime dt)
        {
            int[] monday = new int[6];
            int[] tuesday = new int[6];
            int[] wednesday = new int[6];
            int[] thursday = new int[6];
            int[] friday = new int[6];
            int[] saturday = new int[6];
            int[] sunday = new int[6];

            int counter = 0;
            bool isSundayDone = false;


            while (counter != 7 || counter < 7)
            {
                if ((int)dt.DayOfWeek + counter == 1 || (sunday[0] != 0 && monday[0] == 0))
                {
                    Fill(monday, ++counter);
                }

                if ((int)dt.DayOfWeek + counter == 2 || (sunday[0] != 0 && tuesday[0] == 0))
                {
                    Fill(tuesday, ++counter);
                }

                if ((int)dt.DayOfWeek + counter == 3 || (sunday[0] != 0 && wednesday[0] == 0))
                {
                    Fill(wednesday, ++counter);
                }

                if ((int)dt.DayOfWeek + counter == 4 || (sunday[0] != 0 && thursday[0] == 0))
                {
                    Fill(thursday, ++counter);
                }

                if ((int)dt.DayOfWeek + counter == 5 || (sunday[0] != 0 && friday[0] == 0))
                {
                    Fill(friday, ++counter);
                }

                if ((int)dt.DayOfWeek + counter == 6 || (sunday[0] != 0 && saturday[0] == 0))
                {
                    Fill(saturday, ++counter);
                }

                if (((int)dt.DayOfWeek + counter == 0 || (int)dt.DayOfWeek + counter == 7) && (sunday[0] == 0))
                {
                    Fill(sunday, ++counter);
                    isSundayDone = true;
                }
            

            }

        }
    }
}