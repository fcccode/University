using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent( );
        }

  
        private void CloseApplication()
        {
            Close( );
        }

        #region TASK №1


        RECT rect;  // структура

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(
                                              int uiAction,
                                              int uiParam,
                                              ref RECT pvParam,
                                              int fWinIni );


        private const Int32 SPI_GETWORKAREA = 48;


        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public Int32 Left;
            public Int32 Top;   // top is before right in the native struct
            public Int32 Right;
            public Int32 Bottom;
        }

        /// <summary>
        /// Кнопка определенния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefine_Click( object sender, EventArgs e )
        {
            bool result = SystemParametersInfo(SPI_GETWORKAREA,
                                   0,
                                   ref rect,
                                   0);
            lblBottom.Text = Convert.ToString(rect.Bottom);
            lblTop.Text = Convert.ToString(rect.Top);
            lblRigth.Text = Convert.ToString(rect.Right);
            lblLeft.Text = Convert.ToString(rect.Left);

            lblHeigth.Text = Convert.ToString(rect.Bottom);
            lblWidth.Text = Convert.ToString(rect.Right);
        }

        /// <summary>
        /// Кнопка завершения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntask1cnl_Click( object sender, EventArgs e )
        {
            CloseApplication( );
        }








        #endregion

        #region TASK №2
        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void button2_Click( object sender, EventArgs e )
        {

        }

        private void btntask2Close_Click( object sender, EventArgs e )
        {
            CloseApplication( );
        }
        #endregion

        #region TASK
        #endregion

        #region TASK
        #endregion

        #region TASK
        #endregion

        #region TASK
        #endregion

        #region TASK
        #endregion

        #region TASK
        #endregion


    }
}
