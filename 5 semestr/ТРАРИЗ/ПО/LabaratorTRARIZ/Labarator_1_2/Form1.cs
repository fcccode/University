using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LiverList = new List<Liver>();
        }

        /// <summary>
        /// Список жителей
        /// </summary>
        private List<Liver> LiverList { get;  set; }


       

        /// <summary>
        /// Проверка введены ли данные
        /// </summary>
        /// <returns></returns>
        private bool IsFieldsFill()
        {
            if (string.IsNullOrEmpty(txtbBDay.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Удаление данных
        /// </summary>
        private void ClearData()
        {
            txtbBDay.Clear();
            txtName.Clear();
            txtSurname.Clear();
        }

        /// <summary>
        /// Поиск в списке
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Surname"></param>
        private Liver FindLiver(string Name, string Surname)
        {
            foreach (Liver liver in LiverList)
            {
                if (liver.Name == Name && liver.Surname == Surname)
                    return liver;
            }

            return null;
        }

        /// <summary>
        /// Кнопка добавления нового жителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblFindResult.Visible = false;
            if (IsFieldsFill())
                LiverList.Add(new Liver(txtName.Text, txtSurname.Text, int.Parse(txtbBDay.Text)));

            ClearData();
        }

        /// <summary>
        /// Кнопка удаления жителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblFindResult.Visible = false;
            if (IsFieldsFill())
                LiverList.Remove(FindLiver(txtName.Text, txtSurname.Text));

            ClearData();
        }

        /// <summary>
        /// Поиск жителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            lblFindResult.Visible = false;
            if (FindLiver(txtName.Text, txtSurname.Text) == null)
                lblFindResult.Text = "Такого жителя нет";
            else
            {
                int index = LiverList.IndexOf(FindLiver(txtName.Text, txtSurname.Text));
                lblFindResult.Text = "Житель под индексом {index}";
            }

            lblFindResult.Visible = true;
            
        }

        /// <summary>
        /// Пересчет списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblFindResult.Visible = false;
            txtConsole.Clear();
            txtResult.Text = Convert.ToString(DisplayList());
        }


        private int DisplayList()
        {

            string format = "{0,5}{1,15}{2,30}{3,35}";
            txtConsole.Text += String.Format(format, "#", "Name", "Surname", "BirthDay");

            int counter = 0;

            foreach(Liver liver in LiverList)
            {
                counter++;
                txtConsole.Text += Environment.NewLine;
                txtConsole.Text += String.Format(format, counter, liver.Name, liver.Surname, liver.BDay);  
            }

            return counter;
        }

        /// <summary>
        /// Очистить консоль и поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
            txtConsole.Clear();
        }
    }
}
