using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00007
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AMOUNT = 23;
            int[] tab = new int[AMOUNT];

            for (int i = 0; i < AMOUNT; i++)
            {
                tab[i] = i + 1;
            }

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    for (int i = 0; i < AMOUNT; i++)
                    {
                        if (i > 0)
                            Console.Write(",");
                        Console.Write(tab[i]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < AMOUNT; i++)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    break;
                case 3:
                    for (int i = AMOUNT - 1; i >= 0; i--)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
