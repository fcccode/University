using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Tasks;

namespace WpfApp1
{
   

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object InputLanguage { get; private set; }

        public MainWindow()
        {
            InitializeComponent( );
            int CAPSLOCK = 20;
            int result = (int)GetKeyState(CAPSLOCK);
            if (result == 0x8000)
            {
                txtKey.Text = "Pressed";
            }
            else
           if (result == 1)
            {
                txtKey.Text = "Включена";
            }
            else
                txtKey.Text = "Выключена";

            RegisterHotKey(this.Handle, 0, 0, (int)Keys.PrintScreen);

        }

        public enum ModifierKey : uint
        {
            MOD_NULL = 0x0000,
            MOD_ALT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_SHIFT = 0x0004,
            MOD_WIN = 0x0008,
        }

        public enum HotKey
        {
            PrintScreen,
            ALT_PrintScreen,
            CONTROL_PrintScreen
        }


        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;

        private int mouse_coord_x = 100;
        private int mouse_coord_y = 100;

        [DllImport("user32", SetLastError = true)]
        static extern bool RegisterHotKey( IntPtr hWnd, int id, ModifierKey fsModifiers, Keys vk );

        [DllImport("user32")]
        static extern short GetKeyState( int key );

        [DllImport("Kernel32.dll")]
        static extern void GetSystemTime(SystemTime time);

        [DllImport("Kernel32.dll")]
        static extern void GetLocalTime( SystemTime time );

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(
                                              int uiAction,
                                              int uiParam,
                                              ref RECT pvParam,
                                              int fWinIni );


        [DllImport("Kernel32.dll")]
        static extern bool GetVolumeInformation(
                                                string path,
                                                StringBuilder buffer,
                                                int size,
                                                out uint serialNumber,
                                                out uint complength,
                                                out uint flags,
                                                StringBuilder fileBuffer,
                                                int nFileNamesize
                                                );

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
                                            IntPtr hwd,
                                            string operation,
                                            string file,
                                            string parametrs,
                                            string directory,
                                            int command
                                            );

        [DllImport("user32.dll")]
        static extern void mouse_event( uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo );


        [DllImport("user32.dll")]
        static extern IntPtr SendMessage( IntPtr hWnd, UInt32 msg, IntPtr wParam);

        [DllImport("user32.dll")]
        static extern bool DrawMenuBar( IntPtr hWnd );

        [DllImport("user32.dll")]
        static extern bool RemoveMenu( IntPtr hMenu, uint uPosition, uint uFlags );

        [DllImport("user32.dll")]
        static extern uint GetMenuItemCount( IntPtr hMenu );

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow( string lpszClass, string lpszWindow );

        [DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu( IntPtr hWnd, bool bRevert );

        [DllImport("user32")]
        static extern bool GetKeyboardLayoutName( StringBuilder str );

        [DllImport("user32.dll")]
        static extern bool EnumWindows( EnumWindowsProc lpEnumFunc, IntPtr lParam );

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop( IntPtr hWnd );
        private delegate bool EnumWindowsProc( IntPtr hWnd, IntPtr lParam );


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowThreadProcessId( IntPtr hWnd, out int id );


        [DllImport("user32")]
        static extern bool ExitWindowsEx( uint flag, uint reason );


        [DllImport("user32.dll")]
        static extern IntPtr SendMessage( IntPtr hWnd, uint Msg, int wParam, int lParam );


        private bool EnumWindowsProcCallBack( IntPtr hWnd, IntPtr lParam )
        {


            StringBuilder str = new StringBuilder( );
            int size;
            GetWindowThreadProcessId(hWnd, out size);
            txtConsole.Text += "PID" + Convert.ToString(size);
            txtConsole.Text += Environment.NewLine;
            return true;
        }
        string
        /// <summary>
        /// Обработчик клавиши определения системного времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSysTime_Click( object sender, RoutedEventArgs e )
        {
            SystemTime time = new SystemTime( );
            GetSystemTime(time);
            txtHour.Text = Convert.ToString(time.hour);
            txtMinutes.Text = Convert.ToString(time.minute);
        }

        /// <summary>
        /// Обработчик клавиши определение локального времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalTime_Click( object sender, RoutedEventArgs e )
        {
            SystemTime time = new SystemTime( );
            GetLocalTime(time);
            txtHour.Text = Convert.ToString(time.hour);
            txtMinutes.Text = Convert.ToString(time.minute);
        }

        /// <summary>
        /// Определить размеры окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefineSize_Click( object sender, RoutedEventArgs e )
        {
            const Int32 SPI_GETWORKAREA = 48;
            RECT rect = new RECT( );
            bool result = SystemParametersInfo(SPI_GETWORKAREA,
                                  0,
                                  ref rect,
                                  0);
            if(result)
            {
                txtWidth.Text = Convert.ToString(rect.Right - rect.Left);
                txtHeigth.Text = Convert.ToString(rect.Bottom - rect.Top);
            }

        }

        /// <summary>
        /// Определение серийный номер диска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefineSerialNumber_Click( object sender, RoutedEventArgs e )
        {
            StringBuilder buffer = new StringBuilder( );
            uint serialNumber;
            uint complength;
            uint flag;
            int _size = 200;
            StringBuilder fileBuffer = new StringBuilder( );
            int size = 256;
            if (GetVolumeInformation(null, buffer, _size, out serialNumber, out complength, out flag, fileBuffer, size))
            {
                txtSerialNumber.Text = Convert.ToString(serialNumber);
            }
        }

        /// <summary>
        /// Shell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click( object sender, RoutedEventArgs e )
        {
            string path = txtPath.Text;
            if (path != "" )
            {
                try
                {
                    int result = (int)ShellExecute((IntPtr)0, "explore", path, null, null, 5);
                    if (result < 32)
                    {
                        MessageBox.Show("Не корректные параметры");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите путь");
            }
            
        }

        /// <summary>
        /// Получение списка активных процессов в Windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPid_Click( object sender, RoutedEventArgs e )
        {
            if (EnumWindows(EnumWindowsProcCallBack, (IntPtr)0))
            {
                MessageBox.Show("Список процессов получен");
            }
            else
            {
                MessageBox.Show("Не удачное завершение получение PID");
            }
        }

        /// <summary>
        /// Активирование процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActivate_Click( object sender, RoutedEventArgs e )
        {
            if (txtPid.Text != "")
            {
                try
                {
                    int id = int.Parse(txtPid.Text);
                    BringWindowToTop((IntPtr)id);
                    MessageBox.Show( "Окно активировано");
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите PID");
            }
        }

        /// <summary>
        /// Перезагрузка PC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click( object sender, RoutedEventArgs e )
        {
            UInt32 reason = 0x00002000;
            UInt32 command = 0x00000040;

            try
            {
                bool result = ExitWindowsEx(command, reason);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
           
            
        }

        /// <summary>
        ///  Определение раскладки клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGrid_KeyDown( object sender, System.Windows.Input.KeyEventArgs e )
        {
            StringBuilder str = new StringBuilder( );

            if (GetKeyboardLayoutName(str))
            {
                int result = int.Parse(str.ToString( ));

                if (result == 409)
                {
                    txtLang.Text = "ENG";
                }
                else
                {
                    txtLang.Text = "RUS";
                }
            }

            if (e.Key != Key.Up)
            {
                mouse_coord_y += 5;
                mouse_event(MOUSEEVENTF_MOVE, mouse_coord_x, mouse_coord_y, 0, 0);
            }

            if (e.Key == Key.Down)
            {
                mouse_coord_y -= 5;
                mouse_event(MOUSEEVENTF_MOVE, mouse_coord_x, mouse_coord_y, 0, 0);
            }

            if (e.Key == Key.Left)
            {
                mouse_coord_x -= 5;
                mouse_event(MOUSEEVENTF_MOVE, mouse_coord_x, mouse_coord_y, 0, 0);
            }

            if (e.Key == Key.Right)
            {
                mouse_coord_y += 5;
                mouse_event(MOUSEEVENTF_MOVE, mouse_coord_x, mouse_coord_y, 0, 0);
            }

        }

        /// <summary>
        /// Отключение меню окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnSwitchOff_Click( object sender, RoutedEventArgs e )
        {

            IntPtr hWnd = FindWindow(null, txtClassName.Text);
            UInt32 MF_BYPOSITION = 0x00000400;
            UInt32 MF_DISABLED = 0x00000002;
            if (hWnd == IntPtr.Zero)
            {
                MessageBox.Show("Окно не найдено");
                return;
            }
            IntPtr hMenu = GetSystemMenu(hWnd, false);
            uint n;
            if (hMenu != IntPtr.Zero)
            {
                if ((n = GetMenuItemCount(hMenu)) > 0)
                {
                    RemoveMenu(hMenu, n - 1, MF_BYPOSITION | MF_DISABLED);
                    RemoveMenu(hMenu, n - 2, MF_BYPOSITION | MF_DISABLED);
                    DrawMenuBar(hWnd);
                    MessageBox.Show("Команда выполнена");

                }
            }
            else
            {
                MessageBox.Show("Команда не  выполнена");
            }

        }

        /// <summary>
        /// Включение монитора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnMonitorOn_Click( object sender, RoutedEventArgs e )
        {
            IntPtr windowHandle = Process.GetCurrentProcess( ).MainWindowHandle;
            const int SC_MONITORPOWER = 0xF170;
            const int WM_STSCOMMAND = 0x0112;
            const int MONITOR_ON = -1;
            SendMessage(windowHandle, WM_STSCOMMAND, SC_MONITORPOWER, MONITOR_ON);
        }

        /// <summary>
        /// Выключение монитора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitorOff_Click( object sender, RoutedEventArgs e )
        {
            IntPtr windowHandle = Process.GetCurrentProcess( ).MainWindowHandle;
            const int SC_MONITORPOWER = 0xF170;
            const int WM_STSCOMMAND = 0x0112;
            const int MONITOR_OFF = 2;
            SendMessage(windowHandle, WM_STSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }

        /// <summary>
        /// Закрытие окна другого пз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseWindow_Click( object sender, RoutedEventArgs e )
        {
            IntPtr windowHandle = Process.GetCurrentProcess( ).MainWindowHandle;
            const int WM_CLOSE = 0x0010;
            SendMessage(windowHandle, WM_CLOSE,0 , 0);
        }


        /// <summary>
        /// Имитация нажатия левой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeftMouseKey_Click( object sender, RoutedEventArgs e )
        {

        }

        /// <summary>
        /// Имитация нажатия правой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRigthMouseKey_Click( object sender, RoutedEventArgs e )
        {

        }

        private void MainGrid_KeyDown_1( object sender, KeyEventArgs e )
        {


        }

        private void btnGetOtherWinTime_Click( object sender, RoutedEventArgs e )
        {
            IntPtr windowHandle = Process.GetCurrentProcess( ).MainWindowHandle;
            const int WM_TIMECHANGE = 0x001E;
            SendMessage(windowHandle, WM_TIMECHANGE, 0, 0);
        }




    }
}
