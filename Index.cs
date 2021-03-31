using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiAge siage = new SiAge();
            siage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Somme somme = new Somme();
            somme.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Multi multi = new Multi();
            multi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NPremier npremier = new NPremier();
            npremier.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValAge valage = new ValAge();
            valage.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Facto facto = new Facto();
            facto.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Imp imp = new Imp();
            imp.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MontéePui montéepui = new MontéePui();
            montéepui.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Devi devi = new Devi();
            devi.Show();
        }
    }
}
