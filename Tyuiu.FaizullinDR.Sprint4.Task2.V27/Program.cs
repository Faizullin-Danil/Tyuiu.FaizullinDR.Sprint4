using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task2.V27.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #2                                                                           *");
            Console.WriteLine("* Вариант #27                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный случайными           *");
            Console.WriteLine("* в диапазоне от 2 до 7 подсчитать сумму четных элементов массива.                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");




            int[] arr = new int[13];


            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(2, 8);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(arr));

            Console.ReadLine();
        }
    }
}
