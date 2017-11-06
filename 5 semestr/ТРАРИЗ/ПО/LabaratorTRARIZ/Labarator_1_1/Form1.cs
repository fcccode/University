using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Labarator_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studentList = new List<Student>();
            
           
            txtStudentListCount.Text = Convert.ToString(studentList.Count);
        }

        List<Student> studentList;
        private int counter = 0;

        #region Методы

        private bool CompareStudentValue(Student student, int min)
        {

            if (
                student.IpzValue <= min ||
                student.SpValue <= min ||
                student.TrarizValue <= min ||
                student.OetValue <= min ||
                student.PvsValue <= min
                )
                return true;

                return false;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPvs.Clear();
            txtIpz.Clear();
            txtSp.Clear();
            txtTrariz.Clear();
            txtOet.Clear();
        }
        #endregion

        #region  Кнопки

        /// <summary>
        /// Кнопка сохранения значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML-File | *.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {



                    XElement xmlList = new XElement("Root",
                                           from student in studentList
                                           select
                    new XElement("Student",
                    new XElement("Name", student.Name),
                    new XElement("Surname", student.Surname),
                    new XElement("IpzValue", student.IpzValue),
                    new XElement("SpValue", student.SpValue),
                    new XElement("PvsValue", student.PvsValue),
                    new XElement("TrarizValue", student.TrarizValue),
                    new XElement("OetValue", student.OetValue)
                   ));

                    xmlList.Save(saveFileDialog.FileName);
                }
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        /// <summary>
        /// Кнопка очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, System.EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, System.EventArgs e)
        {
            counter = 0;
            if (string.IsNullOrEmpty(txtMinValue.Text))
                MessageBox.Show("Введите оценку ");
            else
            {
                foreach (Student student in studentList)
                {
                    if (CompareStudentValue(student, int.Parse(txtMinValue.Text)))
                        counter++;
                }

                txtResult.Text = Convert.ToString(counter);
            }
        }

        /// <summary>
        /// Обработчик закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление студента в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrEmpty(txtName.Text) ||
               string.IsNullOrEmpty(txtSurname.Text) ||
               string.IsNullOrEmpty(txtPvs.Text) ||
               string.IsNullOrEmpty(txtIpz.Text) ||
               string.IsNullOrEmpty(txtSp.Text) ||
               string.IsNullOrEmpty(txtTrariz.Text) ||
               string.IsNullOrEmpty(txtOet.Text)
             )
                MessageBox.Show("Введите значения");
            else
            {
                try
                {
                    studentList.Add(new Student(
                                                txtName.Text,
                                                txtSurname.Text,
                                                int.Parse(txtPvs.Text),
                                                int.Parse(txtIpz.Text),
                                                int.Parse(txtTrariz.Text),
                                                int.Parse(txtSp.Text),
                                                int.Parse(txtOet.Text)
                                                ));

                    txtStudentListCount.Text = Convert.ToString(studentList.Count);
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        #endregion

        #region Обработчики нажатия

        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPvs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49) && (number > 53)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIpz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49 || number > 53)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49 || number > 53)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49 || number > 53)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTrariz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49 || number > 53)))
            {
                e.Handled = true;
            }
        }

        
        /// <summary>
        /// Обработчик вводимых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLowLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) || (number < 49 || number > 53)))
            {
                e.Handled = true;
            }
        }



        #endregion

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "xml|*.xml|all files|*.*";
                DialogResult res = openFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {

                    XDocument xdoc = XDocument.Load(openFileDialog.FileName);
                    studentList = (from lv1 in xdoc.Descendants("Student")
                                          select new Student
                                          {
                                              Name = lv1.Element("Name").Value,
                                              Surname = lv1.Element("Surname").Value,
                                              PvsValue = int.Parse(lv1.Element("PvsValue").Value),
                                              IpzValue = int.Parse(lv1.Element("IpzValue").Value),
                                              OetValue = int.Parse(lv1.Element("OetValue").Value),
                                              TrarizValue = int.Parse(lv1.Element("TrarizValue").Value),
                                              SpValue = int.Parse(lv1.Element("SpValue").Value)
                                          }).ToList();

                    txtStudentListCount.Text = Convert.ToString(studentList.Count);
                }
            }
            catch
            {
                MessageBox.Show("invalid input");
            }
        }
    }
}
