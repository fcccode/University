using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public Int32 Left { get; set; }
        public Int32 Top   { get; set; }
        public Int32 Right{ get; set; }
        public Int32 Bottom{ get; set; }
    }
}
