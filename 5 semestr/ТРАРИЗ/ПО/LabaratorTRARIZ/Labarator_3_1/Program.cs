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
        }

        /// <summary>
        /// Рекурсивная версия алгоритма Хоара
        /// </summary>
        /// <param name="data"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        static void HoarSort(double[] data, int begin, int end)
        {
            int iterator = begin, j = end;
            double temp;
            double middle = data[(begin + end) / 2];

            do
            {
                while (data[iterator] < middle)
                    iterator++;

                while (data[j] > middle)
                    j--;

                if (iterator <= j)
                {
                    if (iterator < j)
                    {
                        temp = data[iterator];
                        data[iterator] = data[j];
                        data[j] = temp;
                    }
                    iterator++;
                    j--;
                }
            } while (iterator <= j);

            if (iterator < end)
                HoarSort(data, iterator, end);
            if (begin < j)
                HoarSort(data, begin, j);
        }
    }
}
