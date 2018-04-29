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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            Socket sListener = new Socket(AddressFamily.InterNetwork, 
                                          SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                Socket handler = sListener.Accept();
                string data = "";
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.Default.GetString(bytes);
                    if (bytesRec > 0) break;
                }
                txtName.Text = data.Split('|')[0];
                txtAge.Text = data.Split('|')[1];
                txtCity.Text = data.Split('|')[2];
                txtPhone.Text = data.Split('|')[3];
                txtAuxiliary.Text = data.Split('|')[4];
                // вежливо отвечаем
                handler.Send(Encoding.Default.GetBytes("Данные получены, спасибо :)"));
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }
        #endregion
    }
}
