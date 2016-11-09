using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10019
{
    class Punkt
    {
        private int x;
        private int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double ObliczOdleglosc()
        {
            return Math.Sqrt(((x-1)*(x-1))+((y-1)*(y-1)));
        }
    }

    class Program
    {
        //RZAD 2
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(2, 3);
            Punkt p2 = new Punkt(3, 5);
            Punkt p3 = new Punkt(4, 4);

            Console.WriteLine(p1.ObliczOdleglosc());
            Console.WriteLine(p2.ObliczOdleglosc());
            Console.WriteLine(p3.ObliczOdleglosc());
            Console.ReadKey();
        }
    }
}
