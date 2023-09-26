using Poker_dobierany;

Talia talia = new Talia();

Reka reka1 = new Reka(talia.rozdaj(5));
Reka reka2 = new Reka(talia.rozdaj(5));

reka1.dodaj(talia.rozdaj(reka1.wymien(1)));
reka2.dodaj(talia.rozdaj(reka2.wymien(2)));

//if (reka1.getPoint() > reka2.getPoint()) Console.WriteLine("wygrywa gracz 1");
//if (reka1.getPoint() < reka2.getPoint()) Console.WriteLine("wygrywa gracz 2");
Console.WriteLine(reka1.getPoint());
Console.WriteLine(reka2.getPoint());
Console.WriteLine("remis");