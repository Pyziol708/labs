using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00022
{
    class Bohater
    {
        protected String imie;
        protected int hp;
        protected int pt;

        protected Bohater(String name, int health, int PT)
        {
            this.imie = name;
            this.pt = PT;
            this.zycie(health);
        }


        public virtual int obrazenia()
        {
            return 0;
        }

        public int zycie()
        {
            return this.hp;
        }

        public void zycie(int noweZycie)
        {
            if (noweZycie > 100) this.hp = 100;
            else if (noweZycie < 0) this.hp = 0;
            else this.hp = noweZycie;
        }
        public String nazwa()
        {
            return imie;
        }
    }
}
