using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00025
{
    class Orzel : IAlive, IEnumerable
    {
        string imie;
        int waga;
        int iloscNog;

        public Orzel(string imie, int waga, int iloscNog)
        {
            this.imie = imie;
            this.waga = waga;
            this.iloscNog = iloscNog;
        }

        public void JakSiePoruszam()
        {
            Console.WriteLine("Poruszam się na w powietrzu, bądź na 2 nogach.");
        }
        public void CoJem()
        {
            Console.WriteLine("Jem myszy.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
