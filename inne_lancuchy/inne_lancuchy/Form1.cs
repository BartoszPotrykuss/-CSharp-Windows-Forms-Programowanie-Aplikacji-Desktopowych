using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inne_lancuchy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
            text = Convert.ToString(text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(string.Compare(text, "słowo")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(string.Concat(text, "słowo")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("Kopia tekstu: " + string.Copy(text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.EndsWith(".")));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.IndexOf("x")));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.LastIndexOf("x")));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.Insert(2,"xyz")));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.PadLeft(15, '.')));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.PadRight(15, '.')));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(string.IsNullOrWhiteSpace(text)));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.Remove(3)));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.Replace(text[0] ,'x')));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.StartsWith("1")));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.ToLower()));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.ToUpper()));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.Trim()));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.TrimStart()));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.TrimEnd()));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(text.Length));
        }
    }
}
