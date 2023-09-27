using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint1.Task5.V3.Lib;

//ЗАДАНИЕ
// Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k (например, если k=130985, то h=9).

namespace Tyuiu.ShaukerovaAN.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Преобразование классов и типов Convert                            *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи             *");
            Console.WriteLine("* положительного целого числа k                                           *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение K:");
            int k = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
