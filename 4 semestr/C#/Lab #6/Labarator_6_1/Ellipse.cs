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
    public partial class Ellipse : Form
    {
        public Ellipse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Yellow);
            Graphics ellips = pictureBox1.CreateGraphics();
            ellips.DrawEllipse(Pens.Black, 20, 20, 260, 110);
            ellips.FillEllipse(br, 20, 20, 260, 110);

        }
    }
}
