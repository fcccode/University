using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Labarator_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Переменные

        private IntPtr hMMF = IntPtr.Zero;
        private FileStream fs;
        public uint AllocationGranularity;
        #endregion

        #region Сигнатура методов

        /// <summary>
        /// Создает или открывает именованный или неназванный объект сопоставления файлов для указанного файла
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern IntPtr CreateFileMapping(IntPtr hFile, IntPtr lpAttributes, FileMapProtection flProtect, Int32 dwMaxSizeHi, Int32 dwMaxSizeLow, string lpName);

        /// <summary>
        /// Открывает именованный объект сопоставления файлов.
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern IntPtr OpenFileMapping(FileMapAccess DesiredAccess, bool bInheritHandle, string lpName);

        /// <summary>
        /// Отображает вид сопоставления файлов в адресное пространство вызывающего процесса.
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern IntPtr MapViewOfFile(IntPtr hFileMapping, FileMapAccess dwDesiredAccess, Int32 dwFileOffsetHigh, Int32 dwFileOffsetLow, Int32 dwNumberOfBytesToMap);

        /// <summary>
        /// Отключает сопоставленный вид файла из адресного пространства вызывающего процесса.
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);

        /// <summary>
        /// Записывает на диск диапазон байтов внутри отображаемого вида файла.
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern bool FlushViewOfFile(IntPtr lpBaseAddress, Int32 dwNumberOfBytesToFlush);

        /// <summary>
        /// Получает информацию о текущей системе.
        /// </summary>
        [DllImport("Kernel32.dll")]
        private static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);
        #endregion

        #region Структура и Перечисления

        /// <summary>
        /// Перечисление защиты
        /// </summary>
        public enum FileMapProtection : uint
        {
            PageReadonly = 0x02,
            PageReadWrite = 0x04,
            PageWriteCopy = 0x08,
            PageExecuteRead = 0x20,
            PageExecuteReadWrite = 0x40,
            SectionCommit = 0x8000000,
            SectionImage = 0x1000000,
            SectionNoCache = 0x10000000,
            SectionReserve = 0x4000000,
        }

        /// <summary>
        /// Перечисление прав доступа
        /// </summary>
        public enum FileMapAccess : uint
        {
            FileMapCopy = 0x0001,
            FileMapWrite = 0x0002,
            FileMapRead = 0x0004,
            FileMapAllAccess = 0x001f,
            fileMapExecute = 0x0020,
        }

        /// <summary>
        /// Информация о текущей системе
        /// </summary>
        public struct SYSTEM_INFO
        {
            internal _PROCESSOR_INFO_UNION uProcessorInfo;
            public uint dwPageSize;
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public IntPtr dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort dwProcessorLevel;
            public ushort dwProcessorRevision;
        }

        /// <summary>
        /// 
        /// </summary>
        public struct _PROCESSOR_INFO_UNION
        {
            internal uint dwOemId;
            internal ushort wProcessorArchitecture;
            internal ushort wReserved;
        }
        #endregion

        #region Методы

        /// <summary>
        /// Создает или открывает именованный или неназванный объект сопоставления файлов для указанного файла
        /// </summary>
        public static IntPtr CreateFileMapping(System.IO.FileStream File, FileMapProtection flProtect, Int64 ddMaxSize, string lpName)
        {
            int Hi = (Int32)(ddMaxSize / Int32.MaxValue);
            int Lo = (Int32)(ddMaxSize % Int32.MaxValue);
            return CreateFileMapping(File.SafeFileHandle.DangerousGetHandle(), IntPtr.Zero, flProtect, Hi, Lo, lpName);
        }

        /// <summary>
        /// Отображает вид сопоставления файлов в адресное пространство вызывающего процесса.
        /// </summary>
        public static IntPtr MapViewOfFile(IntPtr hFileMapping, FileMapAccess dwDesiredAccess, Int64 ddFileOffset, Int32 dwNumberOfBytesToMap)
        {
            int Hi = (Int32)(ddFileOffset / Int32.MaxValue);
            int Lo = (Int32)(ddFileOffset % Int32.MaxValue);
            return MapViewOfFile(hFileMapping, dwDesiredAccess, Hi, Lo, dwNumberOfBytesToMap);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CMemoryMappedFile(string FileName, string Name)
        { // создание или открытие отраженного файла
            hMMF = OpenFileMapping(FileMapAccess.FileMapAllAccess, false, Name);
            if (hMMF == IntPtr.Zero)
            {
                fs = File.Open(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                hMMF = CreateFileMapping(fs, FileMapProtection.PageReadWrite, Int64.MaxValue, Name);
                if (hMMF == IntPtr.Zero)
                {
                    MessageBox.Show("Не удалось отразить в память файл.");
                    return;
                }
            }
            SYSTEM_INFO sysinfo = new SYSTEM_INFO();
            GetSystemInfo(ref sysinfo);
            AllocationGranularity = sysinfo.dwAllocationGranularity;
        }

        unsafe public int Read(byte[] Buffer, int BytesToRead, Int64 AtOffset)
        { // чтение из отраженного файла
            IntPtr hMVF = IntPtr.Zero;
            try
            {
                Int64 FileMapStart = (AtOffset / AllocationGranularity) * AllocationGranularity;
                Int64 MapViewSize = (AtOffset % AllocationGranularity) + AllocationGranularity;
                Int64 iViewDelta = AtOffset - FileMapStart;

                hMVF = MapViewOfFile(hMMF, FileMapAccess.FileMapRead, FileMapStart, (Int32)MapViewSize);

                if (hMVF == IntPtr.Zero)
                    throw new Win32Exception();

                byte* p = (byte*)hMVF.ToPointer() + iViewDelta;
                UnmanagedMemoryStream ums = new UnmanagedMemoryStream(p, MapViewSize, MapViewSize, FileAccess.Read);
                byte[] ba = new byte[BytesToRead];
                return ums.Read(Buffer, 0, BytesToRead);
            }
            finally
            {
                if (hMVF != IntPtr.Zero)
                    UnmapViewOfFile(hMVF);
            }
        }
        #endregion

        #region Обработчик

        /// <summary>
        /// Обработчик таймера - раз в секунду чтение файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        { 
            CMemoryMappedFile("exchange.buf", "lab3");
            byte[] buff = new byte[1024];
            Read(buff, 1024, 0);
            string msg = Encoding.Default.GetString(buff);
            if(msg != null)
            {
                try
                {
                    txtName.Text = msg.Split('|')[0];
                    txtAge.Text = msg.Split('|')[1];
                    txtCity.Text = msg.Split('|')[2];
                    txtPhone.Text = msg.Split('|')[3];
                    txtAuxialiry.Text = msg.Split('|')[4];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
