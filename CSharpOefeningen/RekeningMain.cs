
using CSharpPFOefeningen;
/*
Rekening mijnRekening = new Rekening();
mijnRekening.Nummer = "BE40747524091936";
mijnRekening.Saldo = 0m;
mijnRekening.CreatieDatum = DateOnly.FromDateTime(DateTime.Today);
Console.WriteLine(mijnRekening.GetInfo());
mijnRekening.Storten(100m);
Console.WriteLine();
Console.WriteLine(mijnRekening.GetInfo());


//Classes en Objects - Constructors
using CSharpPFOefeningen;
Rekening mijnRekening = new Rekening("BE40747524091936", 0m, DateOnly.FromDateTime(DateTime.Today));
Console.WriteLine(mijnRekening.GetInfo());


//Inheritance
Spaarrekening mijnSpaarrekening = new Spaarrekening("BE40645100000163", 0m, DateOnly.FromDateTime(DateTime.Today));

mijnSpaarrekening.Storten(1000m);

Console.WriteLine(mijnSpaarrekening.GetInfo());
Console.WriteLine();

Zichtrekening mijnZichtrekening = new Zichtrekening("BE40747524091936", 0m, DateOnly.FromDateTime(DateTime.Today), -1000);

mijnZichtrekening.Storten(125m);

Console.WriteLine(mijnZichtrekening.GetInfo());


using CSharpPFOefeningen;
Spaarrekening.Intrest = 3m;
Rekening[] rekeningen = new Rekening[2];
rekeningen[0] = new Zichtrekening("BE40747524091936", 14.51m, DateOnly.FromDateTime(DateTime.Today), -500m);
rekeningen[1] = new Spaarrekening("BE40645100000163", 1000m, DateOnly.FromDateTime(DateTime.Today));
foreach (Rekening rekening in rekeningen)
    Console.WriteLine(rekening.GetInfo());


Spaarrekening.Intrest = 3m;

//Klant ik = new Klant("Piet", "Pienter");
Klant ik = new Klant
{
    Voornaam = "Piet",
    Familienaam = "Pienter"
};

Zichtrekening mijnZichtrekening = new Zichtrekening("BE40747524091936", 14.51m, DateOnly.FromDateTime(DateTime.Today), -500m, ik);
Spaarrekening mijnSpaarrekening = new Spaarrekening("BE40645100000163", 1000m, DateOnly.FromDateTime(DateTime.Today), ik);

Console.WriteLine(mijnZichtrekening.GetInfo());
Console.WriteLine();

Console.WriteLine(mijnSpaarrekening.GetInfo());


//oefening interface
Spaarrekening.Intrest = 3m;

//Klant ik = new Klant("Piet", "Pienter");
Klant ik = new Klant
{
    Voornaam = "Piet",
    Familienaam = "Pienter"
};

ISpaarmiddel[] spaarmiddelen = new ISpaarmiddel[3];

spaarmiddelen[0] = new Zichtrekening("BE40747524091936", 14.51m, DateOnly.FromDateTime(DateTime.Today), -500m, ik);
spaarmiddelen[1] = new Spaarrekening("BE40645100000163", 1000m, DateOnly.FromDateTime(DateTime.Today), ik);
spaarmiddelen[2] = new Kasbon(DateTime.Today, 1000m, 5, 3.5m, ik);

foreach (ISpaarmiddel spaarmiddel in spaarmiddelen)
{
    Console.WriteLine(spaarmiddel.GetInfo());
    Console.WriteLine();
}


//exceptions
try
{
    Spaarrekening.Intrest = 3m;
    //Klant ik = new Klant("Piet", "Pienter");
    Klant ik = new Klant
    {
        Voornaam = "Piet",
        Familienaam = "Pienter"
    };
    ISpaarmiddel[] spaarmiddelen = new ISpaarmiddel[3];
    spaarmiddelen[0] = new Zichtrekening("BE40747524091936", 14.51m,
    DateOnly.FromDateTime(DateTime.Today), -500m, ik);
    spaarmiddelen[1] = new Spaarrekening("BE40645100000163", 1000m,
    DateOnly.FromDateTime(DateTime.Today), ik);
    spaarmiddelen[2] = new Kasbon(DateTime.Today, 1000m, 5, 3.5m, ik);
    foreach (ISpaarmiddel spaarmiddel in spaarmiddelen)
    {
        Console.WriteLine(spaarmiddel.GetInfo());
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

*/