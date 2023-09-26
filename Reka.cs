using System;
using System.Collections.Generic;

namespace Poker_dobierany
{
    internal class Reka
    {
        private List<Karta> karty;
        public Reka(List<Karta> karty)
        {
            this.karty = karty;
            sortuj();
        }
        public void dodaj(List<Karta> karty)
        {
            this.karty.AddRange(karty);
            sortuj();
        }
        private void sortuj()
        {
            List<Karta> karty = this.karty;
            this.karty = karty.OrderBy(o => o.numer).ToList();
        }
        public int wymien(int gracz)
        {
            int ile;
            while (true)
            {
                Console.WriteLine($"gracz {gracz}");
                Console.WriteLine(ToString());
                Console.WriteLine("ile kart chcesz wymienic? :");
                if (int.TryParse(Console.ReadLine(), out ile)) break;
                Console.Clear();
                Console.WriteLine("bledna liczba");
            }
            Console.Clear();
            if (ile >= 5)
            {
                return ile;
            }
            for (int i = 0; i < ile; i++)
            {
                int liczba;
                while (true)
                {
                    Console.WriteLine($"gracz {gracz}");
                    Console.WriteLine(ToString());
                    Console.WriteLine($"wybierz {i + 1} karte : ");
                    if (int.TryParse(Console.ReadLine(), out liczba))
                    {
                        if (liczba != 0 && liczba <= karty.Count()) break;
                    }
                    Console.Clear();
                    Console.WriteLine("bledna liczba");
                }
                karty.RemoveAt(liczba - 1);
                Console.Clear();
            }
            return ile;
        }
        public override string ToString()
        {
            string res = "|";
            for (int i = 0; i < karty.Count(); i++)
            {
                res += karty[i].ToString() + "|";
            }
            return res;
        }
        public int getPoint()
        {
            return -1;
        }
    }
}
