using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_dobierany
{
    internal class Reka
    {
        public List<Karta> karty;

        public Reka(List<Karta> karty)
        {
            this.karty = karty;
        }
        public void dodaj(List<Karta> karty)
        {
            this.karty.AddRange(karty);
        }
        public int wymien()
        {
            Console.WriteLine("ile kart chcesz wymienic? :");
            int ile = int.Parse(Console.ReadLine());
            if (ile == 5)
            {
                return ile;
            }
            for (int i = 0; i < ile; i++)
            {
                Console.WriteLine("ktore karty : ");
                karty.RemoveAt(int.Parse(Console.ReadLine())-1);
            }
            return ile;
        }
    }
}
