using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zgadnij_Liczbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int losowa = 0;
        int licznikProb = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            losowa = rnd.Next(100);
            label1.Text = losowa.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odp = int.Parse(textBox1.Text);
            licznikProb++;
            if (odp == losowa)
            {
                MessageBox.Show("Zgadłeś! Ilość prób " + licznikProb);
            }
            else if (odp > losowa)
            {
                MessageBox.Show("Podana liczba jest większa od wylosowanej");
            }
            else
            {
                MessageBox.Show("Podana liczba jest mniejsza od wylosowanej");
            }
        }
    }
}
