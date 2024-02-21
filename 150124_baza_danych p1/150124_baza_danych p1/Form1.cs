using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150124_baza_danych_p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'baza_testowaDataSet1.uczen' . Możesz go przenieść lub usunąć.
            this.uczenTableAdapter.Fill(this.baza_testowaDataSet1.uczen);

        }

        private void uczenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uczenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_testowaDataSet1);

        }
    }
}
