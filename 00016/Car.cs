using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00016
{
    public class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        private static uint iloscKol = 0;

        #region Ctors
        private Car() { }
        private Car(double aPojemnoscSilnika, string aMarka)
        {
            this.pojemnoscSilnika = aPojemnoscSilnika;
            this.marka = aMarka;
        }

        public static Car Create()
        {
            Car car = new Car(2.0, "BMW");
            Car.iloscKol = 5;
            return car;
        }
        #endregion

        #region Dtors
        ~Car()
        {
            Console.WriteLine("Zwalniam pamiec");
            Console.ReadKey();
        }
        #endregion
    }
}
