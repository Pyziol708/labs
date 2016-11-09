using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00024
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(2010, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));
            foreach (Car c in cars)
            {
                Console.WriteLine("{0} {1}", c.Year, c.Make);
            }
            cars.Sort();
            Console.WriteLine();
            foreach (Car c in cars)
            {
                Console.WriteLine("{0} {1}", c.Year, c.Make);
            }


            Console.ReadKey();
        }
    }
}
