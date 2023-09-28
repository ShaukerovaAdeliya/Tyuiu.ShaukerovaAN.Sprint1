using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint1.Task6.V18.Lib;

// ЗАДАНИЕ
// Написать программу: пользователь вводит текст.
// Проверить, что строка является символьным представлением натурального числа.

namespace Tyuiu.ShaukerovaAN.Sprint1.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что строка является символьным                               *");
            Console.WriteLine("* представлением натурального числа.                                      *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку");

            string x = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool res = ds.CheckNumber(x);
            if (res == true)
            {
                Console.WriteLine("Натуральное число");
            }
            if (res == false)
            {
                Console.WriteLine("Не натуральное число");
            }
              
            Console.ReadKey();
        }
    }
}
