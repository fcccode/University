using System;
using System.Windows.Forms;


namespace RadiyTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Text = "Wait";
            textBoxDLen.Enabled = false;
        }
        //=======================================================================================================================
        byte            mRcvr = 0x1;
        byte            mSnd = 0x2;
        byte            mDst = 0xAB;
        byte[]          mData;
        UInt32          mPolinom = 0x04C11DB7;
        UInt32          mSeed = 0xFFFFFFFF;
        Package         OutPack = new Package();
        Package         InPack = new Package();
        //=======================================================================================================================
        // KeyPress Checker
        private void    textBoxRcvr_KeyPress    (object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }

        }
        private void    textBoxSnd_KeyPress     (object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }
        }
        private void    textBoxDst_KeyPress     (object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }
        }
        private void    textBoxDLen_KeyPress    (object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }
        }
        private void    textBoxHash_KeyPress    (object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }
        }
        private void    richTextBoxData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number)) && (number <= 64 || number >= 71) && (number <= 96 || number >= 103))
            {
                e.Handled = true;
            }
        }
       
        // Buttons part
        //=======================================================================================================================
        private void    cancelBtn_Click        (object sender, EventArgs e)
        {
            Close();
        }
        private void    cln_Click              (object sender, EventArgs e)
        {
            textBoxRcvr.Clear();
            textBoxSnd.Clear();
            textBoxDst.Clear();
            textBoxDLen.Clear();
            textBoxHash.Clear();
            richTextBoxData.Clear();
            EnabledFields(true);
        }
        private void    sendBtn_Click          (object sender, EventArgs e)
        {
            if ((textBoxRcvr.Text != "") && (textBoxSnd.Text != "") &&
                (textBoxDst.Text != "" && textBoxHash.Text != "") && 
                (richTextBoxData.Text ==""))
            {
                EnabledFields(false);
                Algorithm(); 
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
        // Logik part
        //=======================================================================================================================
        // получение строки из массива байтов
        public string   ByteArrayToString       (byte[] ba)
        {
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(ba);
            string hex = BitConverter.ToString(ba);
            return hex;
        }   
        // корявый способ получения массива байт из строки 
        public byte[]   StringToByteArray       (string hex)
        {

            int length = hex.Length;
            string temp = null;
            int iter = 0;
            int bytes_count = 0;
            if (length == 1 || length % 2 != 0)
            {
                length += 1;
                bytes_count = length / 2;
            }
            else
            {
                bytes_count = length / 2;
            }

            byte[] bytes = new byte[bytes_count];
            foreach (char s in hex)
            {
                temp += s;
                if (temp.Length == 2)
                {
                    bytes[iter] = Convert.ToByte(temp, 16);
                    iter++;
                    temp = null;
                }

            }
            if (temp != null && iter == bytes_count - 1)
            {
                bytes[iter] = Convert.ToByte(temp, 16);
            }
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            return bytes;
        }

        public void     Algorithm               ()
        {
            GetData();
            Crc32 hash = new Crc32(mPolinom, mSeed);
            UInt32 ConHash = hash.CalculateHash(InPack.GetData());
            UInt32 InHash = BitConverter.ToUInt32(InPack.GetCRC32(), 0);
            
                        
            if ((ConHash == InHash) && (InPack.GetDest() == 0xAA))
            {
                mData = BitCounting(InPack.GetData());
                OutPack.SetReceiver(mRcvr);
                OutPack.SetSender(mSnd);
                OutPack.SetDest(mDst);
                OutPack.SetData(mData);
                OutPack.SetCrc32(BitConverter.GetBytes(hash.CalculateHash(mData)));
                OutPack.SetDataLength(GetLength(mData));
                SendPackage();
             }
             else{
                 MessageBox.Show("Не корректная контрольная сумма");
             }      
        }    
        // формировка пакета и отправка
        public void     SendPackage             ()
        {
            textBoxRcvr.Text    = Convert.ToString  (OutPack.GetReceiver(),  16);
            textBoxSnd.Text     = Convert.ToString  (OutPack.GetSender(),    16);
            textBoxDst.Text     = Convert.ToString  (OutPack.GetDest(),      16);
            textBoxDLen.Text    = ByteArrayToString (OutPack.GetDataLength()   );
            textBoxHash.Text    = ByteArrayToString (OutPack.GetCRC32()        );
            richTextBoxData.Text= ByteArrayToString (OutPack.GetData()         );
        }
        // получение данных формируем пакет
        public void     GetData                 ()
        {
            InPack.SetReceiver  (Convert.ToByte(textBoxRcvr.Text, 16));
            InPack.SetSender    (Convert.ToByte(textBoxSnd.Text, 16));
            InPack.SetDest      (Convert.ToByte(textBoxDst.Text, 16));
            InPack.SetData(StringToByteArray(richTextBoxData.Text));
            InPack.SetDataLength(GetLength(InPack.GetData()));           
            InPack.SetCrc32     (StringToByteArray(textBoxHash.Text));
            textBoxDLen.Text = ByteArrayToString(InPack.GetDataLength());
        }
        // подсчет битов в данных
        public byte[]   BitCounting             (byte[] data)
        {
            var len = data.Length;
            UInt16 j = 0;
            UInt16 counter = 0;
            for (UInt16 i = 0; i < len; i++)
            {
                j = 0;
                while (j < 8)
                {
                    counter += (UInt16)(data[i] & 1);
                    data[i] >>= 1;
                    j++;
                }
            }
            byte[] result = BitConverter.GetBytes(counter);
            if(BitConverter.IsLittleEndian) {
                Array.Reverse(result);
            }
            return result;
        }
        // подсчет длины
        public byte[]   GetLength               (byte[] data) {
            var len = data.Length;
            UInt16 result =0;
            foreach (byte b in data) {
                result++;
            }
            byte[] length = BitConverter.GetBytes(result);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(length);
            return length;
        }
        // 
        private void    EnabledFields           (bool flag)
        {
            if (flag)
            {
                sendBtn.Enabled = true;
                textBoxRcvr.Enabled = true;
                textBoxDst.Enabled = true;
                textBoxSnd.Enabled = true;
                textBoxHash.Enabled = true;
                richTextBoxData.Enabled = true;
            }
            else
            {
                sendBtn.Enabled = false;
                textBoxRcvr.Enabled = false;
                textBoxSnd.Enabled = false;
                textBoxDst.Enabled = false;
                textBoxHash.Enabled = false;
                richTextBoxData.Enabled = false;
          }
        }

       

        //=======================================================================================================================
    }
}