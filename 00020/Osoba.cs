using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00020
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected uint rokUrodzenia;
        private string miejsceZamieszkania;

        public Osoba() { }
        public Osoba(string imie, string nazwisko, uint rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public void WypiszInfo(string naglowek = "OSOBA 1")
        {
            Console.WriteLine(naglowek);
            Console.WriteLine("imie: " + imie);
            Console.WriteLine("nazwisko:" + nazwisko);
            Console.WriteLine("rokUrodzenia:" + rokUrodzenia + " (" + this.ObliczWiek() + "l.)");
            Console.WriteLine();
        }

        public uint ObliczWiek()
        {
            return (uint)(DateTime.Now.Year - rokUrodzenia);
        }
    }
}
