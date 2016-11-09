using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10023
{
    //RZAD 2
    class Osoba
    {
        protected string imie = "podaj imie";
        protected string nazwisko = "podaj nazwisko";
    }

    class Student : Osoba
    {
        private int ocena1 = 0;
        private int ocena2 = 0;
        private int ocena3 = 0;

        public Student(string i, string n, int o1, int o2, int o3)
        {
            imie = i;
            nazwisko = n;
            ocena1 = o1;
            ocena2 = o2;
            ocena3 = o3;
        }

        public void Zaliczenie()
        {
            if (ocena1 <= 2 || ocena2 <= 2 || ocena3 <= 2)
            {
                Console.WriteLine("{0} {1}: Brak Zaliczenia", imie, nazwisko);
                return;
            }
            double srednia = (ocena1 + ocena2 + ocena3) / 3;
            Console.WriteLine("{0} {1}: {2}", imie, nazwisko, srednia);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("ela", "elabn", 2, 3, 5);
            Student st2 = new Student("mam", "oij", 4, 4, 5);
            Student st3 = new Student("ase", "qwef", 5, 5, 5);
            st1.Zaliczenie();
            st2.Zaliczenie();
            st3.Zaliczenie();
            Console.ReadKey();
        }
    }
}
