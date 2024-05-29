using PastaPizzaNet;

//Klanten

Klant Jan = new Klant(1, "Jan Jansen");
Klant Piet = new Klant(2, "Piet Peters");
Klant Onbekend = new Klant(3, null);

//Gerechten

Pizza PizzaMargerita = new("pizza margerita", 8, new List<string> { "Tomatensaus", "Mozarella" });
Pizza PizzaSalami = new("pizza salami", 10, new List<string> { "Tomatensaus", "Mozarella", "Salami" });

Pasta PastaBolognaise = new("Pasta Bolognaise", 12, "Pasta met bolognaise saus en gehakt");
Pasta Carbonara = new("Pasta Carbonara", 13, "spek, roomsaus en parmezaanse kaas");
Pasta Lasagna = new("Lasagna", 15, "");

//Dranken

Frisdrank cola = new Frisdrank(Enums.Drank.cocacola);
Frisdrank water = new Frisdrank(Enums.Drank.water);
Frisdrank limonade = new Frisdrank(Enums.Drank.limonade);

Warmedrank koffie = new Warmedrank(Enums.Drank.koffie);
Warmedrank thee = new Warmedrank(Enums.Drank.thee);

//Desserten

Dessert cake = new Dessert(Enums.Dessert.cake);
Dessert ijs = new Dessert(Enums.Dessert.ijs);
Dessert tiramisu = new Dessert(Enums.Dessert.tiramisu);

//Bestellingen

BesteldGerecht BestelGerecht1 = new(PizzaMargerita, Enums.Grootte.groot, new List<Enums.Extra> { Enums.Extra.kaas, Enums.Extra.look });
BesteldGerecht BestelGerecht2 = new(PizzaMargerita, Enums.Grootte.klein, null);
BesteldGerecht BestelGerecht3 = new(PizzaSalami, Enums.Grootte.groot, null);
BesteldGerecht BestelGerecht4 = new BesteldGerecht(Lasagna, Enums.Grootte.klein, new List<Enums.Extra> { Enums.Extra.look });
BesteldGerecht BestelGerecht5 = new BesteldGerecht(Carbonara, Enums.Grootte.klein, null);
BesteldGerecht BestelGerecht6 = new BesteldGerecht(PastaBolognaise, Enums.Grootte.groot, new List<Enums.Extra> { Enums.Extra.kaas });

Bestelling[] bestellingen = new Bestelling[8];
bestellingen[0] = new(Jan, BestelGerecht1, water, ijs, 2);
bestellingen[1] = new(Piet, BestelGerecht2, water, tiramisu);
bestellingen[2] = new(Piet, BestelGerecht3, thee, ijs);
bestellingen[3] = new(null, BestelGerecht4, null, null);
bestellingen[4] = new(Jan, BestelGerecht5, null, null);
bestellingen[5] = new(Piet, BestelGerecht6, cola, null);
bestellingen[6] = new(Piet, null, koffie, null);
bestellingen[7] = new(Jan, null, null, tiramisu);

decimal prijsTotaleBestelling = 0;

var Klanten = from bestelling in bestellingen
                  group bestelling by bestelling.Klant
                  into klanten
                  select klanten;

//print

foreach (var klant in Klanten)
{
    if (klant.Key != null)
    {
        prijsTotaleBestelling = 0;
        Console.WriteLine($"\nBestellingen van klant {klant.Key.KlantNaam}");
        Console.WriteLine("\n******************************************");

        foreach (var bestelling in klant)
        {
            Console.WriteLine(bestelling.ToString());
            prijsTotaleBestelling += bestelling.BerekenBedrag();
            Console.WriteLine("\n******************************************");
        }

        Console.WriteLine($"Het totaal bedrag van alle bestellingen van klant {klant.Key.KlantNaam}: {prijsTotaleBestelling}");
        Console.WriteLine("\n******************************************");

    }
    else
    {
        Console.WriteLine($"\nBestellingen van onbekende klant");
        Console.WriteLine("\n******************************************");

        foreach (var bestelling in klant)
        {
            Console.WriteLine(bestelling.ToString());
            prijsTotaleBestelling += bestelling.BerekenBedrag();
            Console.WriteLine("\n******************************************");
        }
    }

}



//Probeersel
//Console.WriteLine(Jan.ToString());
//Console.WriteLine(Piet.ToString());
//Console.WriteLine(Onbekend.ToString());
//Console.WriteLine();
//Console.WriteLine(PizzaMargerita.ToString());
//Console.WriteLine(PizzaSalami.ToString());
//Console.WriteLine();
//Console.WriteLine(PastaBolognaise.ToString());
//Console.WriteLine(Carbonara.ToString());
//Console.WriteLine(Lasagna.ToString());
//Console.WriteLine();
//Console.WriteLine(cola.ToString());
//Console.WriteLine(water.ToString());
//Console.WriteLine(limonade.ToString());
//Console.WriteLine(koffie.ToString());
//Console.WriteLine(thee.ToString());
//Console.WriteLine();
//Console.WriteLine(cake.ToString());
//Console.WriteLine(ijs.ToString());
//Console.WriteLine(tiramisu.ToString());

