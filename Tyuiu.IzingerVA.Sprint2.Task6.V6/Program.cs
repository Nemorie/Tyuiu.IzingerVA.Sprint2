using System;
using Tyuiu.IzingerVA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.IzingerVA.Sprint2.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Изингер В. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Изингер Владислав Александрович | РППб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства           *");
            Console.WriteLine("* карты k (6 <= k <= 14) определить полное название соответствующей       *");
            Console.WriteLine("* карты в виде «Дама пик», «Шестерка бубен» и т. п.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти m (1 - пики, 2 - трефы, 3 - бубны, 4 - червы): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты k (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindCardNameAndValue(m, k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Полное название карты: " + res);

            Console.ReadLine();
        }
    }
}
