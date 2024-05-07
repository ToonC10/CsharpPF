/*
using CSharpPFOefeningen;
Voertuig x = new Voertuig();
x.Polishouder = "Toon";
x.Kostprijs = 120000m;
x.Pk = 825;
x.GemiddeldVerbruik = 11.0f;
x.Nummerplaat = "2-DTF-510";

Console.WriteLine(v.GetVoertuigInfo());


//Classes en Objects - Constructors
using CSharpPFOefeningen;
Voertuig v1 = new Voertuig();
Voertuig v2 = new Voertuig("Jan", 10000m, 75, 6.0f, "1-ABC-123");
Console.WriteLine(v1.GetVoertuigInfo());
Console.WriteLine();
Console.WriteLine(v2.GetVoertuigInfo());


//Init only properties - Object initializers
using CSharpPFOefeningen;

Voertuig v1 = new Voertuig
{
    Polishouder = "Jan",
    Kostprijs = 10000m,
    Pk = 75,
    GemiddeldVerbruik = 6.0f,
    Nummerplaat = "1-ABC-123"
};

Voertuig v2 = new Voertuig
{
    Polishouder = "Piet",
    Kostprijs = 15000m,
    Pk = 80,
    GemiddeldVerbruik = 7.5f,
    Nummerplaat = "1-DEF-456"
};

Console.WriteLine(v1.GetVoertuigInfo());
Console.WriteLine();
Console.WriteLine(v2.GetVoertuigInfo());


using CSharpPFOefeningen;
Vrachtwagen vw = new Vrachtwagen("Jan", 40000m, 500, 30, "1-ABC-123", 10000);
Personenwagen pw = new Personenwagen("Piet", 15000m, 8, 6.5f,"1-DEF-4156", 5, 5);

Console.WriteLine(vw.GetVoertuigInfo());
Console.WriteLine();
Console.WriteLine(pw.GetVoertuigInfo());


using CSharpPFOefeningen;
Vrachtwagen vw = new Vrachtwagen("Jan", 40000m, 500, 30, "1-ABC-123", 10000);
Personenwagen pw = new Personenwagen("Piet", 15000m, 8, 6.5f,
 "1-DEF-4156", 5, 5);
Voertuig[] voertuigen = new Voertuig[2];
voertuigen[0] = vw;
voertuigen[1] = pw;
foreach (Voertuig voertuig in voertuigen)
{
    Console.Write($"{voertuig.GetVoertuigInfo()}\n");
    Console.WriteLine($"Kyotoscore: {voertuig.GetKyotoScore()}");
    Console.WriteLine();
}


//Interfaces
using CSharpPFOefeningen;
Vrachtwagen vw = new Vrachtwagen("Jan", 40000m, 500, 30, "1-ABC-123", 10000);
Personenwagen pw = new Personenwagen("Piet", 15000m, 8, 6.5f, "1-DEF-4156", 5, 5);

IVervuiler[] vervuilers = new IVervuiler[3];
vervuilers[0] = vw;
vervuilers[1] = pw;
vervuilers[2] = new Stookketel(7.5f);

foreach (IVervuiler vervuiler in vervuilers)
{
    Console.WriteLine($"Vervuiling: {vervuiler.GeefVervuiling()}");
}

*/
//Interfaces: vervolg
using CSharpPFOefeningen;

Vrachtwagen vw = new Vrachtwagen("Jan", 40000m, 500, 30, "1-ABC-123", 10000);
Personenwagen pw = new Personenwagen("Piet", 15000m, 8, 6.5f, "1-DEF-4156", 5, 5);

IPrivaat[] privategegevens = new IPrivaat[2];
privategegevens[0] = vw;
privategegevens[1] = pw;

Console.WriteLine("Private gegevens:");
foreach (IPrivaat voertuig in privategegevens)
{
    Console.WriteLine(voertuig.GeefPrivateData());
}
Console.WriteLine();

IMilieu[] milieugegevens = new IMilieu[2];
milieugegevens[0] = vw;
milieugegevens[1] = pw;

Console.WriteLine("Milieugegevens:");
foreach (IMilieu voertuig in milieugegevens)
{
    Console.WriteLine(voertuig.GeefMilieuData());
}