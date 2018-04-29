using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Labarator_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Константы
        const int WM_COPYDATA = 0x004A;
        #endregion

        #region Сигнатура методов

        /// <summary>
        /// Найти дескриптор окна по имени
        /// </summary>
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// Передача сообщения
        /// </summary>
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        #endregion

        #region Структура
        /// <summary>
        /// Содержит данные, которые должны быть переданы другому приложению сообщением WM_COPYDATA .
        /// </summary>
        struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }
        #endregion

        #region Обработчик

        /// <summary>
        /// Обработчик нажатия кнопки отпраки сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                IntPtr hWnd = FindWindow(null, "Получатель");
                if (hWnd != IntPtr.Zero)
                { 
                    string msg = new string((txtName.Text + "|" + rtxtChat.Text).ToCharArray());
                    IntPtr hMsg = Marshal.StringToHGlobalAnsi(msg);
                    COPYDATASTRUCT copydata = new COPYDATASTRUCT();
                    copydata.dwData = IntPtr.Zero;
                    copydata.cbData = msg.Length * sizeof(char) + 1;
                    copydata.lpData = hMsg;
                    IntPtr hStruct = Marshal.AllocHGlobal(Marshal.SizeOf(copydata));
                    Marshal.StructureToPtr(copydata, hStruct, true);
                    SendMessage(hWnd, WM_COPYDATA, IntPtr.Zero, hStruct);
                    Marshal.FreeHGlobal(hStruct);
                    Marshal.FreeHGlobal(hMsg);
                }
                else MessageBox.Show("Получатель не найден.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
