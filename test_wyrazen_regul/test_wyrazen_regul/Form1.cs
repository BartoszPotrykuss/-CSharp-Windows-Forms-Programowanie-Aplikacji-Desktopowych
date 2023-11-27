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

namespace test_wyrazen_regul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = maskedTextBox1.Text;
            string loginReg = @"^\@[a-z0-9A-Z]{5}\s[0-9]{2}$";
            Regex regLogin = new Regex(loginReg);
            string haslo = maskedTextBox2.Text;
            string hasloReg = @"^[A-Z]{1,}[a-z0-9A-Z]{7,}[0-9]{2,}$";
            Regex regHaslo = new Regex(hasloReg);
            if (regLogin.IsMatch(login) == false)
            {
                MessageBox.Show("Login powinien zawierać @ na początku, następnie 5 znaków (bez znaków specjalnych), a po spacji należy podać swój numer ID składający się z dwóch cyfr");
            }
            else if (regHaslo.IsMatch(haslo) == false)
            {
                MessageBox.Show("Hasło musi zawierać minimum jedną wielką literę, następnie minimum 7 znaków (bez znaków specjalnych), a później minimum dwie cyfry");
            }
            else
            {
                MessageBox.Show("Zalogowano");
            }
        }
    }
}
