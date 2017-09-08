using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent( );
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click( object sender, EventArgs e )
        {
            Close( );
        }


    }
}
