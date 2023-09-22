using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint1.Task2.V24.Lib;

// ЗАДАНИЕ
// написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчеты и печатает результат на экране.
// Расчеты: Заданы два числа. Вычислить квадрат их разницы.
// Первое число (целое число), Второе число (целое число)
// Квадрат разницы (целое число)

namespace Tyuiu.ShaukerovaAN.Sprint1.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Квадрат разницы чисел = " + ds.CalculateDiffSquare(x, y));

            Console.ReadLine();
        }
    }
}
