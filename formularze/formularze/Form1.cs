using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy chcesz zamknąć aplikację?", "komunikat" , MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("", "Komunikat", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Dane zatwierdzone");
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Dane niezatwierdzone");
                
            }
        }
    }
}
