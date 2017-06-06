using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labarator_7
{
    public partial class Form1 : Form
    {
        
        
        string inputPath ="";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            string read;
            string str="";
          
            if (inputPath != null)
            {
                StreamReader s = File.OpenText(inputPath);
                while ((read = s.ReadLine()) != null)
                {
                    str += read;
                }

          
                for (int i = 0; i < str.Length; i++) {
                    result += Convert.ToInt32(str[i]);
                }

                int temp = 0;
                int iter = 0;

                result = result / str.Length;

                for (int i = 0; i < str.Length; i++)
                {
                    temp = Convert.ToInt32(str[i]);
                    if (temp < result) {
                        iter++;
                    }
                }
                textBox2.Text = Convert.ToString(iter);
            }
                
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputPath = textBox1.Text;
        }

       
    }
}
