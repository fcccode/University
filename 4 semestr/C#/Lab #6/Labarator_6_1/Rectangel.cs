using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator_6_1
{
    public partial class Rectangel : Form
    {
        public Rectangel()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Blue);
            Graphics rec = pictureBox1.CreateGraphics();
            rec.DrawRectangle(Pens.Yellow, 20, 20, 260, 110);
            rec.FillRectangle(br, 20, 20, 260, 110);
        }
    }
}
