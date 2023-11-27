using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zgadnijLiterę
{
    public partial class Form1 : Form
    {
        int litera = new Random().Next('a', 'z' + 1);
        int licznik = 0;
        int proba;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            licznik++;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Wypełnij pole");
            }
            else
            {
                proba = Convert.ToChar(textBox1.Text);
                if (litera == proba)
                {
                    MessageBox.Show("Gratulacje! Liczba prób: " + licznik, "Komunikat");
                    DialogResult dr = MessageBox.Show("Czy chcesz włączyć nową grę?", "Komunikat", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (litera > proba)
                {
                    MessageBox.Show("Wygenerowana litera jest wyżej w alfabecie", "Komunikat");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else if (litera < proba)
                {
                    MessageBox.Show("Wygenerowana litera jest niżej w alfabecie", "Komunikat");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                e.Handled = true;
                
            }
            else if (Char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
