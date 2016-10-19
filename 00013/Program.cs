using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00013
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Janina";
            dyrektor.nazwisko = "Firefox";
            dyrektor.rokUrodzenia = 1982;
            dyrektor.Drukuj("Dyrektor");

            Osoba pacjent = new Osoba();
            pacjent.imie = "Kamil";
            pacjent.nazwisko = "Standarski";
            pacjent.plec = (int)Osoba.Plec.Mezczyzna;
            pacjent.rokUrodzenia = 1994;
            pacjent.wzrost = 180;
            pacjent.waga = 80;
            pacjent.Drukuj("Pacjent");
            Console.ReadKey();
        }
    }
}
