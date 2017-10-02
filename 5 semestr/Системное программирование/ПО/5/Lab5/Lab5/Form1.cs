using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent( );
            algorithm = new Algorithm( );
        }

        private Algorithm algorithm;
        private int []array;
        private int max_value;
        private int min_value;
        private long start;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.InsertionSort(array);
                txtInsert.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив" );
        }

        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBubble_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.BubbleSort(array);
                txtBubble.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMerge_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.Merge_Sort(array);
                txtMerge.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuick_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.quicksort(array, 0, array.Length-1);
                txtQuick.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSheider_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.SheiderSort(array);
                txtSheider.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRadix_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.RadixSort(array);
                txtRadix.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCounter_Click( object sender, EventArgs e )
        {
            if (array.Length != 0)
            {
                start = DateTime.Now.Ticks;
                algorithm.countingSort(array, min_value, max_value);
                txtCounter.Text = Convert.ToString(TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds);
            }
            else
                MessageBox.Show("С генерируйте массив");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click( object sender, EventArgs e )
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click( object sender, EventArgs e )
        {
            Close( );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty(txtArraySize.Text))
                MessageBox.Show( "Укажите размер массива ");
            else
            if(string.IsNullOrEmpty(txtMinValue.Text) || string.IsNullOrEmpty(txtMaxValue.Text))
                MessageBox.Show("Укажите диапазон чисел");
            else
            {
                min_value = int.Parse(txtMinValue.Text);
                max_value = int.Parse(txtMaxValue.Text);
                array = new int[int.Parse(txtArraySize.Text)];

                Random rand = new Random( );
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(min_value,max_value);
                }

            }

           
        }
    }
}
