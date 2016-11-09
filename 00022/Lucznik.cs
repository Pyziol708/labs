using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00022
{
    class Lucznik : Bohater
    {
        int pz;

        public Lucznik()
            : base("Goblin", 100, 3)
        {
            pz = 15;
        }

        public Lucznik(String imie, int hp, int pt, int pz)
            : base(imie, hp, pt)
        {
            this.pz = pz;
        }

        public override String ToString()
        {
            return String.Format("imie: {0}\n\thp: {1}%\n\tpt: {2}\n\tpz: {3}", imie, hp, pt, pz);
        }

        public override int obrazenia()
        {
            return (int)((float)(pz * pt) * ((float)this.hp / 100f));
        }

    }
}
