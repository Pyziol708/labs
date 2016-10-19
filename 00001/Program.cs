using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00001
{
    class Program
    {
        #region METODY
        static void Main(string[] args)
        {
            //string userName = string.Empty;//deklaracja zmiennej userName
            //Console.Write("Name:");

            //userName = "Hello " + Console.ReadLine();//laczenie fragmentow ciagu
            //Console.WriteLine(userName);

            int a = 2, b = 3;
            if (a != b)
            {
                Console.WriteLine("a=" + a + ", b=" + b);
                Console.WriteLine("a+b=" + (a + b));
                Console.WriteLine("a-b=" + (a - b));
                Console.WriteLine("a*b=" + (a * b));
                Console.WriteLine("a/b=" + (a / b));
            }
            Console.ReadKey();
        }
        #endregion
    }
}
