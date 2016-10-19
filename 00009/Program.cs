using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00009
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            Console.Write("Liczba:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (l < 5)
                l = 5;
            if (l > 15)
                l = 15;

            Console.WriteLine("Liczba:" + l);

            while (l > 0)
            {
                Console.WriteLine(--l);
            }
            Console.ReadKey();
        }
    }
}
