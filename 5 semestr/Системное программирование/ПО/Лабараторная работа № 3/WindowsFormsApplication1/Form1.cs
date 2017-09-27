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

        delegate bool EnumWindowsCB( int hwnd, int lparam );

        [DllImport("user32")]
        private static extern int EnumWindows( EnumWindowsCB cb, int lparam );

        // В вашем классе
        public static bool CallBackFunction( int hwnd, int lparam )
        {
           
            return true;
        }

        private void button1_Click( object sender, EventArgs e )
        {
           
            if(EnumWindows(CallBackFunction, null))
            
        }

        private void button2_Click( object sender, EventArgs e )
        {
           
        }


        private void btntask2Close_Click( object sender, EventArgs e )
        {
            CloseApplication( );
        }

        #endregion

        #region TASK №3

        [DllImport("Kernel32.dll")]
        public static extern void GetSystemTime( SystemTime st );

        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime( SystemTime st );

        private SystemTime sysTime;
        private SystemTime localTime;

        private void btnSystime_Click( object sender, EventArgs e )
        {
            sysTime = new SystemTime( );
            GetSystemTime(sysTime);
            txtSystime.Text = Convert.ToString( sysTime.hour);
            txtLocalTime.Text = Convert.ToString(sysTime.minute );
        }

        private void btnLocalTime_Click( object sender, EventArgs e )
        {
            localTime = new SystemTime( );
            GetLocalTime(localTime);
            txtSystime.Text = Convert.ToString(localTime.hour );
            txtLocalTime.Text = Convert.ToString( localTime.minute);
        }

        private void btntask3Close_Click( object sender, EventArgs e )
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


    }
    [StructLayout(LayoutKind.Sequential)]
    public class SystemTime
    {
        public ushort year;
        public ushort month;
        public ushort weekday;
        public ushort day;
        public ushort hour;
        public ushort minute;
        public ushort second;
        public ushort millisecond;
    }
}
