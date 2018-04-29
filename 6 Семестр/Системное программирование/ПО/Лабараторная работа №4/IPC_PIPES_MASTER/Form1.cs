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
        const uint PIPE_ACCESS_DUPLEX = 0x00000003;
        #endregion

        #region Сигнатура методов

        /// <summary>
        /// Создание
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern IntPtr CreateNamedPipe(String т, uint dw, uint dwP, uint nMax,uint nOut, uint nIn, uint nDef, IntPtr pSec);

        /// <summary>
        /// Подключение
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool ConnectNamedPipe(IntPtr hHandle, IntPtr lpOverlapped);

        /// <summary>
        /// ОТключение
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool DisconnectNamedPipe(IntPtr hHandle);

        /// <summary>
        /// Считывание файла
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool ReadFile(IntPtr handle, byte[] buffer, uint toRead, ref uint read, IntPtr lpOverLapped);

        /// <summary>
        /// Обновление буффера
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool FlushFileBuffers(IntPtr handle);

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
        { 
            uint size = 1024;
            IntPtr hPipe = CreateNamedPipe(@"\\.\pipe\ThePipe", 
                                           PIPE_ACCESS_DUPLEX, 0, 1, size, 
                                           size, 100, IntPtr.Zero);

            if (hPipe == IntPtr.Zero){
                MessageBox.Show("Ошибка при создании канала.");
                return;
            }
            if (!ConnectNamedPipe(hPipe, IntPtr.Zero)){
                MessageBox.Show("Ошибка при открытии канала.");
                return;
            }
            byte[] buffer = new byte[size];
            ReadFile(hPipe, buffer, size, ref size, IntPtr.Zero);
            string data = Encoding.Default.GetString(buffer);
            txtName.Text = data.Split('|')[0];
            txtAge.Text = data.Split('|')[1];
            txtCity.Text = data.Split('|')[2];
            txtPhone.Text = data.Split('|')[3];
            txtAuxiliary.Text = data.Split('|')[4];
            FlushFileBuffers(hPipe);
            DisconnectNamedPipe(hPipe);
            CloseHandle(hPipe);
        }
        #endregion

    }
}
