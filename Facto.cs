using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Facto : Form
    {
        public Facto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong nombre = textBox1.Text;
            //Int32 nombre = Convert.ToInt32(textBox1.Text);
            Int32 fact = 1;
            Int32 i = 0;
            



            while (i < nombre)
            {
                i++;
                fact += fact * i;

                label2.Text = (fact.ToString());

            } 
        }
    }
}
