using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Labarator #2_2 : \n");                 // представление программы
            int n = ReadInteger("Введите размер массива(строк) :");    // приглашение ввести значение размера массива
            int m = ReadInteger("Введите размер массива(столбцов) :");    // приглашение ввести значение размера массива

            int[,] array = new int[n, m];       // матрица размером m x n
            InitwithRandom(array, n, m);          // рандомная инициализация
            Display(array, n, m);                 // оторажение массива
            CheckArray(array, n, m);            // проверка
            Console.ReadKey();                  // задержка

        }
        //==================================================================================================
        // рандомная инициализация
        static void InitwithRandom(int[,] array, int row, int column)
        {
            Random ran = new Random();                      // обьект класса рандом
            for (int i = 0; i < row; i++)                   // проход по матрице
                for (int j = 0; j < column; j++)
                    array[i, j] = ran.Next(-100, 100);       // рандомная инит.
        }

        //==================================================================================================
        // Ввод целочисленной переменной 
        static int ReadInteger(string prompt)
        {
            int x;                                     // переменная для считания с консоли
            do
            {
                Console.Write(prompt);                          // приглашение ввести значение
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;                             // возвращаем корректное целое число значение
        }
        //==================================================================================================
        // Отображение массива
        static void Display(int[,] array, int row, int column)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    Console.WriteLine("[" + (i + 1) + "],[" + (j + 1) + "]" + " й элемент = " + array[i, j]);
        }
        //==================================================================================================
        // проверка количества полож и отриц чисел
        static void CheckArray(int[,] array, int row, int column)
        {
            int posIterator = 0;                    // положительный итератор
            int negIterator = 0;                    // отрицательный итератор
            for (int i = 0; i < row; i++)           // проход по матрице
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] < 0)            // если значение отрицательное
                        negIterator++;              // увел. негат итератор
                    else if (array[i, j] >= 0)     // иначе полож итератор
                        posIterator++;
                }                       // отображение результата
            Console.WriteLine("Положительные числа = " + posIterator);
            Console.WriteLine("Отрицательные числа = " + negIterator);
        }

    }
}
