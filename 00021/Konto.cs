using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _00021
{
    class Konto
    {
        private readonly uint id;
        private double saldoPoczatkowe;
        private double saldoKoncowe;
        private List<string> wyciag = new List<string>();

        public Konto(uint aId, double aSaldoPoczatkowe)
        {
            id = aId;
            saldoPoczatkowe = aSaldoPoczatkowe;
            saldoKoncowe = saldoPoczatkowe;
        }

        public bool WykonajPrzelew(Konto konto, double kwota)
        {
            if (kwota < 0 || this.saldoKoncowe < kwota)
                return false;

            this.saldoKoncowe -= kwota;
            konto.saldoKoncowe += kwota;
            wyciag.Add("Przelew |-" + kwota.ToString());
            konto.wyciag.Add("Przelew |+" + kwota.ToString());
            return true;
        }

        public bool WykonajPrzelew(double kwota)
        {
            if (kwota < 0 && saldoKoncowe < kwota)
                return false;

            saldoKoncowe -= kwota;
            wyciag.Add("Przelew |-" + kwota.ToString());
            return true;
        }

        public bool DokonajWplaty(double kwota)
        {
            if (kwota < 0)
                return false;
            saldoKoncowe += kwota;
            wyciag.Add("Wplata |+" + kwota.ToString());
            return true;
        }

        public bool DokonajWyplaty(double kwota, bool bankomat = false)
        {
            if (kwota < 0 || saldoKoncowe < kwota)
                return false;
            saldoKoncowe -= kwota;
            string log = "Wyplata";
            if (bankomat)
                log += " (bankomat)";
            log += " | -" + kwota.ToString();
            wyciag.Add(log);
            return true;
        }

        public void PokazZestawienie(bool wyciag = true)
        {
            Console.Write("Konto [");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(id);
            Console.ResetColor();
            Console.WriteLine("]");
            Console.WriteLine("Saldo poczatkowe: " + saldoPoczatkowe);
            if (wyciag)
            {
                PokazWyciag();
            }
            Console.WriteLine("Saldo koncowe: " + saldoKoncowe);
            Console.WriteLine();
        }

        public void PokazWyciag(bool doPliku = false)
        {
            string dokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            uint i = 1;
            foreach (string wpis in wyciag)
            {
                string linia = wpis;
                if (doPliku)
                {
                    File.AppendAllText(dokumenty + @"\konto" + id + ".txt", linia+"\r\n");
                }
                else
                {
                    Console.WriteLine("\t" + linia);
                }
                i++;
            }
        }
    }
}
