using System;

namespace _00020
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("wqvf", "adqwrr", 1994, 2, 6, 125432);
            st1.WypiszInfo();
            (st1 as Osoba).ObliczWiek();

            Osoba st2 = new Student();
            st2.WypiszInfo("STUDENT 2");

            Student st3 = new Student("awse", "sfwer", 1995, 2, 6, 164878);
            Osoba os3 = st3;
            //Student st4 = os3;//blad: brak rzutowania
            Student st4 = (Student)os3;//poprawka

            os3.WypiszInfo();

            Console.ReadKey();
        }
    }
}
