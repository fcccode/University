using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Labarator_6_1
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Green);
            Graphics circle = pictureBox1.CreateGraphics();
            circle.DrawEllipse(Pens.Black, 85, 10, 130, 130);
            circle.FillEllipse(br, 85, 10, 130, 130);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics circle = pictureBox1.CreateGraphics();
            circle.DrawEllipse(Pens.Black, 85, 10, 130, 130);
            Brush br2 = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.White);
            circle.FillEllipse(br2, 85, 10, 130, 130);
        }
    }
}
