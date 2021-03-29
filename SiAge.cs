using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class SiAge : Form
    {
        public SiAge()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            Int32 age = Convert.ToInt32(textBox1.Text);
            if (age < 18)
            {
                label1.Text = ("ce programme est réservé aux personnes majeures ");
            }
            else if (age < 25)
            {
                label1.Text = (" Vous etes jeune adulte");
            }
            else if (age < 64)
            {
                label1.Text = (" Vous etes adulte");
            }
            else
            {
                label1.Text = (" Vous etes retraité");
            }

                //label1.Text = ("Votre age est de " + age + " ans. Programme terminé ! ");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
