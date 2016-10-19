using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00013
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary = false;
        public int plec = 0;

        public enum Plec : int
        {
            Kobieta = 0,
            Mezczyzna = 1
        }

        public int ObliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }

        public void Drukuj(string tytul, bool przedrostek = true, bool rodzajWagi = true)
        {
            if (przedrostek)
            {
                if (this.plec == (int)Osoba.Plec.Kobieta) Console.Write("PANI ");
                else Console.Write("PAN ");
            }
            Console.WriteLine("{0}: {1} {2} ({3} l.)", tytul.ToUpper(), this.imie, this.nazwisko, this.ObliczWiek());

            if (this.waga == 0 || this.wzrost == 0 || rodzajWagi == false)
                return;

            double bmi = this.ObliczBMI();
            Console.Write("Rodzaj wagi: ");
            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("niedowaga!");
            }
            else if (bmi >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("nadwaga!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("prawidlowa");
            }
            Console.ResetColor();
            Console.WriteLine(" (BMI: {0})", bmi);
        }

        public double ObliczBMI()
        {
            if (this.waga == 0 || this.wzrost == 0)
                return 0;

            double pWzrost = (double)this.wzrost / 100;
            return waga / (pWzrost * pWzrost);
        }
    }
}
