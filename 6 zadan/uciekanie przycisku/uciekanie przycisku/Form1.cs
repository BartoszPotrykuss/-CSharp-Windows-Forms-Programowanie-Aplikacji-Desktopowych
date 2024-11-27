using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uciekanie_przycisku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int przesuniecie = random.Next(25, 75);
            int plusMinus = random.Next(4);
            if (plusMinus == 1)
            {
                button1.Location = new Point(button1.Location.X - przesuniecie, button1.Location.Y - przesuniecie);
            }
            else if (plusMinus == 2)
            {
                button1.Location = new Point(button1.Location.X + przesuniecie, button1.Location.Y + przesuniecie);
            }
            else if (plusMinus == 3)
            {
                button1.Location = new Point(button1.Location.X - przesuniecie, button1.Location.Y + przesuniecie);
            }
            else if (plusMinus == 4)
            {
                button1.Location = new Point(button1.Location.X + przesuniecie, button1.Location.Y - przesuniecie);
            }
        }
    }
}
