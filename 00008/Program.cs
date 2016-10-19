using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00008
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1, y = 2, z = 3;
            int x, y, z;
            Console.Write("x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z:");
            z = Convert.ToInt32(Console.ReadLine());

            if (x == y)
            {
                Console.Write("x == y");
            }
            else if (x > y)
            {
                Console.Write("x > y");
            }
            else
            {
                Console.Write("x < y");
            }

            Console.Write(", ");

            if (y == z)
            {
                Console.Write("y == z");
            }
            else if (y > z)
            {
                Console.Write("y > z");
            }
            else
            {
                Console.Write("y < z");
            }

            Console.Write(", trojkat ");
            if (czyTrojkat(x, y, z))
                Console.WriteLine("TAK.");
            else
                Console.WriteLine("NIE.");

            Console.ReadKey();
        }

        static bool czyTrojkat(int a, int b, int c)
        {
            if (a < b + c)
                return true;
            if (b < a + c)
                return true;
            if (c < b + a)
                return true;
            if (c > b - a)
                return true;
            if (a > c - b)
                return true;
            if (b > c - a)
                return true;
            return false;
        }

    }
}
