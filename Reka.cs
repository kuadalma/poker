using System;
using System.Collections.Generic;
using System.Drawing;

namespace Poker_dobierany
{
    internal class Reka
    {
        public List<Karta> karty;
        public string uklad;
        private int punkty;
        public Reka(List<Karta> karty)
        {
            this.karty = karty;
            sortuj();
            uklad = string.Empty;
            punkty = 0;
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
            if (CzyPoker())
            {
                uklad = "Poker";
                return 8000 + punkty;
            }
            else if (CzyKareta())
            {
                uklad = "Kareta";
                return 7000 + punkty;
            }
            else if (CzyFull())
            {
                uklad = "Full";
                return 6000 + punkty;
            }
            else if (CzyKolor())
            {
                uklad = "Kolor";
                return 5000 + punkty;
            }
            else if (CzyStrit())
            {
                uklad = "Strit";
                return 4000 + punkty;
            }
            else if (CzyTrojka())
            {
                uklad = "Trójka";
                return 3000 + punkty;
            }
            else if (CzyDwiePary())
            {
                uklad = "Dwie pary";
                return 2000 + punkty;
            }
            else if (CzyPara())
            {
                uklad = "Para";
                return 1000 + punkty;
            }
            uklad = "Wysoka Karta";
            return punkty;
        }
        private bool CzyPoker()
        {
            karty.Sort((k1, k2) => k1.numer.CompareTo(k2.numer));

            for (int i = 0; i <= karty.Count - 5; i++)
            {
                bool poker = true;
                for (int j = i; j < i + 4; j++)
                {
                    if (karty[j].numer + 1 != karty[j + 1].numer || karty[j].kolor != karty[j + 1].kolor)
                    {
                        poker = false;
                        break;
                    }
                }
                if (poker)
                {
                    punkty = karty[i + 4].numer;
                    return true;
                }
            }
            return false;
        }
        private bool CzyKareta()
        {
            var grupyKart = karty.GroupBy(k => k.numer);
            foreach (var grupa in grupyKart)
            {
                if (grupa.Count() == 4)
                {
                    punkty = grupa.Key;
                    return true;
                }
            }
            return false;
        }
        private bool CzyFull()
        {
            var grupyKart = karty.GroupBy(k => k.numer);
            bool trójka = false;
            bool para = false;

            foreach (var grupa in grupyKart)
            {
                if (grupa.Count() == 3)
                {
                    trójka = true;
                }
                else if (grupa.Count() == 2)
                {
                    para = true;
                }
            }
            if (trójka && para)
            {
                punkty = karty[4].numer;
                return true;
            }
            return false;
        }
        private bool CzyKolor()
        {
            var grupyKolorow = karty.GroupBy(k => k.kolor);
            foreach (var grupa in grupyKolorow)
            {
                if (grupa.Count() < 5) return false;
            }
            punkty += karty[4].numer;
            return true;
        }
        private bool CzyStrit()
        {
            for (int i = 0; i <= karty.Count - 5; i++)
            {
                bool strit = false;
                for (int j = i; j < i + 4; j++)
                {
                    if (karty[j].numer + 1 != karty[j + 1].numer)
                    {
                        strit = true;
                        break;
                    }
                }
                if (strit) return false;
            }
            punkty += karty[4].numer;
            return true;
        }
        private bool CzyTrojka()
        {
            var grupyKart = karty.GroupBy(k => k.numer);

            foreach (var grupa in grupyKart)
            {
                if (grupa.Count() == 3)
                {
                    punkty = grupa.Key;
                    return true;
                }
            }
            return false;
        }
        private bool CzyDwiePary()
        {
            var grupyKart = karty.GroupBy(k => k.numer);
            int liczbaPar = 0;

            foreach (var grupa in grupyKart)
            {
                if (grupa.Count() == 2)
                {
                    liczbaPar++;
                }
            }
            if (liczbaPar == 2)
            {
                punkty = grupyKart.Max(grupa => grupa.Key);
                return true;
            }
            return false;
        }
        private bool CzyPara()
        {
            var grupyKart = karty.GroupBy(k => k.numer);
            foreach (var grupa in grupyKart)
            {
                if (grupa.Count() == 2)
                {
                    punkty = grupa.Key;
                    return true;
                }
            }
            return false;
        }
    }
}
