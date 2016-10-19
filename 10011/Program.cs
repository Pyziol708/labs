using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Kamil Standarski // 136771
 * RZĄD 1
*/
namespace _10011
{
    class Program
    {
        static void Main(string[] args)
        {
            double netto = 0, brutto = 0, stawka = 0;
            Console.Write("Wartosc netto[pln]:");
            netto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Stawka podatkowa[%]:");
            stawka = Convert.ToDouble(Console.ReadLine()) / 100;
            brutto = netto + (netto * stawka);
            Console.WriteLine("Wartosc brutto: {0}", brutto);
            Console.Read();
        }
    }
}
