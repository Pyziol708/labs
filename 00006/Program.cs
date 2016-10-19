using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00006
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            int x = 1, y;
            /*2*/
            Console.WriteLine(++x);//2
            /*3*/
            Console.WriteLine(x++);//2
            /*4*/
            Console.WriteLine(x);//3
            /*5*/
            y = x++;
            /*6*/
            Console.WriteLine(y);//3
            /*7*/
            y = ++x;
            /*8*/
            Console.WriteLine(++y);//6

            sbyte sbajt = 127;
            sbajt++;
            Console.WriteLine(sbajt);
            Console.ReadKey();
        }
    }
}
