using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Multi : Form
    {
        public Multi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 nombre = Convert.ToInt32(textBox1.Text);
            int i= 0;

            for (i = 0; i <= 10; i++)
            {

                  label2.Text += (nombre + "x" + i + "=" + nombre * i );

            } 

        }
    }
}
