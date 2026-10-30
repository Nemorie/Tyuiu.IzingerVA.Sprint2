using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IzingerVA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay, prevMonth, prevYear;

            if (n > 1)
            {
                prevDay = n - 1;
                prevMonth = m;
                prevYear = g;
            }
            else
            {
                if (m == 1)
                {
                    prevDay = 31;
                    prevMonth = 12;
                    prevYear = g - 1;
                }
                else
                {
                    prevYear = g;
                    prevMonth = m - 1;

                    switch (prevMonth)
                    {
                        case 2:
                            prevDay = 29;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            prevDay = 30;
                            break;
                        default:
                            prevDay = 31;
                            break;
                    }
                }
            }

            return prevDay.ToString("D2") + "." + prevMonth.ToString("D2") + "." + prevYear;
        }
    }
}
