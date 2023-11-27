using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zdarzeniaKlawiatury
{
    public partial class Form1 : Form
    {
        int licznik = 10;
        public Form1()
        {
            InitializeComponent();
            label3.Text = licznik.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || Char.IsDigit(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                {
                    if (String.IsNullOrEmpty(richTextBox1.Text) == false)
                    {
                        licznik++;
                    }
                    else
                    {
                        licznik = 10;
                    }
                }
                else if (licznik > 0)
                {
                    licznik--;
                }
                else
                {
                    e.Handled = true;
                }
            
            label3.Text = licznik.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Pole nick jest puste!");
            }
            else if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Pole komentarz jest puste!");
            }
            else if (Char.IsDigit(textBox1.Text[0]))
            {
                MessageBox.Show("Pole nick nie może zaczynać się cyfrą");
            }
            else
            {
                MessageBox.Show("Dziękujemy za podzieleniem się swoją opinią!");
            }
        }
    }
}
