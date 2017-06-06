using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Labarator_6_1
{
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics house = pictureBox1.CreateGraphics();
            house.DrawRectangle(Pens.Green, 75, 74, 150, 75);

            Graphics window1 = pictureBox1.CreateGraphics();
            Graphics window2 = pictureBox1.CreateGraphics();
            Graphics door = pictureBox1.CreateGraphics();
            window1.DrawRectangle(Pens.Black, 85, 90, 25, 30);
            window2.DrawRectangle(Pens.Black, 190, 90, 25, 30);
            door.DrawRectangle(Pens.Black, 135, 90, 30, 60);

            Point pt1 = new Point(75, 74);
            Point pt2 = new Point(150, 10);
            Point pt3 = new Point(225, 74);
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pt1, pt2);
            path.AddLine(pt2, pt3);
            house.DrawPath(Pens.Green, path);


            Brush br = new SolidBrush(Color.Gray);
            Brush br2 = new SolidBrush(Color.Black);
          
            house.FillPath(br2, path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics house = pictureBox1.CreateGraphics();
            house.DrawRectangle(Pens.Green, 75, 74, 150, 75);

            Graphics window1 = pictureBox1.CreateGraphics();
            Graphics window2 = pictureBox1.CreateGraphics();
            Graphics door = pictureBox1.CreateGraphics();
            window1.DrawRectangle(Pens.Black, 85, 90, 25, 30);
            window2.DrawRectangle(Pens.Black, 190, 90, 25, 30);
            door.DrawRectangle(Pens.Black, 135, 90, 30, 60);

            Point pt1 = new Point(75, 74);
            Point pt2 = new Point(150, 10);
            Point pt3 = new Point(225, 74);
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pt1, pt2);
            path.AddLine(pt2, pt3);
            house.DrawPath(Pens.Green, path);

            Brush br3 = new HatchBrush(HatchStyle.LargeGrid, Color.White);
            house.FillPath(br3, path);

        }
    }

    
}
