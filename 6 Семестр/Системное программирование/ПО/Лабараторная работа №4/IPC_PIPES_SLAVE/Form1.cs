using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


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
        static extern IntPtr CreateFile(String lp,int dwD,int dwS,IntPtr lpS,uint dwC,uint dwF, IntPtr hT);

        /// <summary>
        /// Запись в файл
        /// </summary>
        [DllImport("Kernel32.dll")]
        static extern bool WriteFile(IntPtr h, byte[] b, int c, ref int w, IntPtr lpOv);

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
        private void btnSend_Click(object sender, EventArgs e){
            
            string data = txtName.Text + "|" + txtAge.Text + "|" + txtCity.Text + "|" +
                          txtPhone.Text + "|" + txtAuxiliary.Text;
            int size = data.Length;
            IntPtr hPipe = CreateFile(@"\\.\pipe\ThePipe", 
                                GENERIC_WRITE, FILE_SHARE_WRITE, 
                                IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
            if (hPipe == (IntPtr)(-1)){
                MessageBox.Show("Ошибка при подключении.");
                return;
            }

            WriteFile(hPipe, Encoding.Default.GetBytes(data), size, ref size, IntPtr.Zero);
            FlushFileBuffers(hPipe);
            CloseHandle(hPipe);
        }
        #endregion

    }
}
