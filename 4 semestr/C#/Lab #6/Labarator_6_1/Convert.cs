using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator_6_1
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics convert = pictureBox1.CreateGraphics();
            convert.DrawRectangle(Pens.Black, 75, 30, 150, 90);
            Point pt1 = new Point(75, 30);
            Point pt2 = new Point(150, 80);
            Point pt3 = new Point(225, 30);
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pt1, pt2);
            path.AddLine(pt2, pt3);
            convert.DrawPath(Pens.Black, path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics convert = pictureBox1.CreateGraphics();
            convert.DrawRectangle(Pens.Black, 75, 30, 150, 90);
            Point pt1 = new Point(75, 30);
            Point pt2 = new Point(150, 80);
            Point pt3 = new Point(225, 30);
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pt1, pt2);
            path.AddLine(pt2, pt3);
            convert.DrawPath(Pens.Black, path);

            Brush br1 = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.White);
            

            convert.FillPath(br1, path);
           



        }
    }
}
