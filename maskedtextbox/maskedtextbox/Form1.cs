using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maskedtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            String mail = maskedTextBox5.Text; //pobranie łańcucha znaków
            String mailReg = @"^[a-z][a-z0-9_]*@[a-z0-9]*\.[a-z]{2,3}$"; //utworzenie wyrażenia regularnego
            Regex regEmail = new Regex(mailReg); //utworzenie obiektu klasy Regex

            if (String.IsNullOrEmpty(maskedTextBox1.Text) || String.IsNullOrEmpty(maskedTextBox2.Text) || String.IsNullOrEmpty(maskedTextBox3.Text) || String.IsNullOrEmpty(maskedTextBox4.Text) || String.IsNullOrEmpty(maskedTextBox5.Text) || String.IsNullOrEmpty(maskedTextBox6.Text))
            {
                MessageBox.Show("Nie wszystkie pola są wypełnione");
            }
            else if (maskedTextBox3.MaskCompleted == false)
            {
                label10.Visible = true;
                label7.Visible = true;
            }
            else if (maskedTextBox4.MaskCompleted == false)
            {
                label11.Visible = true;
                label7.Visible = true;
            }
            else if (maskedTextBox6.MaskCompleted == false)
            {
                label12.Visible = true;
                label7.Visible = true;
            }
            else  if (regEmail.IsMatch(mail) == false) //sprawdzenie dopasowania za pomocą metody IsMatch()
            {
                label7.Visible = true;
                label13.Visible = true;
            }
            else

            {
                MessageBox.Show("Dziękujemy za wypełnienie formularza!");
            }
        }
    }
}
