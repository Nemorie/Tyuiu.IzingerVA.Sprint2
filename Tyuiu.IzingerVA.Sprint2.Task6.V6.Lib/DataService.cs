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

            string cardValue;
            switch (k)
            {
                case 6:
                    cardValue = "шестерка";
                    break;
                case 7:
                    cardValue = "семерка";
                    break;
                case 8:
                    cardValue = "восьмерка";
                    break;
                case 9:
                    cardValue = "девятка";
                    break;
                case 10:
                    cardValue = "десятка";
                    break;
                case 11:
                    cardValue = "валет";
                    break;
                case 12:
                    cardValue = "дама";
                    break;
                case 13:
                    cardValue = "король";
                    break;
                case 14:
                    cardValue = "туз";
                    break;
                default:
                    cardValue = "неизвестно";
                    break;
            }

            string cardSuit;
            switch (m)
            {
                case 1:
                    cardSuit = "пик";
                    break;
                case 2:
                    cardSuit = "треф";
                    break;
                case 3:
                    cardSuit = "бубен";
                    break;
                case 4:
                    cardSuit = "червей";
                    break;
                default:
                    cardSuit = "неизвестно";
                    break;
            }

            return cardValue + " " + cardSuit;
        }
    }
}
