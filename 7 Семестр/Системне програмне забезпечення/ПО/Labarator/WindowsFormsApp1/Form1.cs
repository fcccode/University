using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MAXHEXH = (Convert.ToInt32('z') * 13 << 1)
                    + (Convert.ToInt32('z') * 13 << 5)
                    + (Convert.ToInt32('z') * 13 << 4);

        }

        public string[] tableNames = {"main", "void", "private", "public", "class",
                                      "{", "}", "(", ")", "!", "?", "#", "%", "*", "&",";",":",
                                      "+", "-", "/", "=",
                                      "int", "string", "double", "char",
                                       "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        // подсчитываем максимальное значение хэш функции
        public int MAXHEXH;

        public class IDentifier
        {
            public decimal heshResult = -1;    // Результат хэш функции
            public int pointer = -1;           // Указатель в списке
            public string variable = null;     // Имя идентификатора
            public string type = null;         // Тип идентификатора

            public IDentifier(decimal hesh, string s, string type)
            {
                this.heshResult = hesh;
                this.variable = s;
                this.type = type;
            }
        }
        // таблица идентификаторов для первого задания
        public List<IDentifier> tableTaskOne = new List<IDentifier>();

        // таблица идентификаторов для второго задания
        public List<IDentifier> tableTaskTwo = new List<IDentifier>();


        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //textBox1.Text = ((FileStream)myStream).Name;
                            string t  = ((FileStream)myStream).Name;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original Error: " + ex.Message);
                }
            }
        }


        private void CreateTableFirst_Click(object sender, EventArgs e)
        {
           //  string test = textBox1.TextBox1;
             string test;
            if (test != "")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(test))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            taskOne(parse(line));
                        }
                       // lTableFirst.Text = "Done";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            string text = "";
            for (int i = 0; i < tableTaskOne.Count; i++)
            {
                text += "Name:" + tableTaskOne[i].variable + " | " + "type:" + tableTaskOne[i].type + " | " + "hash:" + tableTaskOne[i].heshResult + Environment.NewLine;
            }
            //textBox4.Text = text;

        }


        private string parse(string line)
        {
            // ищем и удаляем то что в массиве и списке (да, это можно оптимизировать, но не сейчас)
            for (int i = 0; i < tableNames.Length; i++)
            {
                if (line.Contains(tableNames[i]))
                {
                    line = line.Replace(tableNames[i], "");
                }
            }

            for (int i = 0; i < tableTaskOne.Count; i++)
            {
                if (line.Contains(tableTaskOne.ElementAt(i).variable))
                {
                    line = line.Replace(tableTaskOne.ElementAt(i).variable, "");
                }
            }

            // удаляем пробелы в начале строки, а если строка была только из них
            // то возвращаем null - элемент не добавляется
            line = spaceClear(line);
            if (line != "")
            {
                return line;
            }
            return null;
        }


        private void taskOne(string line)
        {
            if (line == null) return;
            string buffer = "";
            do
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line.ElementAt(i) != ' ')
                    {
                        buffer += line.ElementAt(i);
                    }
                    else
                    {
                        break;
                    }
                }
                // добавляет новый элемент
                tableTaskOne.Add(new IDentifier(hashCode(buffer), buffer, null));
                // удаляем из строки то что только что добавили
                line = line.Replace(buffer, "");
                if (line != "")
                {
                    line = spaceClear(line);
                }
                buffer = "";
            }
            while (line != "");
        }

        // первое хеширование
        private decimal hashCode(string buffer)
        {
            decimal hash = Convert.ToInt32(buffer.ElementAt(0)) * 73837 << 1                /*Первая цифра номера в списке*/
                 + Convert.ToInt32(buffer.ElementAt((buffer.Length - 1) / 2) * 73837 << 5     /*Сумма цифр номера в списке*/
                 + Convert.ToInt32(buffer.ElementAt(buffer.Length - 1)) * 73837 << 4);       /*Последняя цифра номера в списке*/

            // проверка на то занят ли хэш код. если да то рехешируем, нет - отправляем наверх
            foreach (IDentifier c in tableTaskOne)
            {
                if (c.heshResult == hash)
                {
                    hash = reHachCode(hash);
                }
            }
            return hash;
        }

        private decimal reHachCode(decimal hash)
        {
            decimal h_i;
            Random rand = new Random();
            h_i = (hash + rand.Next(0, MAXHEXH)) % MAXHEXH;
            // смотрим занято ли то, что у нас получилось
            foreach (IDentifier c in tableTaskOne)
            {
                if (c.heshResult == h_i)
                {
                    h_i = reHachCode(h_i);
                }
            }
            return h_i;
        }

        // Удаляет пробелы в начале строки
        private string spaceClear(string line)
        {
            try
            {
                do
                    if (line.ElementAt(0) == ' ')
                    {
                        line = line.TrimStart(' ');
                    }
                while (line.ElementAt(0) == ' ');

                return line;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return line;
            }
        }

    }
}
