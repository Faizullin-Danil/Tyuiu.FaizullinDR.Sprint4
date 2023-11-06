using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task4.V16.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task4.V16
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
            Console.WriteLine("* Задание #4                                                                           *");
            Console.WriteLine("* Вариант #16                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с        *");
            Console.WriteLine("* клавиатуры в диапазоне от 3 до 7. Заменить четные элементы массива на 1.             *");
            Console.WriteLine("* 6, 5, 6, 7, 3,                                                                       *");
            Console.WriteLine("* 5, 4, 6, 7, 3,                                                                       *");
            Console.WriteLine("* 5, 5, 5, 6, 5,                                                                       *");
            Console.WriteLine("* 6, 5, 4, 4, 3,                                                                       *");
            Console.WriteLine("* 4, 5, 4, 5, 5,                                                                       *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Введите количество строк массива");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, columns];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //в либу

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                        arr[i, j] = 1;
                }
            }

            // ds.




            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            

            



            Console.ReadLine();
        }
    }
}
