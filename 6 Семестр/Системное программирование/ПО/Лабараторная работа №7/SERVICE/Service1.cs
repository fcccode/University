using System;
using System.ServiceProcess;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Labarator_7
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private System.Timers.Timer timer;
        private Socket socket;

        /// <summary>
        /// Отладочный крючок
        /// </summary>
        public void OnDebug()
        {
            OnStart(null);
        }

        /// <summary>
        /// Запуск службы
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args) {
            try{ 
                timer = new System.Timers.Timer(2000);
                timer.Elapsed += OnTimerElapsed;
                timer.Start();
            }
            catch (Exception ex){
                OnStop();
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Остановки службы
        /// </summary>
        protected override void OnStop(){
            try {
                timer.Stop();
                timer.Elapsed -= OnTimerElapsed;
                timer = null;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Обработчик таймера
        /// </summary>
        private void OnTimerElapsed(object sender, ElapsedEventArgs e){
            try {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(endPoint);
                var info = Environment.MachineName + " | " +
                                    Environment.UserName + " | " +
                                    Environment.OSVersion;
                socket.Send(Encoding.Unicode.GetBytes(info));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
            catch (Exception ex) {
                OnStop();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
