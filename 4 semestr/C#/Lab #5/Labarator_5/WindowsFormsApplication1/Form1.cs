using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int flag1;
        int x1, x2;
        int Finish;
        string player1 = null;
        string player2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
            Finish = panel1.Size.Width - pictureBox1.Width;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
            flag1 = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            flag1 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag1 != 0) // Если дан старт:
{
                Random a = new Random();    // Включаем генератор случайных чисел
                                              // В переменную count записываем случайное число в диапазоне от 0 до 8
                int count = a.Next(8);      // Наращиваем значение координаты x1 на случайное число count
                x1 += count;               // Выводим значение пройденного пути для первого игрока
                label1.Text = Convert.ToString(x1); // Смещаем первого жучка на случайную величину
                pictureBox1.Left = x1;      // Создаем случайное число для второго игрока и повторяем все то же самое
                count = a.Next(8);
                x2 += count;
                label2.Text = Convert.ToString(x2);
                pictureBox2.Left = x2;
            }

            if ((x1 >= Finish))
            {
                textBox3.Text = player1.ToString();
                flag1 = 0;
            }
            else if(x2 >= Finish)
            {
                textBox3.Text = player2.ToString();
                flag1 = 0;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            player1 = textBox1.Text;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Лабараторная работа №5 \n";
            const string caption = "Информация о проделанной работе";
            MessageBox.Show(message, caption,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // уменьшить интервал времени
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10; 
        }
        // увеличить интервал времени
        private void button4_Click(object sender, EventArgs e)
        {
            if(timer1.Interval !=0)
                 timer1.Interval = 100;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            player2 = textBox2.Text;
        }    
    }
}
