using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00005
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 9, c = 5;
            Console.WriteLine(a / b);
            Console.WriteLine(a / c);
            Console.WriteLine(b / c);
            Console.WriteLine(b / a);
            Console.WriteLine(c / a);
            Console.WriteLine(c / b);
            Console.ReadKey();
        }
    }
}
