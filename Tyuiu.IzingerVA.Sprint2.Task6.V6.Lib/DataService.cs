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
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
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
