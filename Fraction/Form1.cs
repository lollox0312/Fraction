using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bta_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(Tx1.Text);
            List1.Items.Add(f1);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            List1.Items.Clear();    
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Fraction somma = new Fraction(0, 1);
            foreach(Fraction Item in List1.Items)
            {
               somma=somma.Somma(Item); 
            }
            label1.Text=somma.ToString();   
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Fraction f1 =  Fraction.TryParse(Tx2.Text);
            Fraction f2 = Fraction.TryParse(Tx3.Text);
            if (f1 == null || f2 == null)
            {
                string titolo = "ERRORE";
                string Message = "Ciò che è stato inserito non è un numero";
                MessageBox.Show(Message, titolo);

            }
            else
            {
                label2.Text = f1.Somma(f2).ToString();
                Tx2.Text = f1.ToString();
                Tx3.Text = f2.ToString();
            }  

        }
    }
}
