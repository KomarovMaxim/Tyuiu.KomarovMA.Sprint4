using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Комаров М.А. | СМАРТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Александрович | СМАРТБ-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* подсчитать произведение четных элементов массива                        *");
            Console.WriteLine("* С клавиатуры: 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int length = 11;
            int[] numsArray = new int[length];

            Console.WriteLine("Длина массива  " + length);

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(numsArray);

            Console.WriteLine("Сумма чётных элементов равна " + result);

            Console.ReadKey();

        }
    }
}
