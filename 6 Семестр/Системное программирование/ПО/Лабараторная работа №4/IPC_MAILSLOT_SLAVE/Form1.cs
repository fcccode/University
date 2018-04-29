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
        const int GENERIC_WRITE = 0x40000000;
        const int FILE_SHARE_WRITE = 0x00000002;
        const int OPEN_EXISTING = 3;
        #endregion

        #region Сигнатура методов

        /// <summary>
        /// Создание файла
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern IntPtr CreateFile(String lpFN, int dwDdAc, int dwShM, IntPtr lpSecAt, uint dwCDis, uint dwFlags, IntPtr hTempFile);

        /// <summary>
        /// Запись в файл
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern bool WriteFile(IntPtr handle, byte[] buffer, int count, ref int written, IntPtr lpOverlapped);

        /// <summary>
        /// Сброс буффера
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern bool FlushFileBuffers(IntPtr handle);

        /// <summary>
        /// Закрытие дескриптора
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern bool CloseHandle(IntPtr handle);
        
        #endregion

        #region Обработчик

        /// <summary>
        /// Обработчик нажатия кнопки
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string data = txtName.Text + "|" + txtAge.Text + "|" + 
                          txtCity.Text + "|" + txtPhone.Text + "|" + txtAuxiliary.Text;
            int size = data.Length;
            IntPtr hMail = CreateFile(@"\\.\mailslot\MyMailSlot",
                                    GENERIC_WRITE, FILE_SHARE_WRITE, 
                                    IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
            if (hMail == (IntPtr)(-1))            {
                MessageBox.Show("Ошибка при подключении.");
                return;
            }
            WriteFile(hMail, Encoding.Default.GetBytes(data), size, ref size, IntPtr.Zero);
            FlushFileBuffers(hMail);
            CloseHandle(hMail);
        }
        #endregion
    }
}
