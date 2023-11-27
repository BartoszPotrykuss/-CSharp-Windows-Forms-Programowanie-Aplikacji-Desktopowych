using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Losowa_liczba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int licznik = 0;
        int wylosowana;
        private void button1_Click(object sender, EventArgs e)
        {
            int liczba = Convert.ToInt32(textBox1.Text);
            licznik++;
            if (wylosowana == liczba)
            {
                MessageBox.Show("Brawo! Liczba prób: " + licznik);
            }
            else if (wylosowana > liczba)
            {
                DialogResult dr = MessageBox.Show("Za mało \n Czy chcesz kontynuować grę?", "informacja", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    Close();
                }
            }
            else if (wylosowana < liczba)
            {
                DialogResult dr = MessageBox.Show("Za dużo \n Czy chcesz kontynuować grę?", "informacja", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            wylosowana = rnd.Next(0, 100);
        }
    }
}
