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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // Запуск форм
        // круг
        private void button3_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle();
            cir.Show();
        }

        // прямоугольник
        private void button2_Click(object sender, EventArgs e)
        {
            Rectangel rec = new Rectangel();
            rec.Show();
        }

        // линия
        private void button1_Click(object sender, EventArgs e)
        {
            Line lineForm = new Line();
            lineForm.Show();
        }
        // эллипс
        private void button4_Click(object sender, EventArgs e)
        {
            Ellipse el = new Ellipse();
            el.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            House house = new Labarator_6_1.House();
            house.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Flower flower = new Flower();
            flower.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Convert convert = new Convert();
            convert.Show();
        }
    }
}
