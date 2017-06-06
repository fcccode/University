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
        int mark = 0;           // баллы
        string username;        // имя пользователя
        int choose = 0;         // число рандома
        bool flag = false;      // флаг для запуска и остановки
        int user = 0;           // выбор пользователя

        // путь загрузки ресурсов
        string path = "D:\\Program_listings\\Visual Studio\\Labarator\\Laba #5\\";

        public Form1()
        {
            InitializeComponent();
        }

        // событие таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = null;
            if (flag && username!= null ){              // если нажата кнопка старт и польз ввел имя
                user = 0;                               // обнуляем
                choose = 0;                             // обнуляем
                Random a = new Random();                // обьект рандома
                choose = a.Next(1, 8);                  // случайное число
                temp = path + choose.ToString()+".jpg"; // конкатенация полного пути к файлу
                pictureBox1.Load(temp);                 // загрузка картинки

                
            }
        }
        // условия победы
        public void win() {
            if (user == choose) {                       // если ответ пользователя правильный
                mark += 10;                             // увеличиваем баллы
                label2.Text = Convert.ToString(mark);   // выводим результат
            }
        }
       

        // лиса
        private void button1_Click(object sender, EventArgs e){
            user = 1;
            win();
        }
        // кот
        private void button2_Click(object sender, EventArgs e){
            user = 2;
            win();
        }
        // еж
        private void button3_Click(object sender, EventArgs e){
            user = 3;
            win();
        }
        // енот
        private void button4_Click(object sender, EventArgs e){
            user = 4;
            win();
        }
        // медведь
        private void button5_Click(object sender, EventArgs e){
            user = 5;
            win();
        }
        // корова
        private void button6_Click(object sender, EventArgs e){
            user = 6;
            win();
        }
        // мартышка
        private void button9_Click(object sender, EventArgs e) {
            user = 8;
            win();
        }
        // попугай
        private void button10_Click(object sender, EventArgs e) {
            user = 7;
            win();
        }

        // start
        private void button7_Click(object sender, EventArgs e){
            flag = true;
        }
        // stop
        private void button8_Click(object sender, EventArgs e){
            flag = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e){
            username = textBox1.Text;
        }
    }
}
