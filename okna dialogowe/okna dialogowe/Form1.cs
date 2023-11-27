using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okna_dialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Czy zakończyć aplikację?", "Komunikat" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                Close();
            }
            else MessageBox.Show("Zrezygnowano z zamknięcia.", "komunikat" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
