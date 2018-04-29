using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace Labarator_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Обработчик

        /// <summary>
        /// Обработчик нажатия кнопки
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            try{
               
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
                Socket send = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                send.Connect(ipEndPoint);
                string theMessage = txtName.Text + "|" + txtAge.Text + "|" + txtCity.Text + "|" + txtPhone.Text + "|" + txtAuxiliary.Text;
                byte[] msg = Encoding.Default.GetBytes(theMessage);
                int bytesSend = send.Send(msg);
                int bytesRec = send.Receive(bytes);
                MessageBox.Show("Ответ от сервера:\n" + Encoding.Default.GetString(bytes, 0, bytesRec));
                send.Shutdown(SocketShutdown.Both);
                send.Close();
            }
            catch(Exception ex){
                MessageBox.Show("Произошла ошибка. + ex.Message");
            }
        }
        #endregion
    }
}
