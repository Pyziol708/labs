using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00024
{
    class Bicycle : Vehicle, IRideable, IMusic
    {
        public void Ride()
        {
            Console.WriteLine("Jade rowerem");
        }
        
        public void PlayMelody()
        {
            Console.Beep();
        }
    }
}
