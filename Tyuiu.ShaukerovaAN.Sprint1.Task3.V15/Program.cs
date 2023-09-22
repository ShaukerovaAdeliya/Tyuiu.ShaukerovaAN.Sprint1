using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint1.Task3.V15.Lib;

/// ЗАДАНИЕ
/// Написать программу, которая запрашивает у пользователя исходные данные,
/// выполняет указанные расчёты и печатает результат на экране.
/// Расчеты: Объявите все переменные и напишите программу вычисления расстояния между автомобилями через T часов.

namespace Tyuiu.ShaukerovaAN.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваиния                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ*                                                         ");
            Console.WriteLine("***************************************************************************");

            double V = 70;
            double L = 90;
            double S = 30;
            double T = 5;
            Console.WriteLine("Скорость первого автомобиля = " + V);
            Console.WriteLine("Скорость второго автомобиля = " + L);
            Console.WriteLine("Расстояние между автомобилями до начала движения = " + S);
            Console.WriteLine("Время, которое автомобили будут двигаться = " + T);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через T часов = " + ds.DistanceOverTime(V, L, S, T));

            Console.ReadKey();
        }
    }
}
