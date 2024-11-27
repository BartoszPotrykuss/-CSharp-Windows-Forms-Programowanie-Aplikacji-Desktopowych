using cwiczenia_utrwalajace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenia_utrwalajace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] fruits = { "Apple", "Banana", "Orange", "Strawberry", "Grapes" };
        string[] img = { "apple.png", "banana.png", "orange.png", "strawberry.png", "grapes.png" };
        Color[] backgroundColors = { Color.LightGreen, Color.LightYellow, Color.LightCoral, Color.LightPink, Color.LightSalmon };

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int losowa = rnd.Next(5);
            this.BackColor = backgroundColors[losowa];
            if (losowa == 0)
            {
                pictureBox1.Image = Resources.apple;
            }
            else if (losowa == 1)
            {
                pictureBox1.Image = Resources.banana;
            }
            else if (losowa == 2)
            {
                pictureBox1.Image = Resources.orange;
            }
            else if (losowa == 3)
            {
                pictureBox1.Image = Resources.strawberry;
            }
            else if (losowa == 4)
            {
                pictureBox1.Image = Resources.grape;
            }
            MessageBox.Show(fruits[losowa], "Random Fruit");
        }
    }
}
