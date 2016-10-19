using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//program103.cs

namespace _00002
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prawda = true;
            int zmienna = 5;
            Console.WriteLine(prawda);
            Console.WriteLine(!prawda);
            Console.WriteLine(true & false);
            Console.WriteLine(true | false);
            Console.WriteLine(5 < 2);
            Console.WriteLine(5 > 2);
            Console.WriteLine(zmienna == 2);
            Console.WriteLine(zmienna = 2); //zwracana jest nowa przypisana wartosc
            //Console.WriteLine(zmienna += 1); //to samo tutaj
            Console.WriteLine(5 != 2);
            Console.ReadKey();
        }
    }
}
