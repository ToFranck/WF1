using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Imp : Form
    {
        public Imp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Int32 nombre = Convert.ToInt32(textBox1.Text);

            Int32 i;
            Int32 compteur = 0;
            for (i = 1; i <= 40; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                else
                {
                    compteur++; label2.Text +=( i + " est le " + compteur +" " ); 

                }
            }
        }
    }
}
