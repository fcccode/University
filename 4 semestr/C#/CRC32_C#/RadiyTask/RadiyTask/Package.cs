using System;


namespace RadiyTask
{
    class Package
    {
        private byte sender;
        private byte receiver;
        private byte destenation;
        private byte[] dataLength;
        private byte[] crc32;
        private byte[] data;


        public Package()
        {        }
        public void SetReceiver(byte receiver)
        {
            this.receiver = receiver;
        }
        public void SetSender(byte sender)
        {
            this.sender = sender;
        }
        public void SetDest(byte dest)
        {
            this.destenation = dest;
        }
        public void SetData(byte[] data)
        {
            this.data = new byte[data.Length];
            Buffer.BlockCopy(data, 0, this.data, 0, data.Length);
        }
        public void SetDataLength(byte[] data_length)
        {
            this.dataLength = new byte[data_length.Length];
            Buffer.BlockCopy(data_length, 0, this.dataLength, 0, data_length.Length);
        }
        public void SetCrc32(byte[] crc32)
        {
            this.crc32 = new byte[crc32.Length];
            Buffer.BlockCopy(crc32, 0, this.crc32, 0, crc32.Length);          
        }
        public byte[] GetCRC32()
        {
            return this.crc32;
        }
        public byte[] GetData()
        {
            return this.data;
        }
        public byte GetSender()
        {
            return this.sender;
        }
        public byte GetReceiver()
        {
            return this.receiver;
        }
        public byte GetDest()
        {
            return this.destenation;
        }
        public byte[] GetDataLength()
        {
            return this.dataLength;
        }
    }

}
