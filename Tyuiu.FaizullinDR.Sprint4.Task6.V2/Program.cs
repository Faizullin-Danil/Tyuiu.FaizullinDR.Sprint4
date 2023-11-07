using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task6.V2
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
            Console.WriteLine("* Задание #6                                                                           *");
            Console.WriteLine("* Вариант #2                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан строковый массив данных ['Белый', 'Черный', 'Зеленый', 'Синий', 'Красный',       *");
            Console.WriteLine("* 'Желтый', 'Фиолетовый'], используя класс Array, выведите элементы массива,           *");
            Console.WriteLine("* длина которых больше 5 символов.                                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            string[] arr = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine("Массив:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Массив длина эелементов которого больше 5:");

            string[] res = ds.Calculate(arr);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
