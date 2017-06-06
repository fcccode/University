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
    public partial class Flower : Form
    {
        public Flower()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics cir = pictureBox1.CreateGraphics();
            Point pt1 = new Point(160, 85);
            Point pt2 = new Point(180, 125);
            Point pt3 = new Point(180, 150);
            GraphicsPath path = new GraphicsPath();
            path.AddLine(pt1, pt2);
            path.AddLine(pt2, pt3);
            cir.DrawPath(Pens.Green, path);
            cir.DrawEllipse(Pens.Black, 140, 65, 20, 20);
            Graphics el1 = pictureBox1.CreateGraphics();
            Graphics el2 = pictureBox1.CreateGraphics();
            Graphics el3 = pictureBox1.CreateGraphics();
            Graphics el4 = pictureBox1.CreateGraphics();
            Graphics el5 = pictureBox1.CreateGraphics();
            Graphics el6 = pictureBox1.CreateGraphics();
            Graphics el7 = pictureBox1.CreateGraphics();
            Graphics el8 = pictureBox1.CreateGraphics();
           
            el1.DrawEllipse(Pens.Red,75,65,65,20 );
            el2.DrawEllipse(Pens.Red,160,65,65,20);
            el3.DrawEllipse(Pens.Red,140,0,20,65 );
            el4.DrawEllipse(Pens.Red,140,85,20,65 );
            el5.DrawEllipse(Pens.Red,110,35,30,30 );
            el6.DrawEllipse(Pens.Red,160,35,30,30 );
            el7.DrawEllipse(Pens.Red, 110, 85, 30, 30);        
            el8.DrawEllipse(Pens.Red, 130, 55, 40, 40);

            Brush br1 = new SolidBrush(Color.Yellow);
            Brush br2 = new SolidBrush(Color.Blue);
            Brush br3 = new SolidBrush(Color.Red);


            el1.FillEllipse(br2, 75, 65, 65, 20);
            el2.FillEllipse(br2, 160, 65, 65, 20);
            el3.FillEllipse(br2, 140, 0, 20, 65);
            el4.FillEllipse(br2, 140, 85, 20, 65);
            el5.FillEllipse(br2, 110, 35, 30, 30);
            el6.FillEllipse(br2, 160, 35, 30, 30);
            el7.FillEllipse(br2, 110, 85, 30, 30);
            el8.FillEllipse(br3, 130, 55, 40, 40);
            cir.FillEllipse(br1, 140, 65, 20, 20);



        }
    }
}
