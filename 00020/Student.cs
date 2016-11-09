using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00020
{
    class Student : Osoba
    {
        protected uint rok;
        protected uint numerGrupy;
        protected uint numerAlbumu;

        public Student() { }
        public Student(string imie, string nazwisko, uint rokUrodzenia, uint rok, uint numerGrupy, uint numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo(string naglowek = "Student 1")
        {
            Console.WriteLine(naglowek);
            Console.WriteLine("imie: " + imie);
            Console.WriteLine("nazwisko:" + nazwisko);
            Console.WriteLine("rokUrodzenia:" + rokUrodzenia + " (" + this.ObliczWiek() + "l.)");
            Console.WriteLine("rok: " + rok);
            Console.WriteLine("numerGrupy:" + numerGrupy);
            Console.WriteLine("numerAlbumu:" + numerAlbumu);
            Console.WriteLine();
        }
    }
}
