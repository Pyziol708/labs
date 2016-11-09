using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00024
{
    class Car : Vehicle, IRideable, IComparable<Car>
    {
        private int year;
        private string make;

        public int Year { get { return year; } }
        public string Make { get { return make; } }

        public Car(int year, string make)
        {
            this.year = year;
            this.make = make;
        }

        public void Ride()
        {
            Console.WriteLine("Jade samochodem");
        }

        public int CompareTo(Car that)
        {
            if (this.year == that.year)
                return this.make.CompareTo(that.make);
            return this.year.CompareTo(that.year);
            
        }
    }
}
