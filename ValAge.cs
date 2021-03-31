using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class ValAge : Form
    {
        public ValAge()
        {
            InitializeComponent();
        }

        private void ValAge_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 age = Convert.ToInt32(textBox1.Text);
            

            
                if (age < 18)
                {
                    label2.Text = ("ce programme est réservé aux personnes majeures ");
                }
                else if (age < 25)
                {
                    label2.Text = (" Vous etes jeune adulte");
                }
                else if (age < 64)
                {
                    label2.Text = (" Vous etes adulte");
                }
                else
                {
                    label2.Text = (" Vous etes retraité");
                    
                }
                
                
                label3.Text = ("Voulez vous recommencer? o ou n ?");

            String re = textBox1.Text;
            while (re == "o")
            {
                age = Convert.ToInt32(textBox1.Text);

                if (age < 18)
                {
                    label2.Text =("ce programme est réservé aux personnes majeures ");
                }
                else if (age < 25)
                {
                    label2.Text = (" Vous etes jeune adulte");
                }
                else if (age < 64)
                {
                    label2.Text = (" Vous etes adulte");
                }
                else
                {
                    label2.Text = (" Vous etes retraité");
                }



                label3.Text = ("Voulez vous recommencer? o ou n ?");

                re = textBox1.Text;

            }












        }
    }
}
