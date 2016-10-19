using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10015
{
    //RZAD 2
    public class Mecz
    {
        public uint bramki1 = 0;
        public uint bramki2 = 0;

        public string PodajWynik()
        {
            if (bramki1 == bramki2)
                return "remis";
            else if (bramki1 > bramki2)
                return "zwyciestwo";
            else
                return "przegrana";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mecz mecz1 = new Mecz();
            mecz1.bramki1 = 2;
            mecz1.bramki2 = 4;
            Console.WriteLine(mecz1.PodajWynik());
            Console.ReadKey();
        }
    }
}
