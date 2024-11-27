using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obliczenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            textBox3.Text = "";
            int wynik = 0;

            if (radioButton1.Checked)
            {
                wynik = x + y;
            }
            else if (radioButton2.Checked) {
                wynik = x - y;
            }
            else if (radioButton3.Checked) {
                wynik = x * y;
            }
            else if (radioButton4.Checked)
            {
                if (y == 0)
                {
                    textBox3.Text = "Dzielenie przez 0";
                }
                else
                {
                    wynik = x / y;
                }
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = wynik.ToString();
            }
            
        }
    }
}
