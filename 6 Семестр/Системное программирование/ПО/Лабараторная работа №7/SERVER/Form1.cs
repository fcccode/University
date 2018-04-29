using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Labarator_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        #region Переменные
        private TcpListener listener;
        private TcpClient handler;
        private Thread worker;
        public bool IsWork { get; private set; }
        public string Message { get; private set; }
        #endregion

        #region Методы
        /// <summary>
        /// Инициализация
        /// </summary>
        private void Initialize()
        { 
            listener = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000));
            listener.Start();

            worker = new Thread(Receiver);
            worker.IsBackground = true;
            worker.Start();
            IsWork = true;
        }

        /// <summary>
        /// Cброс
        /// </summary>
        private void Disconnect()
        {
            handler.Close();
            handler = null;
            IsWork = false;
            worker.Join(200);
        }

        /// <summary>
        /// Прием информации в отдельном потоке
        /// </summary>
        private void Receiver()
        {
            try{
                byte[] data = new byte[200];
                while (IsWork)
                {
                    handler = listener.AcceptTcpClient();
                    NetworkStream stream = handler.GetStream();
                    StringBuilder builder = new StringBuilder();
                    do {
                        var bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);
                    var d = builder.ToString();
                    if (!string.IsNullOrEmpty(d))
                        listBox1.Invoke((MethodInvoker)delegate (){
                            listBox1.Items.Add(DateTime.Now + " | " + d + Environment.NewLine);
                        });
                    handler.Close();
                    stream.Close();
                    Thread.Sleep(100);
                }
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Disconnect();
            }
        }
        #endregion
    }
}
