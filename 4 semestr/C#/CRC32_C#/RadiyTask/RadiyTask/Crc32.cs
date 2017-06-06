using System;


namespace RadiyTask
{
    class Crc32
    {
        private UInt32 polinom;
        private UInt32 seed;
        private UInt32[] crc32Table;

        public Crc32(UInt32 polinom, UInt32 seed)
        {
            this.polinom = polinom;
            this.seed = seed;
            crc32Table = new UInt32[256];
            InitializationTable();
        }
        private void InitializationTable()
        {

            UInt32 crc;
            for (UInt32 i = 0; i < 256; i++)
            {
                crc = i;
                for (UInt32 j = 0; j < 8; j++)
                {
                    if ((crc & 1) == 1)
                        crc = (crc >> 1) ^ this.polinom;
                    else
                        crc = crc >> 1;
                }
                crc32Table[i] = crc;
            }
        }
        public UInt32 CalculateHash(byte[] data)
        {
             UInt32 hash = this.seed;
                    
             var length = data.Length;             
             for (UInt32 i = 0; i < length; i++)
                hash = (hash >> 8) ^ crc32Table[data[i] ^ hash & 0xff];
          
             return hash;
        }
        public UInt32 GetPolinom()
        {
            return this.polinom;
        }
        public void DisplayCrc32Table()
        {
            for (int i = 0; i < 256; i++)
            {
                System.Console.WriteLine("Element # {0} = {1:X}", i, crc32Table[i]);
            }
        }
    }
}



