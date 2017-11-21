using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_3_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int[] array = new int[max];             // сортируемый массив
            Random rand = new Random();

            for(int i = 0; i < array.Length; i++)
                array[i] = rand.Next(min, max);
                       
            Console.WriteLine("Массив до сортировки");
            DisplayArray(array);

            Console.WriteLine("Массив после сортировки");
            HoarAlgorithms(array, min, array.Length - 1);
            DisplayArray(array);


            Console.ReadKey();
            
        }

        /// <summary>
        /// Рекурсивная версия алгоритма Хоара
        /// </summary>
        /// <param name="data">массив для сортировки</param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        private static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        /// <summary>
        /// Алгоритм Хоара
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="start">мин</param>
        /// <param name="end">макс</param>
        private static void HoarAlgorithms(int[] array, int start, int end)
        {
            if (start >= end)
                return;
            
            int pivot = Partition(array, start, end);
            HoarAlgorithms(array, start, pivot - 1);
            HoarAlgorithms(array, pivot + 1, end);
        }

        /// <summary>
        /// Отображения содержимого массива в консоли
        /// </summary>
        /// <param name="array">массив для отображения</param>
        private static void DisplayArray(int [] array)
        {
            foreach (int value in array)
                Console.WriteLine(Convert.ToString(value));
        }
    }
}
