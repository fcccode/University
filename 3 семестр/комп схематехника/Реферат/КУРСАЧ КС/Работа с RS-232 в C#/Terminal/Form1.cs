using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Terminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp;
            serialPort1.PortName = ((string)comboBox1.SelectedItem);          
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity),(string)comboBox3.SelectedItem);
            temp = ((string)comboBox2.SelectedItem);
            temp = temp.ToString();
            serialPort1.BaudRate = (int.Parse(temp));        
            serialPort1.StopBits = ((StopBits)Enum.Parse(typeof(StopBits),(string)comboBox4.SelectedItem));
            try
            {
                serialPort1.Open();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (InvalidOperationException)
            {                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public string SetPortName(string defaultPortName)
        {
            string portName="";
            foreach (string portname in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(portname); //добавить порт в список  
            }
            comboBox1.SelectedIndex = 0;
            if (portName == "")
            {
                portName = defaultPortName;
            }
            return portName; //возвращает порт по умолчанию
        }

        public int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate = "";
            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }
            return int.Parse(baudRate);
        }

        public Parity SetPortParity(Parity defaultPortParity)
        {
            string parity = "";
            foreach (string paritybit in Enum.GetNames(typeof(Parity)))
            {
                parity = paritybit.ToString();
                comboBox3.Items.Add(parity);
            }
            comboBox3.SelectedIndex = 0;
            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }
            return (Parity)Enum.Parse(typeof(Parity), parity);
        }

        public int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits = "9600";
            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }
            return int.Parse(dataBits);
        }

        public StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits = "";
            foreach (string stopbits in Enum.GetNames(typeof(StopBits)))
            {
                stopBits = stopbits.ToString();
                comboBox4.Items.Add(stopbits);
            }
            comboBox4.SelectedIndex = 1;
            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }
            return (StopBits)Enum.Parse(typeof(StopBits), stopBits);
        }

        public  Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake = "";
            foreach (string handshakes in Enum.GetNames(typeof(Handshake)))
            {
                handshake = handshakes;
            }
            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }
            return (Handshake)Enum.Parse(typeof(Handshake), handshake);
        }

        public void BaudRateget()
        {
            string[] listbaudrate = new string[15];
            listbaudrate[0] = "110";
            listbaudrate[1] = "300";
            listbaudrate[2] = "600";
            listbaudrate[3] = "1200";
            listbaudrate[4] = "2400";
            listbaudrate[5] = "4800";
            listbaudrate[6] = "9600";
            listbaudrate[7] = "14400";
            listbaudrate[8] = "19200";
            listbaudrate[9] = "38400";
            listbaudrate[10] = "56000";
            listbaudrate[11] = "57600";
            listbaudrate[12] = "115200";
            listbaudrate[13] = "128000";
            listbaudrate[14] = "256000";
            comboBox2.Items.AddRange(listbaudrate);
            comboBox2.SelectedIndex = 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            serialPort1.PortName = SetPortName(serialPort1.PortName);
            serialPort1.Parity = SetPortParity(serialPort1.Parity);
            serialPort1.BaudRate = SetPortBaudRate(serialPort1.BaudRate);
            serialPort1.StopBits = SetPortStopBits(serialPort1.StopBits);
            serialPort1.Handshake = SetPortHandshake(serialPort1.Handshake);
            BaudRateget();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string writestring;
            writestring = textBox2.Text;
            try
            {
                serialPort1.WriteLine(String.Format("{0}", writestring));
                textBox2.Clear();
            }
            catch (TimeoutException)
            {
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string readstring;        
            try
            {
                readstring = serialPort1.ReadLine();
                textBox1.AppendText(readstring + "\r\n");                                                
            }
            catch (TimeoutException)
            {
            }                      
        }
    }    
}
