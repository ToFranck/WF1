using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class NPremier : Form
    {
        public NPremier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 nombre = Convert.ToInt32(textBox1.Text);
            Int32 N;
            Int32 X = 0;
            for (N = 1; N <= nombre; N++)
            {
                X = X + N;
                label2.Text = ("le résultat des N premiers entiers est: " + X);
            }

        }
    }
}
