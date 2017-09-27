using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Labarator_2
{
    public partial class Form1 : Form
    {
        #region Контруктор

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Form1()
        {
            InitializeComponent( );
            InitFont( );
        }

        #endregion

        #region  Переменные

        string FileName = string.Empty;

        #endregion

        #region  Кнопки

        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void открытьCtrlOToolStripMenuItem_Click( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog( );
            if (openFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;

                StreamReader str = new StreamReader(FileName);
                txtEditor.Text = str.ReadToEnd( );
                str.Close( );
                lblFileName.Text = FileName;
                lblFileName.Visible = true;
                lblSymCount.Text = Convert.ToString(txtEditor.Text.Length + 1);
                lblSymCount.Visible = true;
            }

        }
        
        /// <summary>
        /// Закрытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void закрытьCtrlWToolStripMenuItem_Click( object sender, EventArgs e )
        {
            // перед закрытиев приложения справшиваем пользователя сохранить ли документ
            var result = MessageBox.Show("Сохранить документ ?", "Сохранено", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // если результат положительный
            if (result != DialogResult.OK)
                SaveFile( );
            
            Close( );

        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьCtrlSToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SaveFile( );
        }
        

        /// <summary>
        /// Поиск слова в тексте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click_1( object sender, EventArgs e )
        {
            // текст полученые с редактора
            string text = txtEditor.Text; 
            // слово которое необходимо найти              
            string find_word = txtWord.Text;
            // количество найденных слов
            int iterator = 0;
            // если текстовый редактор не пуст
            if (!string.IsNullOrEmpty(text))
            {
                // и пользователь ввел слово
                if (!string.IsNullOrEmpty(find_word))
                {
                    // получаем массив все слов в редакторе
                    string[] str = text.Split(new Char[] { ' ' });
                    //проход по массиву
                    for (int i = 0; i < str.Length; i++)
                        // если нашли совпадение
                        if (String.Compare(str[i], find_word) == 0)
                            // увеличиваем итератор показателя слов
                            iterator++;
                    // после прохода проверяем нашли ли мы совпадения                    
                    if (iterator > 0)
                    {
                        string message = "Найдено " + Convert.ToString(iterator) + " совпадений";
                        MessageBox.Show(message);
                    }
                    else
                        MessageBox.Show("Совпадений не найдено");

                }
                else
                    MessageBox.Show("Введите слово для поиска");

            }
            else
                MessageBox.Show("Страница пустая");



        }

        /// <summary>
        /// О разработчике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form2 form = new Form2( );
            form.Show( );
        }

        #endregion

        #region  События

        /// <summary>
        /// Подсчет введенных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEditor_KeyPress( object sender, KeyPressEventArgs e )
        {
            lblSymCount.Text = Convert.ToString(txtEditor.Text.Length + 1);
            lblSymCount.Visible = true;
        }

        /// <summary>
        /// Выбор шрифта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFont_SelectedValueChanged( object sender, EventArgs e )
        {
            string str = cmbKegle.Text;
            if (str != "")
            {
                int size = int.Parse(str);
                txtEditor.Font = new Font(cmbFont.Text, (float)size);
            }
            else
                txtEditor.Font = new Font(cmbFont.Text, txtEditor.Font.Size);

        }

        /// <summary>
        /// Выбор размера шрифта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKegle_SelectedValueChanged( object sender, EventArgs e )
        {
            txtEditor.Font = new Font(cmbFont.Text, (float)Convert.ToInt32(cmbKegle.Text));
        }


        #endregion

        #region  Внутренее преобразование

        /// <summary>
        /// Инициализация шрифтов
        /// </summary>
        private void InitFont()
        {
            // отображаем все установленные на машине шрифты
            foreach (FontFamily oneFontFamily in FontFamily.Families)
                cmbFont.Items.Add(oneFontFamily.Name);
            
            // по умолчанию устанавливаем вторые элементы списка
            cmbFont.SelectedIndex = 1;
            cmbKegle.SelectedIndex = 1;
        }

        /// <summary>
        /// Сохранение документа данная сигнатура используется в нескольких местаъ
        /// для оптимизации и читабельности кода данная инструкция выведена в отдельную функцию
        /// </summary>
        private void SaveFile()
        {
            // диалог сохранения 
            SaveFileDialog saveFileDialog = new SaveFileDialog( );
            // указываем расширения для сохраняемых файлов
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // если все успешно
            if (saveFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                // получаем имя которое выбрал пользователь
                string name = saveFileDialog.FileName;
                try
                {
                    // открываем поток чтения
                    StreamWriter streamWriter = new StreamWriter(name);
                    // формальное представление текта
                    string allData = txtEditor.Text;
                    // записываем в файл
                    streamWriter.WriteLine(allData);
                    // закрываем поток
                    streamWriter.Close( );
                }
                catch { }
                // запрещаем отображение параметров файла который уже сохранен
                lblSymCount.Visible = false;
                lblFileName.Visible = false;
            }
        }
        #endregion
    }
}
