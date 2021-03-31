using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Devi : Form
    {
        public Devi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 compteur = 0;
            Int32  age = 0;


            age = Convert.ToInt32(textBox1.Text);
                
                compteur++;


                if (age < 10)
                {
                    label2.Text = "plus grand"; compteur++;

            }
                else if (age <= 20)
                {
                compteur++;
                label2.Text = ("Bien jouer ! en seulement " + compteur + " fois ");

                }

                else if (age >= 21)
                {
                compteur++;
                label2.Text = ("petit!");

                }



            
        }
    }
}
