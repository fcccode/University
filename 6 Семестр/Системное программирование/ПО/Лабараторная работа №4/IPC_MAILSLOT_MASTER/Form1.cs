using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Labarator_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Константы 
        const int MAILSLOT_WAIT_FOREVER = -1;
        #endregion

        #region Сигнатура методов

        /// <summary>
        /// Создание
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern IntPtr CreateMailslot(string name,uint nMax,int time, IntPtr lpSec);

        /// <summary>
        /// Считывание файла
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool ReadFile(IntPtr handle,byte[] buffer,uint toRead,ref uint read,IntPtr lpOver);

        /// <summary>
        /// Закрытие дескриптора
        /// </summary>
        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);
        #endregion

        #region Обработчик

        /// <summary>
        /// Обработчик нажатия кнопки
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        { // создание ящика и чтение сообщения
            uint size = 1024;
            IntPtr hMail = CreateMailslot(@"\\.\mailslot\MyMailSlot", 0, 
                          MAILSLOT_WAIT_FOREVER, IntPtr.Zero);
            if (hMail == (IntPtr)(-1)){
                MessageBox.Show("Ошибка при создании ящика.");
                return;
            }
            byte[] buffer = new byte[size];
            ReadFile(hMail, buffer, size, ref size, IntPtr.Zero);
            string data = Encoding.Default.GetString(buffer);
            txtName.Text = data.Split('|')[0];
            txtAge.Text = data.Split('|')[1];
            txtCity.Text = data.Split('|')[2];
            txtPhone.Text = data.Split('|')[3];
            txtAuxiliary.Text = data.Split('|')[4];
            CloseHandle(hMail);
        }
        #endregion
    }
}
