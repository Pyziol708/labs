using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//RZAD 2

namespace _00022
{
    class Program
    {
        static void Main(string[] args)
        {
            Bohater legolas = new Lucznik("Legolas", 100, 8, 13);
            Bohater aragorn = new Wojownik("Aragorn", 100, 9, 9);

            Console.WriteLine(legolas);
            Console.WriteLine(aragorn);

            Console.WriteLine("\n[Aragorn atakuje]\n");

            legolas.zycie(legolas.zycie() - aragorn.obrazenia());

            Console.WriteLine(legolas);
            Console.WriteLine(aragorn);

            Console.WriteLine("\n[Legolas atakuje]\n");

            aragorn.zycie(aragorn.zycie() - legolas.obrazenia());

            Console.WriteLine(legolas);
            Console.WriteLine(aragorn);

            Console.ReadKey();
        }
    }
}
