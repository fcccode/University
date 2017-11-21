using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_2
{
    class Program
    {
     //   procedure Generate(k:byte);
     //   var i, j:byte;
	    //procedure Swap(var a, b:byte);
     //   var c:byte;
	    //begin c:=a;a:=b;b:=c end;
     //   begin
	    //if k=N then

     //     begin for i:=1 to N do write(X[i]); writeln end
	    //else
	    //  for j:=k+1 to N do

     //   begin
     //     Swap(X[k + 1], X[j]);

     //     Generate(k+1);

     //     Swap(X[k + 1], X[j])

     //   end
     // end;

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
        /// Замена
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
