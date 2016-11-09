using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00025
{
    class Rekin : IAlive
    {
        string imie;
        int waga;
        int iloscNog;

        public Rekin(string imie, int waga, int iloscNog)
        {
            this.imie = imie;
            this.waga = waga;
            this.iloscNog = iloscNog;
        }

        public void JakSiePoruszam()
        {
            Console.WriteLine("Poruszam się w wodzie.");
        }
        public void CoJem()
        {
            Console.WriteLine("Jem ludzi.");
        }
    }
}
