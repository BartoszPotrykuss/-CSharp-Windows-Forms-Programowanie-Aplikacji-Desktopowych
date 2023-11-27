using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lancuchy_w_jezyku_csharp
{
    public partial class Form1 : Form
    {
        string nazwa, mail, haslo, p_haslo;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Zaznaczony", "Info");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Niezaznaczony", "Info");
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = default;
            textBox2.BackColor = default;
            textBox3.BackColor = default;
            textBox4.BackColor = default;
            nazwa = textBox1.Text;
            mail = textBox2.Text;
            haslo = textBox3.Text;
            p_haslo = textBox4.Text;
            if (string.IsNullOrEmpty(nazwa) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(p_haslo))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                if (string.IsNullOrEmpty(nazwa))
                {
                    textBox1.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(mail))
                {
                    textBox2.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(haslo))
                {
                    textBox3.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(p_haslo))
                {
                    textBox4.BackColor = Color.Red;
                }
            }
            else if (mail.Contains('@') == false)
            {
                MessageBox.Show("Nieprawidłowy adres e-mail.");
                textBox2.BackColor = Color.Red;
            }
            else if (haslo.Equals(p_haslo) == false)
            {
                MessageBox.Show("Hasła się różnią.");
                textBox4.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
            }
            else
            {
                
                MessageBox.Show("Witaj " + nazwa.ToLower());
                textBox1.BackColor = default;
                textBox2.BackColor = default;
                textBox3.BackColor = default;
                textBox4.BackColor = default;
            }
        }
    }
}
