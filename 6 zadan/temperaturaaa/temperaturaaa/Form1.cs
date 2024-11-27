using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperaturaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double celsjusze = double.Parse(textBox1.Text);
            double kelviny =  celsjusze - 273.15;
            label3.Text = kelviny.ToString() + " K";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double celsjusze = double.Parse(textBox1.Text);
            double dzielenie = 9 / 5;
            double fahrenheity = dzielenie * celsjusze + 32;
            label3.Text = fahrenheity.ToString() + " F";
        }
    }
}
