using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00012
{
    public class Car
    {
        #region Fields
        private uint model = 0;
        private uint iloscDrzwi = 5;
        private float pojemnoscSilnika = 2.0f;

        public uint Marka = 0;
        public uint Rok = 0;
        public float SrednieSpalanie = 10f;

        public enum Make : uint
        {
            Fiat = 0,
            Opel = 1,
            BMW = 2,
        }

        public enum Model : uint
        {
            Cinquecento = 0,
            Astra2 = 1,
            E90320i = 2
        }
        #endregion

        #region Methods
        #region Ctors
        public Car() { }

        public Car(uint pMarka, uint pRok)
        {
            this.Marka = pMarka;
            this.Rok = pRok;
        }
        #endregion

        public void Debug(string title = "car")
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine("Marka:\t{0}", Car.MakeToString(this.Marka));
            Console.WriteLine("Rok:\t{0}", this.Rok);
            Console.WriteLine();
        }

        public static string MakeToString(uint make)
        {
            switch (make)
            {
                case (uint)Car.Make.Fiat: return "Fiat";
                case (uint)Car.Make.Opel: return "Opel";
                case (uint)Car.Make.BMW: return "BMW";
                default: return string.Empty;
            }
        }

        public static string ModelToString(uint model)
        {
            switch (model)
            {
                case (uint)Car.Model.Cinquecento: return "Cinquecento";
                case (uint)Car.Model.Astra2: return "Astra II";
                case (uint)Car.Model.E90320i: return "320i (E90)";
                default: return string.Empty;
            }
        }
        #endregion

        private double ObliczSpalanie(double pDlugoscTrasy)
        {
            return this.SrednieSpalanie * pDlugoscTrasy;
        }

        public double ObliczKosztPrzejazdu(double pDlugoscTrasy, double pCenaPaliwa)
        {
            return this.ObliczSpalanie(pDlugoscTrasy) * pCenaPaliwa;
        }
    }
}
