namespace Poker_dobierany
{
    internal class Karta
    {
        public int numer;
        public string kolor;
        public string name;
        public Karta(int numer, string kolor)
        {
            this.numer = numer;
            this.kolor = kolor;
            switch (numer)
            {
                case 10:
                    name = "T";
                    break;
                case 11:
                    name = "J";
                    break;
                case 12:
                    name = "Q";
                    break;
                case 13:
                    name = "K";
                    break;
                case 14:
                    name = "A";
                    break;
                default:
                    name = numer.ToString();    
                    break;
            }
        }
        public override string ToString()
        {
            return $"{name}{kolor}";
        }
    }
}
