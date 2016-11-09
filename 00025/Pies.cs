using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00025
{
    class Pies : IAlive, IComparable<Pies>
    {
        string imie;
        int waga;
        int iloscNog;

        public Pies(string imie, int waga, int iloscNog)
        {
            this.imie = imie;
            this.waga = waga;
            this.iloscNog = iloscNog;
        }

        public void JakSiePoruszam()
        {
            Console.WriteLine("Poruszam się na 4 łapach.");
        }
        public void CoJem()
        {
            Console.WriteLine("Jem schabowe.");
        }

        public int CompareTo(Pies that)
        {
            return 0;
        }
    }
}
