using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00012
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine(carName);

            //Car car1 = new Car((int)Car.Make.BMW, 2006);

            Car car1 = new Car();
            car1.Marka = (uint)Car.Make.BMW;
            car1.Rok = 2006;
            car1.Debug("car1");

            //Car car2 = new Car();
            //car2.Marka = (uint)Car.Make.Opel;
            //car2.Rok = 2002;
            //car2.Debug("car2");

            //car1 = car2;
            //car1.Debug("car1");

            Console.ReadKey();
        }
    }
}
