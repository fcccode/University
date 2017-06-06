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
        string maxLenString = "a";         // временная переменная для длиного слова
        int count = 1;                      // глобальная переменная счетчик
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // обработчик нажатия кнопки ОК
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = maxLenString.ToString();        // в текстовое поле 1 выводить длиное слово
            textBox2.Text = count.ToString();               // в текстовое поле 2 выводить количество повторений
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            count = 1;
            maxLenString = "";
            textBox1.Text = " ";
            Char delimiter = ' ';                                       // делитель
            String[] substrings = richTextBox1.Text.Split(delimiter);   // получаем подстроки
            foreach (var substring in substrings){                      // проходим по массиву подстрок
                if (substring.Length > maxLenString.Length){            // если строка длиньше чем (макс)
                    maxLenString = substring;                           // присвоить макс значение ей
                    count = 1;                                          // новый отсчет
                }
                else 
                if(substring== maxLenString)                            // если строка повторилась 
                    count++;                                            // считаем количество повторений
            }                                                           
         }
    }
}
