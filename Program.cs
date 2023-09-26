using Poker_dobierany;

Talia talia = new Talia();
Console.WriteLine(talia.ToString());

Reka reka1 = new Reka(talia.rozdaj(5));
Console.WriteLine(talia.ToString());
Reka reka2 = new Reka(talia.rozdaj(5));
Console.WriteLine(talia.ToString());

reka1.dodaj(talia.rozdaj(reka1.wymien(1)));
reka2.dodaj(talia.rozdaj(reka2.wymien(2)));

if (reka1.getPoint() > reka2.getPoint()) Console.WriteLine($"wygrywa gracz 1 {reka1.uklad}");
if (reka1.getPoint() < reka2.getPoint()) Console.WriteLine($"wygrywa gracz 2 {reka2.uklad}");
if(reka1.getPoint() == reka2.getPoint()) Console.WriteLine($"remis {reka1.uklad}, {reka2.uklad}");



//List<Karta> poker = new List<Karta>
//{
//    new Karta(10, "s"),
//    new Karta(11, "s"),
//    new Karta(12, "s"),
//    new Karta(13, "s"),
//    new Karta(14, "s")
//};
//List<Karta> kareta = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(2, "t"),
//    new Karta(2, "p"),
//    new Karta(2, "k"),
//    new Karta(14, "s")
//};
//List<Karta> full = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(2, "t"),
//    new Karta(2, "p"),
//    new Karta(14, "k"),
//    new Karta(14, "t")
//};
//List<Karta> kolor = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(4, "s"),
//    new Karta(6, "s"),
//    new Karta(8, "s"),
//    new Karta(10, "s")
//};
//List<Karta> strit = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(3, "t"),
//    new Karta(4, "p"),
//    new Karta(5, "k"),
//    new Karta(6, "s")
//};
//List<Karta> trojka = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(2, "t"),
//    new Karta(2, "p"),
//    new Karta(5, "k"),
//    new Karta(14, "s")
//};
//List<Karta> dwiePary = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(2, "t"),
//    new Karta(3, "p"),
//    new Karta(3, "k"),
//    new Karta(14, "s")
//};
//List<Karta> para = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(2, "t"),
//    new Karta(4, "p"),
//    new Karta(5, "k"),
//    new Karta(14, "s")
//};
//List<Karta> wysokaKarta = new List<Karta>
//{
//    new Karta(2, "s"),
//    new Karta(4, "t"),
//    new Karta(6, "p"),
//    new Karta(8, "k"),
//    new Karta(14, "s")
//};


//Reka reka1 = new Reka(poker);
//Reka reka2 = new Reka(kareta);
//Reka reka3 = new Reka(full);
//Reka reka4 = new Reka(kolor);
//Reka reka5 = new Reka(strit);
//Reka reka6 = new Reka(trojka);
//Reka reka7 = new Reka(dwiePary);
//Reka reka8 = new Reka(para);
//Reka reka9 = new Reka(wysokaKarta);

//reka1.getPoint();
//reka2.getPoint();
//reka3.getPoint();
//reka4.getPoint();
//reka5.getPoint();
//reka6.getPoint();
//reka7.getPoint();
//reka8.getPoint();
//reka9.getPoint();

//Console.WriteLine(reka1.uklad);
//Console.WriteLine(reka2.uklad);
//Console.WriteLine(reka3.uklad);
//Console.WriteLine(reka4.uklad);
//Console.WriteLine(reka5.uklad);
//Console.WriteLine(reka6.uklad);
//Console.WriteLine(reka7.uklad);
//Console.WriteLine(reka8.uklad);
//Console.WriteLine(reka9.uklad);

