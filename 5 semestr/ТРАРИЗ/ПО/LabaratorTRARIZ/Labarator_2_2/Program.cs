using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadKey();
        }

        private static void ReadKey()
        {
            string key = Console.ReadLine();
            
            if (key != "0")
                ReadKey();

            Console.WriteLine(Convert.ToString(key));

        }
    }
}
