using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00018
{
    public class Telefon
    {
        private readonly uint numer;
        private double saldoPoczatkowe;
        private double saldoKoncowe;
        public static double StawkaSMS = 0.20;
        public static double StawkaImpuls = 0.40;
        public static double StawkaGB = 30;

        public Telefon(uint aNumer, double aSaldoPoczatkowe)
        {
            numer = aNumer;
            saldoPoczatkowe = aSaldoPoczatkowe;
            saldoKoncowe = saldoPoczatkowe;
        }

        public bool Doladowanie(double kwota)
        {
            if (kwota < 0)
                return false;
            saldoKoncowe += kwota;
            return true;
        }

        public bool SMS()
        {
            if (StawkaSMS < 0 || saldoKoncowe < StawkaSMS)
                return false;
            saldoKoncowe -= StawkaSMS;
            return true;
        }

        public bool Rozmowa(uint dlugosc)
        {
            if (StawkaImpuls < 0 || saldoKoncowe < StawkaImpuls * dlugosc)
                return false;
            saldoKoncowe -= StawkaImpuls * dlugosc;
            return true;
        }

        public bool Internet(double MB)
        {
            if (MB < 0)
                return false;

            double naleznosc = MB * (StawkaGB / 1000);
            if (saldoKoncowe < naleznosc)
                return false;
            saldoKoncowe -= naleznosc;
            return true;
        }

        public bool UslugaPremium(double kwota)
        {
            if (kwota < 0 || saldoKoncowe < kwota)
                return false;
            saldoKoncowe -= kwota;
            return true;
        }

        public void PokazZestawienie()
        {
            Console.Write("Numer [");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("{0:+48 ### ### ###}", numer));
            Console.ResetColor();
            Console.WriteLine("]");
            Console.WriteLine("Saldo poczatkowe: " + saldoPoczatkowe);
            Console.WriteLine("Saldo koncowe: " + saldoKoncowe);
            Console.WriteLine();
        }
    }
}
