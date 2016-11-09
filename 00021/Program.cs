using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00021
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto(1, 1200);
            Konto konto2 = new Konto(2, 5000);
            Konto konto3 = new Konto(3, 0);

            konto1.DokonajWplaty(100);
            konto1.WykonajPrzelew(konto2, 1300);
            konto2.WykonajPrzelew(konto3, 5000);
            konto2.WykonajPrzelew(konto3, 200);
            konto2.WykonajPrzelew(1000);

            konto1.PokazZestawienie();
            konto2.PokazZestawienie();
            konto3.PokazZestawienie();
            konto1.PokazWyciag(true);
            konto2.PokazWyciag(true);
            konto3.PokazWyciag(true);

            Console.ReadKey();
        }
    }
}
