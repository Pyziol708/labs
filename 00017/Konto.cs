using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00017
{
    public class Konto
    {
        private readonly uint id;
        private double saldoPoczatkowe;
        private double saldoKoncowe;

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
            return true;
        }

        public bool WykonajPrzelew(double kwota)
        {
            if (kwota < 0 && saldoKoncowe < kwota)
                return false;

            saldoKoncowe -= kwota;
            return true;
        }

        public bool DokonajWplaty(double kwota)
        {
            if (kwota < 0)
                return false;
            saldoKoncowe += kwota;
            return true;
        }

        public bool DokonajWyplaty(double kwota)
        {
            if (kwota < 0 || saldoKoncowe < kwota)
                return false;
            saldoKoncowe -= kwota;
            return true;
        }

        public void PokazZestawienie()
        {
            Console.Write("Konto [");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(id);
            Console.ResetColor();
            Console.WriteLine("]");
            Console.WriteLine("Saldo poczatkowe: " + saldoPoczatkowe);
            Console.WriteLine("Saldo koncowe: " + saldoKoncowe);
            Console.WriteLine();
        }
    }
}
