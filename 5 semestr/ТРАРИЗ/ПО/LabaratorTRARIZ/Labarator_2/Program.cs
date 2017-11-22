using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_2
{
    class Program
    {
        private static int n = 5;
        private static int[] array = new int[n];
        private static int counter = 0;
  

        static void Main(string[] args)
        {
            for(int i = 1; i <= array.Length; i++)
                array[i-1] = i;


            int t;
            t = 0;
            Function(t);

            Console.WriteLine(counter.ToString());

        }

        /// <summary>
        /// Рекурсивная функция
        /// </summary>
        private static void Function(int t)
        {
            if(t == n-1)
            {
                for (int i = 0; i < array.Length; i++)
                    counter++;
            }
            else 
            {
                for (int j = t + 1; j < array.Length; j++)
                {
                    Swap(array[t+1], array[j]);
                    Function(t+1);
                    Swap(array[t + 1], array[j]);
                }      
            }
        }

        /// <summary>
        /// Перестановка
        /// </summary>
        /// <param name="a">первое значение</param>
        /// <param name="b">второе значение</param>
        private static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
