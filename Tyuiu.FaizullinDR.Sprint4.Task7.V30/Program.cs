using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task7.V30.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task7.V30
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
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #30                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '684259137159648'.                                 *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
            Console.WriteLine("* длина которых больше 5 символов.                                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            int[,] mtrx = new int[5, 3];
            string value = "684259137159648";

            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * 3 + j, 1));
                }
            }

            Console.WriteLine("Строка: "+value);

            

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Матрица 5 на 3:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtrx[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("произведение четных чисел = " + ds.Calculate(5, 3, value));

            Console.ReadLine();
        }
    }
}
