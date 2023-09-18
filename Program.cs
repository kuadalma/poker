using Poker_dobierany;

Talia talia = new Talia();

Reka reka1 = new Reka(talia.rozdaj(5));
Reka reka2 = new Reka(talia.rozdaj(5));

reka1.dodaj(talia.rozdaj(reka1.wymien()));
reka2.dodaj(talia.rozdaj(reka2.wymien()));

Console.WriteLine("asad");