using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task3.V30.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task3.V30
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
            Console.WriteLine("* Задание #3                                                                           *");
            Console.WriteLine("* Вариант #30                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими        *");
            Console.WriteLine("* значениями в диапазоне от 1 до 6. Найдите максимальный элемент в третьей строке массива.*");
            Console.WriteLine("* 2, 4, 3, 5, 1,                                                                       *");
            Console.WriteLine("* 6, 6, 1, 2, 6,                                                                       *");
            Console.WriteLine("* 3, 3, 2, 1, 5,                                                                       *");
            Console.WriteLine("* 6, 4, 1, 3, 3,                                                                       *");
            Console.WriteLine("* 5, 1, 1, 6, 4,                                                                       *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");




            int[,] arr =
            {
                {2,4,3,5,1 },
                {6,6,1,2,6 },
                {3,3,2,1,5 },
                {6,4,1,3,3 },
                {5,1,1,6,4 }
            };


            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.GetLength(0) ; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Максимальный элемент в 3 строке массива = " + ds.Calculate(arr));

            Console.ReadLine();
        }
    }
}
