using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00018
{
    class Program
    {
        static Dictionary<uint, Telefon> telefony = new Dictionary<uint, Telefon>();
        static void Main(string[] args)
        {
            telefony.Add(751345112, new Telefon(751345112, 0));
            telefony.Add(751798234, new Telefon(751798234, 100));
            telefony.Add(751987984, new Telefon(751987984, 150));

            telefony[751345112].Doladowanie(50);
            telefony[751987984].Internet(200);
            telefony[751798234].SMS();
            telefony[751798234].Rozmowa(31);
            telefony[751345112].UslugaPremium(3.68);

            foreach (uint key in telefony.Keys)
            {
                telefony[key].PokazZestawienie();
            }

            Console.ReadKey();
        }
    }
}
