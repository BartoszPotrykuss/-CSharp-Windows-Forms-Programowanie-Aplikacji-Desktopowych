using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZdarzeniaMyszy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (e.X < 133 && e.Y < 150)
                {
                    richTextBox1.Text = "Panda wielka, niedźwiedź bambusowy – gatunek drapieżnego ssaka z rodziny niedźwiedziowatych. Panda wielka zamieszkuje lasy bambusowe na wysokości 1200–4100 m n.p.m. Jej przynależność do drapieżnych nie ulega wątpliwości, jednak w rzeczywistości odżywia się pędami roślin, nie gardzi też rybami i małymi gryzoniami. ";
                }
                else if (e.X > 132 && e.X < 265 && e.Y < 150)
                {
                    richTextBox1.Text = "Małpa - parvordo niewielkich, nadrzewnych ssaków naczelnych z infrarzędu małpokształtnych (Simiiformes) o płaskim i szerokim nosie, klasyfikowane w czterech rodzinach małp Nowego Świata.";
                }
                else if (e.X > 264 && e.Y < 150 )
                {
                    richTextBox1.Text = "Niedźwiedź - gatunek drapieżnego ssaka z rodziny niedźwiedziowatych. Zamieszkuje Azję, Europę Północną i Amerykę Północną. Nie jest zagrożony wyginięciem. Sierść niedźwiedzia brunatnego ma barwę ciemnobrązową, choć u niektórych podgatunków może być jaśniejsza.";
                }
                else if ( e.X < 132 && e.Y > 133 && e.Y < 265)
                {
                    richTextBox1.Text = "Wielbłąd - rodzaj dużego ssaka z rodziny wielbłądowatych. Fizjologicznie przystosowane do życia w warunkach suchego i gorącego klimatu, są w wielu krajach wykorzystywane jako zwierzęta użytkowe.";
                }
                else if (e.X > 132 && e.X < 265 && e.Y > 133 && e.Y < 265)
                {
                    richTextBox1.Text = "Sarna - rodzaj ssaka z podrodziny saren w obrębie rodziny jeleniowatych.";
                }
                else if (e.X > 264 && e.Y > 133 && e.Y < 265)
                {
                    richTextBox1.Text = "Tygrys biały - jeden z wielu wariantów ubarwienia tygrysa Panthera tigris. Jego cechami charakterystycznymi są: kremowe lub białe umaszczenie sierści, różowy nos, niebieskie oczy oraz czarne, szare lub brązowe pasy.";
                }
                else if (e.X < 133 && e.Y > 264)
                {
                    richTextBox1.Text = "Tygrys - gatunek dużego, drapieżnego ssaka łożyskowego z podrodziny panter w rodzinie kotowatych, największego ze współczesnych pięciu gatunków dzikich kotów z rodzaju Panthera, jeden z największych drapieżników lądowych.";
                }
                else if (e.X > 132 && e.X < 265 && e.Y > 264)
                {
                    richTextBox1.Text = "Wąż - podrząd gadów z rzędu łuskonośnych. Charakteryzują się wydłużonym, beznogim ciałem i aparatem szczękowym umożliwiającym niezwykle szerokie rozwarcie paszczy, a co za tym idzie połykanie ofiar w całości, brakiem błony bębenkowej i ucha środkowego.";
                }    
                else if (e.X > 264 && e.X > 264)
                {
                    richTextBox1.Text = "Bawół - podrodzina ssaków z rodziny wołowatych (Bovidae).";
                }
                
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.X < 125 && e.Y < 125)
            {
                label1.Visible = true;
                label1.Location = new Point(e.X, e.Y - 20);
            }
            else label1.Visible = false;


            if (e.X > 132 && e.X < 265 && e.Y < 150)
            {
                label4.Visible = true;
                label4.Location = new Point(e.X, e.Y - 20);
            }
            else label4.Visible = false;


            if (e.X > 264 && e.Y < 150)
            {
                label7.Visible = true;
                label7.Location = new Point(e.X, e.Y - 20);
            }
            else label7.Visible = false;


            if (e.X < 132 && e.Y > 133 && e.Y < 265)
            {
                label2.Visible = true;
                label2.Location = new Point(e.X, e.Y - 20);
            }
            else label2.Visible = false;


            if (e.X > 132 && e.X < 265 && e.Y > 133 && e.Y < 265)
            {
                label5.Visible = true;
                label5.Location = new Point(e.X, e.Y - 20);
            }
            else label5.Visible = false;


            if (e.X > 264 && e.Y > 133 && e.Y < 265)
            {
                label8.Visible = true;
                label8.Location = new Point(e.X, e.Y - 20);
            }
            else label8.Visible = false;


            if (e.X < 133 && e.Y > 264)
            {
                label3.Visible = true;
                label3.Location = new Point(e.X, e.Y - 20);
            }
            else label3.Visible = false;


            if (e.X > 132 && e.X < 265 && e.Y > 264)
            {
                label6.Visible = true;
                label6.Location = new Point(e.X, e.Y - 20);
            }
            else label6.Visible = false;


            if (e.X > 264 && e.Y > 264)
            {
                label9.Visible = true;
                label9.Location = new Point(e.X, e.Y - 20);
            }
            else label9.Visible = false;

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sprawdź jakie zwierzę kryje się pod obrazkiem \n1. Najechanie kursorem na obrazek " +
        "odkryje jego nazwę\n2. Kliknięcie - wyświetli informacje o nim\n";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

        }
    }
}
