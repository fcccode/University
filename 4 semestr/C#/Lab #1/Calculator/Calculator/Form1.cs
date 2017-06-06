using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;                          // переменная для вывода результата
        //==================================================================================================================
        // инициализация формі
        public Form1() {
            InitializeComponent();
        }

        //==================================================================================================================
        private void Form1_Load(object sender, EventArgs e){

        }

        //==================================================================================================================
        // Обработчик событий кнопок
        // Кнопка СЕ
        private void button5_Click(object sender, EventArgs e){
            textBox1.Text = "";                     // Отчистить текстовое поле
            textBox2.Text = "";                     // Отчистить текстовое поле
            textBox3.Text = "";                     // Отчистить текстовое поле
            textBox2.Enabled = true;                // Активировать текстовое поле 2 (см. метод факториал и процент)
        }

        //==================================================================================================================
        // Кнопка "умножения"
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");  // вывод информационого поля
            else  if (textBox2.Text == "")              // если в тестовое поле 2 не ввели значение
                MessageBox.Show("Введите значение 2");  // вывод информационого поля
            else {                                      // конвертация и умножение двух значение 
                result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();      // отображение результата в текстовом поле 3
            }
        }

        //==================================================================================================================
        // Кнопка "Сложения"
        private void button1_Click(object sender, EventArgs e){
            if (textBox1.Text == "")                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");  // вывод информационого поля
            else if (textBox2.Text == "")               // если в тестовое поле 2 не ввели значение
                MessageBox.Show("Введите значение 2");  // вывод информационого поля
            else{                                       // конвертация и сложение двух значение 
                result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();      // отображение результата в текстовом поле 3
            }
        }
        //==================================================================================================================
        // Кнопка "Минус"
        private void button2_Click(object sender, EventArgs e){
            if (textBox1.Text == "")                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");  // вывод информационого поля
            else if (textBox2.Text == "")               // если в тестовое поле 2 не ввели значение
                MessageBox.Show("Введите значение 2");  // вывод информационого поля
            else{                                       // конвертация и разность двух значение 
                result = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();      // отображение результата в текстовом поле 3
            }
        }
        //==================================================================================================================
        // Кнопка "деления"
        private void button3_Click(object sender, EventArgs e) {
            if (textBox1.Text == "")                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");  // вывод информационого поля
            else if (textBox2.Text == "")               // если в тестовое поле 2 не ввели значение
                MessageBox.Show("Введите значение 2");  // вывод информационого поля
            else if (Convert.ToDouble(textBox2.Text)==0)// если введеное значение равно 0
                MessageBox.Show("На ноль делить нельзя");// вывод информационого поля
            else {                                      // конвертация и деление двух значение 
                result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                textBox3.Text = result.ToString();      // отображение результата в текстовом поле 3
            }
        }
        //==================================================================================================================
        // Кнопка "Возведение в квадрат"
        private void button6_Click(object sender, EventArgs e){
            if (textBox1.Text == "")                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");  // вывод информационого поля
            else {
                    textBox2.Enabled = false;           // блокируем текстовое поле 2
                    textBox2.Text = "use only first textBox";   // информируем пользователя
                                                    //конвертация и возведение в квадрат значение текстового поля 1
                    result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                    textBox3.Text = result.ToString();  // отображение результата в текстовом поле 3
            }
        }


        //==================================================================================================================
        // Кнопка "Факториал числа"
        private void button8_Click(object sender, EventArgs e) {   
            if (textBox1.Text == "")                            // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");          // вывод информационого поля
            else if (Convert.ToInt32(textBox1.Text) == 0)      // если введеное значение равно 0
                MessageBox.Show("Факториал 0 : = 1");           // вывод информационого поля со значение 1
            else {
                textBox2.Enabled = false;                       // блокируем текстовое поле 2
                textBox2.Text = "use only first textBox";       // информируем пользователя

                int value = Convert.ToInt32(textBox1.Text);     // конвертируем полученое значение в целочисленную переменную
                int temp = 1;                                   // для коррекной работы временная переменная

                for (int i = 1; i <= value; i++)                // подсчитываем факториал
                    temp = temp * i;
               
                textBox3.Text = temp.ToString();                 // отображение результата в текстовом поле 3
            }
        }
        //==================================================================================================================
        // Кнопка "Подсчета процентов"
        private void button7_Click(object sender, EventArgs e) {
            if (textBox1.Text == "")                                    // если в тестовое поле 1 не ввели значение
                MessageBox.Show("Введите значение 1");                  // вывод информационого поля
            else
                 if (textBox2.Text == "")                               // если в тестовое поле 1 не ввели значение
                    MessageBox.Show("Введите значение 2");              // вывод информационого поля
            else
                    if (Convert.ToInt32(textBox2.Text) == 0)                             // если в текстовом поле значение равно 0
                        textBox3.Text = "0";                            // отображение результата в текстовом поле 3
                    else {
                        double first = Convert.ToDouble(textBox1.Text); // конвертируем значение первого текстового поля
                        double second = Convert.ToDouble(textBox2.Text);// конвертируем значение второго текстового поля
                        result = (second * 100) / first;                // подсчет процента
                        textBox3.Text = result.ToString();              // отображение результата в текстовом поле 3
            }
        }

        //==================================================================================================================
        // Обработка ввода только чисел
        // таблица ASCII и значение чисел 
        // обработка текстового поля1
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e){
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        // обработка текстового поля 2
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e){
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        //==================================================================================================================


    }
}
