using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class Somme : Form
    {
        public Somme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var tab = [];
            Double somme = 0;
            Int32 compteur = 0;
            Double moyenne = 0;
            //Double min = 0;
            //Double max = 0; 
            Double nombre =Convert.ToInt32(textBox1.Text); 


                if (nombre != 0)
                {
                    

                    somme += somme + nombre;     
                    
                    compteur++;
                    
                    moyenne = somme / compteur;
                    
                }
                else
                {
                    label2.Text = ("La somme est :" + somme);
                    label3.Text = ("la moyenne est :" + moyenne);

                }


           
            
        }
    }
}
