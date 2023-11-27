using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace matematyka_w_60s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Timer timer = new Timer();
        int czas = 1;
        double wynik = 2;
        int punkty = 0;
        char znak;
        public void losowanko(char znak)
        {

            Random random = new Random();
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            Dzialanie dzialanie = new Dzialanie(a, b, znak);
            pokazDzialanie.Text = dzialanie.PodajDzialanie();
            wynik = dzialanie.wynik;
        }

        public char wylosujZnak()
        {
            Random random = new Random();
            int losZnak = random.Next(1, 5);
            switch (losZnak)
            {
                case 1: znak = '+';
                    break;
                case 2: znak = '-';
                    break;
                case 3: znak = '*';
                    break;
                case 4: znak = '/';
                    break;
            }
            return znak;
        }

        public void zablokujPrzyciski()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = false;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            znak = '+';
            dodawanie.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            losowanko(znak);
        }


        public void Timer_Tick(object sender, EventArgs e)
        {
            if (czas == Convert.ToInt32(textBox2.Text))
            {
                timer.Stop();
                double srednio = (double)czas / punkty;
                srednio = Math.Round(srednio, 2);
                MessageBox.Show($"Czas minął! Twój wynik to: {punkty} \n Czas na jedno działanie: {srednio}s");
                DialogResult dr = MessageBox.Show("Czy chcesz zagrać jeszcze raz?", "Komunikat", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else Close();
            }
            zegar.Text = czas.ToString();
            czas++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "-")
            {

            }
            else
            {
                int gracz = Convert.ToInt32(textBox1.Text);
                if (gracz == wynik)
                {
                    if (wszystkieDzialania.Enabled == true)
                    {
                        losowanko(wylosujZnak());
                    }
                    else losowanko(znak);
                    if (znak == '/')
                    {
                        while (wynik != (int)wynik)
                        {
                            losowanko(znak);
                        }
                    }
                    punkty++;
                    punktyL.Text = punkty.ToString();
                    Thread.Sleep(100);
                    textBox1.Text = "";
                }
            }
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            znak = '-';
            zablokujPrzyciski();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            losowanko(znak);
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            znak = '*';
            zablokujPrzyciski();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            losowanko(znak);
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            znak = '/';
            zablokujPrzyciski();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            losowanko(znak);
            while (wynik != (int)wynik)
            {
                losowanko(znak);
            }
        }

        private void wszystkieDzialania_Click(object sender, EventArgs e)
        {
            zablokujPrzyciski();
            wszystkieDzialania.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            losowanko(wylosujZnak());
            if (znak == '/')
            {
                while (wynik != (int)wynik)
                {
                    losowanko(znak);
                }
            }
        }
    }
}
