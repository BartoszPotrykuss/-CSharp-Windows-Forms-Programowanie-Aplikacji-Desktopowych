using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematyka_w_60s
{
    internal class Dzialanie
    {
        int a, b;
        char znak;
        public double wynik;
        public Dzialanie(int a, int b, char znak)
        {
            this.a = a;
            this.b = b;
            this.znak = znak;
        }
        public string PodajDzialanie()
        {
            if (znak == '+')
            {
                this.wynik = a + b;
                return $"{a} + {b} = ";
            }
            else if (znak == '-')
            {
                wynik = a - b;
                return $"{a} - {b} = ";
            }
            else if (znak == '*')
            {
                wynik = a * b;
                return $"{a} * {b} = ";
            }
            else if (znak == '/')
            {
                wynik = (double) a / b;
                return $"{a} / {b} = ";
            }
            else return $"Nieprawidłowy znak";

        }
    }
}
