using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_dobierany
{
    internal class Karta
    {
        public int numer;
        public string kolor;
        public Karta(int numer, string kolor)
        {
            this.numer = numer;
            this.kolor = kolor;
        }
    }
}
