using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formatowanie_tekstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        int size = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                size = int.Parse(textBox1.Text);
                label1.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular,
                                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Prosty")
                label1.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            else if (comboBox1.SelectedItem.ToString() == "Pochyły")
            {
                label1.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void czerwonyBtn_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void zielonyBtn_Click(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Green;
        }

        private void niebieskiBtn_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }
    }
}
