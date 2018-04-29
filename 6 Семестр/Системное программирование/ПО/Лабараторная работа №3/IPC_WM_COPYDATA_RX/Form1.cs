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
        /// Обработчик окна WinApi
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_COPYDATA)
            { 
                var copydata = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
                string msg = Marshal.PtrToStringAnsi(copydata.lpData, copydata.cbData);
                textBox1.Text = msg.Split('|')[0];
                richTextBox1.Text = msg.Split('|')[1];
            }
            base.WndProc(ref m);
        }
        #endregion      
    }
}
