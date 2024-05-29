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

Frisdrank cola = null!;
Frisdrank water = null!;
Frisdrank limonade = null!;

Warmedrank koffie = null!;
Warmedrank thee = null!;



//try
//{
//    cola = new Frisdrank(Enums.Drank.cocacola);
//    water = new Frisdrank(Enums.Drank.water);
//    limonade = new Frisdrank(Enums.Drank.limonade);

//    koffie = new Warmedrank(Enums.Drank.koffie);
//    thee = new Warmedrank(Enums.Drank.thee);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex) { Console.WriteLine(ex.Message); }

cola = new Frisdrank(Enums.Drank.cocacola);
water = new Frisdrank(Enums.Drank.water);
limonade = new Frisdrank(Enums.Drank.limonade);

koffie = new Warmedrank(Enums.Drank.koffie);
thee = new Warmedrank(Enums.Drank.thee);

//Desserten

Dessert cake = new Dessert(Enums.Dessert.cake);
Dessert ijs = new Dessert(Enums.Dessert.ijs);
Dessert tiramisu = new Dessert(Enums.Dessert.tiramisu);




//Probeersel
Console.WriteLine(Jan.ToString());
Console.WriteLine(Piet.ToString());
Console.WriteLine(Onbekend.ToString());
Console.WriteLine();
Console.WriteLine(PizzaMargerita.ToString());
Console.WriteLine(PizzaSalami.ToString());
Console.WriteLine();
Console.WriteLine(PastaBolognaise.ToString());
Console.WriteLine(Carbonara.ToString());
Console.WriteLine(Lasagna.ToString());
Console.WriteLine();
Console.WriteLine(cola.ToString());
Console.WriteLine(water.ToString());
Console.WriteLine(limonade.ToString());
Console.WriteLine(koffie.ToString());
Console.WriteLine(thee.ToString());
Console.WriteLine();
Console.WriteLine(cake.ToString());
Console.WriteLine(ijs.ToString());
Console.WriteLine(tiramisu.ToString());

