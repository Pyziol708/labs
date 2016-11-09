using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00022
{
    class Wojownik : Bohater
    {
        int ps;

        public Wojownik()
            : base("Ork", 100, 1)
        {
            ps = 15;
        }

        public Wojownik(String imie, int hp, int pt, int ps)
            : base(imie, hp, pt)
        {
            this.ps = ps;
        }

        public override String ToString()
        {
            return String.Format("imie: {0}\n\thp: {1}%\n\tpt: {2}\n\tps: {3}", imie, hp, pt, ps);
        }

        public override int obrazenia()
        {
            int dmg = ps * pt;
            if (hp < 20) dmg = (int)((float)dmg * 1.5f);
            else dmg = (int)((float)hp / 100f * (float)dmg);

            return dmg;
        }
    }
}
