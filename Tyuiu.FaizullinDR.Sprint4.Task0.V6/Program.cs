using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task0.V6.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #0                                                                           *");
            Console.WriteLine("* Вариант #6                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими         *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.        *");
            Console.WriteLine("* {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}                                                       *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int[] arr = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("Массив:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива = " + ds.GetSumOddArrEl(arr));

            Console.ReadLine();
        }
    
    }
}
