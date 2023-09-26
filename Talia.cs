namespace Poker_dobierany
{
    internal class Talia
    {
        private List<string> kolory = new List<string> { "♠", "♥", "♦", "♣" };
        private List<Karta> karty;
        public Talia()
        {
            karty = new List<Karta>();
            for (int i = 0; i < kolory.Count; i++)
            {
                for (int j = 9; j <= 14; j++)
                {
                    karty.Add(new Karta(j, kolory[i]));
                }
            }
        }
        public List<Karta> rozdaj(int ile)
        {
            List<Karta> rozdaj = new List<Karta>();
            Random rnd = new Random();
            for (int i = 0; i < ile; i++)
            {
                int index = rnd.Next(0, karty.Count());
                rozdaj.Add(karty[index]);
                karty.RemoveAt(index);
            }
            return rozdaj;
        }
    }
}
