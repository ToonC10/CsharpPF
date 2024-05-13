using Oefening1;
using System.Security.Authentication.ExtendedProtection;
LijnenTrekker Lijn = new LijnenTrekker();
decimal totaal = 0m;

//Verlofperiodes
//var VerlofList
Personeel.VerlofPeriodes = new List<VerlofPeriodes>
{
    new VerlofPeriodes("Kerstmis", new DateOnly(2023, 12, 25), new DateOnly(2024, 1, 1)),
    new VerlofPeriodes("Zomervakantie", new DateOnly(2023, 7, 1), new DateOnly(2023, 7, 31))
};

Console.WriteLine("Collectieve verlofperiodes:");
Lijn.TekenLijn(27);

foreach (var verlof in Personeel.VerlofPeriodes)
{
    Console.WriteLine(verlof.GetInfo());
}
Console.WriteLine();

//Personeel
Console.WriteLine("Kosten personeel en infrastructuur:");
Lijn.TekenLijn(35);

var personeelList = new List<Personeel>
{
    new Instructeurs(1, "Jan", "Jansen", 1500m, Vakgebied.Ontwikkeling, "jan.jansen@vdab.be"),
    new Instructeurs(2, "Roos", "Roosen", 1600m, Vakgebied.Netwerkbeheer, "roos.roosen@vdab.be"),
    new Medewerkers(3, "Piet", "Peeters", 1550m, 10)
};

foreach (var personeel in personeelList)
{
    Console.WriteLine(personeel.Gegevens());
    totaal += personeel.MaandKost;
}

// OpleidingsCentra
var gebouwList = new List<OpleidingsCentrum>
{
    new OpleidingsCentrum("Einstein", 1500m),
    new OpleidingsCentrum("Newton", 2500m)
};

foreach (var gebouw in gebouwList)
{
    Console.WriteLine(gebouw.Gegevens());
    totaal += gebouw.MaandKost;
}

//totale kost
Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaal}");
    