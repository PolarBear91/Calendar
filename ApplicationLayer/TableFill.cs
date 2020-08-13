
namespace ApplicationLayer
{
    class TableFill
    {
        public static int[] Fill(int[] arr, int firstDay, bool IsSundayDone, int countOfDays)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (IsSundayDone)
                    {
                        arr[i] = 0;
                        arr[i + 1] = firstDay;
                        i++;
                    }
                    else
                    {
                        arr[i] = firstDay;
                    }
                }
                else
                {
                    if ((arr[i - 1] + 7) <= countOfDays)
                    {
                        arr[i] = arr[i - 1] + 7;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return arr;
        }
    }
}
