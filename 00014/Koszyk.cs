using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00014
{
    public class Koszyk
    {
        private List<Produkt> zawartosc = new List<Produkt>();

        public void Dodaj(Produkt aProdukt)
        {
            zawartosc.Add(aProdukt);
        }

        public void Policz()
        {
            Console.WriteLine("Liczba produktów:{0}", this.zawartosc.Count());
        }
    }
}
