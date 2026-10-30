using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IzingerVA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            int m, k;
            if (value1 <= 4)
            {
                m = value1;
                k = value2;
            }
            else
            {
                k = value1;
                m = value2;
            }

            string cardValue = k switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => throw new ArgumentException($"Недопустимое достоинство карты: {k}")
            };

            string cardSuit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new ArgumentException($"Недопустимая масть карты: {m}")
            };

            return $"{cardValue} {cardSuit}";
        }
    }
}
