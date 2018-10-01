using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вариант задания
        /// </summary>
        public static int variant = 19;

        /// <summary>
        /// Расчет факториала
        /// </summary>
        public int Factorial(int input)
        {
            int answer = 0;
            if (input > 0)
            {
                int count = 1;
                while (count <= input)
                {
                    if (count == 1)
                    {
                        answer = 1;
                        count++;
                    }
                    else
                    {
                        answer = count * answer;
                        count++;
                    }
                }
            }
            else
            { MessageBox.Show("Please enter only a positive integer."); }

            return answer;
        }

        /// <summary>
        /// Заданая функция
        /// </summary>
        public double Function(int x)
        {
                return Math.Sin((20 * x) / (Math.Sqrt(variant + 13))) + (100 * Math.Pow(x, 2)) / (variant + 37);
        }

        /// <summary>
        /// Коэфициент 
        /// </summary>
        public double BinominalKoeficient(int n, int k)
        {
            return Factorial(n) / Factorial(k) * Factorial(n - k);
        }

        /// <summary>
        /// Разсчет бернштайна
        public double BernshtanePolinom(int x, int n)
        {
            double polinomValue = 0.0;
            int k;
            for (k = 0; k <= n; k++)
            {
                polinomValue += BinominalKoeficient(k, n) * Function(k / n) * Math.Pow(x, k) * Math.Pow(x, n - k);
            }
            return polinomValue;

        }

        /// <summary>
        /// Подсчет для выделеной функции
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<double> Calculate(int value)
        {
            List<double> list = new List<double>();
            for(int idx =0; idx < value;idx++)
            {
                list.Add(BernshtanePolinom(idx, value));
            }
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics;
            graphics = this.CreateGraphics();
            Pen pen = new Pen();
        }
    }
}
