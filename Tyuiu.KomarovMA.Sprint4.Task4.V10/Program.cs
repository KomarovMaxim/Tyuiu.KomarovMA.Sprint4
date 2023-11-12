using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint4.Task4.V10.Lib;
namespace Tyuiu.KomarovMA.Sprint4.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {



            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Комаров М.А.| СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерный массив                                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Александрович  | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив заполенный статическими значениями от 1 до 7,       ");
            Console.WriteLine(" нечетный элемент массива заменить на 0*                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите кол-во строк и столбцов через enter");
            int rows = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, length];

            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("Ваш массив");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(array);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}