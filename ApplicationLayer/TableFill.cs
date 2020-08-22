
namespace ApplicationLayer
{
    class TableFill
    {
        //Method to fill arrays
        public static int[] Fill(int[] arr, int firstDay, bool IsSundayDone, int countOfDays)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (IsSundayDone)    //If sundays are done, put empty field 
                    {
                        arr[i] = 0;
                        arr[i + 1] = firstDay;
                        i++;       //Go to the next iteration
                    }
                    else
                    {
                        arr[i] = firstDay;
                    }
                }
                else
                {
                    // The previous value + 7 
                    if ((arr[i - 1] + 7) <= countOfDays)
                    {
                        arr[i] = arr[i - 1] + 7;
                    }
                    else
                    {
                        i++;     //Go to the next iteration
                    }
                }
            }
            return arr;
        }
    }
}
