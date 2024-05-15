//een voorbeeld
/*
Console.WriteLine("Hallo"); // ik zei hallo

Console.WriteLine(
 "Hallo");

Console.WriteLine("hal" +
    "lo");

Console.WriteLine("Hallo");

Tekenlijn();

void Tekenlijn()
{
    throw new NotImplementedException();
}


System.Text.StringBuilder bericht =
new System.Text.StringBuilder("hallo");
Console.WriteLine(bericht); //toont hallo
bericht.Append(" iedereen");
Console.WriteLine(bericht); //toont hallo iedereen


string krijger1 = "Asterix";
string krijger2 = "Obelix";
string krijger3 = krijger1.ToLower();
string groteKrijger = "Asterix";
string kleineKrijger = "asterix";
Console.WriteLine(krijger1 == krijger2);
Console.WriteLine(krijger1 == groteKrijger);
Console.WriteLine(krijger1 == kleineKrijger);
Console.WriteLine(krijger1.CompareTo(krijger2));
Console.WriteLine(krijger3);


const float CmInch = 2.54f;
Console.Write("Geef een lengte in cm: ");
float cm = float.Parse(Console.ReadLine());
Console.WriteLine("lengte in inch: " + cm / CmInch);


Console.WriteLine(@"De standaard windows directory is
                                  c:\windows");


string tekst = null;
Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft True
tekst = string.Empty;
Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft True
tekst = "Hallo";
Console.WriteLine(string.IsNullOrEmpty(tekst)); //geeft False


string tekst = null;
Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
tekst = string.Empty;
Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
tekst = "\t \n";
Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft True
tekst = "Hallo";
Console.WriteLine(string.IsNullOrWhiteSpace(tekst)); //geeft False


string welkom = """"
 Welkom """Jan"""
 """";
Console.WriteLine(welkom); //Welkom """Jan"""


DateTime beginTijdrekening = new DateTime();
DateTime beginEuro = new DateTime(2000, 1, 1);
DateTime mijnGeboortedatum = new DateTime(1999, 06, 04, 10, 15, 0);
Console.WriteLine(beginTijdrekening);
Console.WriteLine(beginEuro);
Console.WriteLine(mijnGeboortedatum);


DateTime eenDatumTijd = new DateTime(2023, 7, 1, 9, 30, 0);
//Belgische landinstellingen
Console.WriteLine(eenDatumTijd.ToString());
Console.WriteLine(eenDatumTijd.ToShortDateString());
Console.WriteLine(eenDatumTijd.ToLongDateString());
Console.WriteLine(eenDatumTijd.ToShortTimeString());
Console.WriteLine(eenDatumTijd.ToLongTimeString());
Console.WriteLine(eenDatumTijd.ToString("yyyy-MM-dd"));
Console.WriteLine("De datum is {0:dddd d MMMM yyyy}.", eenDatumTijd);
Console.WriteLine($"De datum is {eenDatumTijd:dd-MM-yyyy}.");


DateTime factuurDatum = new DateTime(2023, 2, 1);
Console.WriteLine(factuurDatum.DayOfYear);


DateTime vandaag = DateTime.Today;
Console.WriteLine(vandaag.DayOfWeek);
Console.WriteLine(vandaag.DayOfYear);
Console.WriteLine(vandaag.AddDays(1));


DateTime begindatum = new DateTime(2023, 1, 1, 8, 0, 0);
DateTime einddatum = new DateTime(2023, 2, 1, 12, 30, 50);
Console.WriteLine(begindatum);
Console.WriteLine(einddatum);
Console.WriteLine();
TimeSpan interval = einddatum - begindatum;
Console.WriteLine(interval.ToString());
Console.WriteLine();
Console.WriteLine("aantaldagen: "+ interval.Days); //onderdeel aantal dagen
Console.WriteLine("totaal dagen : " + interval.TotalDays); //totaal aantal dagen als een decimaal getal
Console.WriteLine();
Console.WriteLine("aantal uren: " + interval.Hours); //onderdeel aantal uren (range -23 tot 23)
Console.WriteLine("totaal uren: " + interval.TotalHours); //totaal aantal uren
Console.WriteLine();
Console.WriteLine("aantal minuten: " + interval.Minutes); //onderdeel aantal minuten (range -59 tot 59)
Console.WriteLine("totaal minuten: " + interval.TotalMinutes);//totaal aantal minute
Console.WriteLine();
Console.WriteLine("aantal seconden: " + interval.Seconds); //onderdeel seconden (range -59 tot 59)
Console.WriteLine("totaal seconden: " + interval.TotalSeconds);//totaal aantal seconden
Console.WriteLine();
Console.WriteLine("aantal miliseconden: " + interval.Milliseconds);//onderdeel aantal milliseconden (range -999 tot 999)
Console.WriteLine("totaal miliseconden: " + interval.TotalMilliseconds); //totaal aantal milliseconden
Console.WriteLine("ticks: " + interval.Ticks); //1 milliseconde = 10000 ticks


DateOnly factuurdatum = new DateOnly(2023, 2, 1);
DateOnly betaaldatum = factuurdatum.AddDays(60);
Console.WriteLine($"factuurdatum: {factuurdatum.ToShortDateString()}");
Console.WriteLine($"betaaldatum:{betaaldatum.ToShortDateString()}");


TimeOnly begintijd = new TimeOnly(8, 30, 0);
Console.WriteLine($"begintijd: {begintijd}");

Console.WriteLine($"eindtijd: {begintijd.AddHours(7.5).ToLongTimeString()}");
TimeOnly eindtijd = begintijd.Add(new TimeSpan(7, 30, 0));
Console.WriteLine($"eindtijd: {eindtijd.ToLongTimeString()}");


TimeOnly begintijd = new TimeOnly(8, 30);
TimeOnly eindtijd = new TimeOnly(16, 50);
TimeSpan duurtijd = eindtijd - begintijd;
Console.WriteLine($"duurtijd: {duurtijd.Hours} uur en " + $"{duurtijd.Minutes} minuten");


Console.Write("Geef je leeftijd: ");
int leeftijd = int.Parse(Console.ReadLine());
Console.Write("Je bent");
if (leeftijd < 18)
    Console.Write(" niet");
Console.WriteLine(" toegelaten.");


Console.Write("Typ eerste getal: ");
decimal getal1 = decimal.Parse(Console.ReadLine());
Console.Write("Typ tweede getal:");
decimal getal2 = decimal.Parse(Console.ReadLine());
Console.Write("Typ bewerking (+,-,/,: of *):");
char bewerking = char.Parse(Console.ReadLine());
switch (bewerking)
{
    case '+':
        Console.WriteLine(getal1 + getal2);
        break;
    case '-':
        Console.WriteLine(getal1 - getal2);
        break;
    case '*':
        Console.WriteLine(getal1 * getal2);
        break;
    case '/':
    case ':':
        if (getal2 == 0m)
            Console.WriteLine("Delen door nul is niet mogelijk.");
        else
            Console.WriteLine(getal1 / getal2);
        break;
    default:
        Console.WriteLine("Verkeerde bewerking ingetypt.");
        break;
}


Console.Write("Getal tussen 10 en 100? ");
int getal = int.Parse(Console.ReadLine());
string bericht = getal switch
{
 < 0 => "negatief",
 0 => "nul",
 < 10 or > 100 => "een foutief getal",
 >= 10 and <= 50 => "een getal tussen 10 en 50",
 > 50 and <= 100 => "een getal tussen 50 en 100"
};
Console.WriteLine($"Het getal is {bericht}.");


decimal getal, totaal = 0m;
Console.WriteLine("Typ een reeks getallen, stop de reeks met 0:");
while ((getal = decimal.Parse(Console.ReadLine())) != 0m)
 totaal += getal;
Console.WriteLine($"Totaal: {totaal}");

decimal getal, totaal = 0m;
Console.WriteLine("Typ een reeks getallen, stop de reeks met 0:");
do
    totaal += getal = decimal.Parse(Console.ReadLine());
while (getal != 0m) ;
Console.WriteLine($"Totaal: {totaal}");


decimal totaal = 0m;
for (int teller = 1; teller < 11; teller++)
{
    Console.Write("Typ getal {0}: ", teller);
    totaal += decimal.Parse(Console.ReadLine());
}
Console.WriteLine($"Totaal: {totaal}");


Console.Write("Typ een woord: ");
string woord = Console.ReadLine();
bool palindroom = true;
for (int vanafBegin = 0, vanafEinde = woord.Length - 1;
 vanafBegin < vanafEinde; vanafBegin++, vanafEinde--)
    if (woord[vanafBegin] != woord[vanafEinde])
    {
        palindroom = false;
        break;
    }
if (palindroom)
    Console.WriteLine("Dit woord is een palindroom");
else
    Console.WriteLine("Dit woord is geen palindroom");
//korter
Console.Write("Typ een woord: ");
string woord = Console.ReadLine();
int vanafBegin, vanafEinde;
for (vanafBegin = 0, vanafEinde = woord.Length - 1;
 vanafBegin < vanafEinde && woord[vanafBegin] == woord[vanafEinde];
 vanafBegin++, vanafEinde--) ;
if (woord[vanafBegin] == woord[vanafEinde])
    Console.WriteLine("Dit woord is een palindroom");
else
    Console.WriteLine("Dit woord is geen palindroom");


void TekenLijn(int lengte)
{
    for (int teller = 0; teller < lengte; teller++)
 Console.Write('-');
    Console.WriteLine();
}

Console.WriteLine("Asterix");
TekenLijn(7);
Console.WriteLine("Obelix");
TekenLijn(6);
Console.WriteLine("Einde programma");
TekenLijn(15);


void TekenLijn(int lengte, char teken)
{
    for (int teller = 0; teller < lengte; teller++)
        Console.Write(teken);
    Console.WriteLine();
}

Console.WriteLine("Asterix");
TekenLijn(7, '-');
Console.WriteLine("Obelix");
TekenLijn(6, '=');
Console.WriteLine("Einde programma");
TekenLijn(15, '*');


void TekenLijn(int lengte, char teken = '-')
{
    for (int i = 0; i < lengte; i++)
    {
        Console.Write(teken);
    }
    Console.WriteLine();
}

TekenLijn(10, '*');
TekenLijn(10);
TekenLijn('-');
TekenLijn(lengte: 20);
TekenLijn(lengte: 20, teken: '=');

*/
/*
const double CentimetersPerInch = 2.54;
double CmNaarInch(double cm)
{
    return cm / CentimetersPerInch;
}
double InchNaarCm(double inch)
{
    return inch * CentimetersPerInch;
}
*/
/*
Console.Write("Afstand in cm: ");
double cm = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{cm} cm = {CmNaarInch(cm)} inches");
TekenLijn(20);
Console.Write("Afstand in inches: ");
double inches = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{inches} inches = {InchNaarCm(inches)} cm");


void Verwissel(ref int getal1,ref int getal2)
{
    int tussen = getal1;
    getal1 = getal2;
    getal2 = tussen;
}

int eerste = 10, tweede = 20;
Verwissel(ref eerste, ref tweede);
Console.WriteLine(eerste);
Console.WriteLine(tweede);


void VerwisselNaarAndereVariabelen(int getal1, int getal2,
 out int verwisseld1, out int verwisseld2)
{
    verwisseld1 = getal2;
    verwisseld2 = getal1;
}

int eerste = 10, tweede = 20;
VerwisselNaarAndereVariabelen(eerste, tweede,
 out int resultaat1, out int resultaat2);
Console.WriteLine(resultaat1);
Console.WriteLine(resultaat2);
Console.WriteLine(eerste);
Console.WriteLine(tweede);


//const double CentimetersPerInch = 2.54;
Console.Write("Afstand in cm: ");
if (double.TryParse(Console.ReadLine(), out double cm))
{
    Console.WriteLine($"{CmNaarInch(cm)} inches");
}
else
{
    Console.WriteLine("Geen correct getal");
}


TimeOnly begintijd = new TimeOnly(8, 30, 0);
Console.WriteLine($"begintijd: {begintijd}");
TimeOnly eindtijd = begintijd.Add(
 new TimeSpan(50, 30, 0), out int aantalDagen);
Console.WriteLine($"eindtijd: {eindtijd} en {aantalDagen} dag(en) later");


int grootste, kleinste;
Console.Write("Geef een eerste getal: ");
int getal1 = int.Parse(Console.ReadLine());
Console.Write("Geef een tweede getal: ");
int getal2 = int.Parse(Console.ReadLine());
Console.WriteLine("Deling grootste door kleinste: ");
if (getal1 > getal2)
{
    grootste = getal1;
    kleinste = getal2;
}
else
{
    grootste = getal2;
    kleinste = getal1;
}
if (kleinste != 0)
    Console.WriteLine(grootste / kleinste);
else
    Console.WriteLine("Delen door nul kan niet!");


int teller = 1;
while (teller <= 100)
{
    Console.WriteLine("tot ziens");
 await Task.Delay(2000);
 teller += 1;
}


Console.Write("Typ een woord: ");
string? woord = Console.ReadLine();
Console.WriteLine(woord.Length);

Console.Write("Typ een woord: ");
string? woord = Console.ReadLine(); //nullable variabele
if (woord is not null) //null check
    Console.WriteLine(woord.Length);


//arrays
const int AantalMaanden = 12;
double[] temperaturen = new double[AantalMaanden];
int maand;
for (maand = 1; maand <= AantalMaanden; maand++)
{
    Console.Write("Geef de temperatuur voor maand {0}: ", maand);
    temperaturen[maand - 1] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Je typte volgende temperaturen:");
for (maand = 1; maand <= AantalMaanden; maand++)
    Console.WriteLine($"Maand {maand}: {temperaturen[maand - 1]}");


int[] dagenPerMaand = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
for (int maand = 0; maand < dagenPerMaand.Length; maand++)
    Console.WriteLine(dagenPerMaand[maand]);

int huidigJaar = DateTime.Today.Year;
for (int maand = 1; maand <= 12; maand++)
    Console.WriteLine(DateTime.DaysInMonth(huidigJaar, maand));

//for loop in array
Console.Write("Aantal bankrekeningen:");
int aantalRekeningen = int.Parse(Console.ReadLine());
ulong[] rekeningNrs = new ulong[aantalRekeningen];
for (int teller = 1; teller <= aantalRekeningen; teller++)
{
    Console.Write("Nummer van {0}° rekening: ", teller);
    rekeningNrs[teller - 1] = ulong.Parse(Console.ReadLine());
}
Console.WriteLine("Dit zijn de nummers van je rekeningen:");
foreach (ulong rekeningNr in rekeningNrs)
    Console.WriteLine(rekeningNr);


string[,] hoofdstedenLanden ={{"Cuba","Havana","Spaans"},
 {"Brazilië","Brasilia","Portugees"}};

var hoofdstedenLanden2 = new[,]
 {
    {"Cuba","Havana","Spaans"},
    {"Brazilië","Brasilia","Portugees"}
 };


string[] namen = { "Asterix", "Obelix", "Idefix" };
Console.WriteLine("Beginsituatie:");
foreach (string naam in namen)
    Console.WriteLine(naam);

Array.Sort(namen);
Console.WriteLine("Na Sort:");
foreach (string naam in namen)
    Console.WriteLine(naam);

Array.Reverse(namen);
 Console.WriteLine("Na Reverse:");
foreach (string naam in namen)
    Console.WriteLine(naam);

string[] kopie = new string[namen.Length];
 Array.Copy(namen, kopie, namen.Length);
Console.WriteLine("Kopie:");
foreach (string naam in kopie)
 Console.WriteLine(naam);

Console.WriteLine("Eerste Idefix:" +
 Array.IndexOf(namen, "Idefix"));


Seizoen plukseizoen = Seizoen.Herfst;
Console.WriteLine(plukseizoen);
Console.WriteLine((int)plukseizoen);

*/

//Classes and objects

//using CsharpPFCursus;
//using CSharpPFCursus;
//using static CsharpPFCursus.Werknemer;

/*
Werknemer ik;
ik = new Werknemer();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2023, 1, 1);
Console.WriteLine(ik.Naam);
Console.WriteLine(ik.Geslacht);
Console.WriteLine(ik.InDienst);


Werknemer ik;
ik = new Werknemer();
if (ik is null)
 Console.WriteLine("niet verbonden");
else
    Console.WriteLine("verbonden");
ik = null!;
if (ik is null)
 Console.WriteLine("niet verbonden");
else
    Console.WriteLine("verbonden");

//korter

Werknemer ik;
ik = new Werknemer();
Console.WriteLine(ik is null ? "niet verbonden" : "verbonden");
ik = null!;
Console.WriteLine(ik is null ? "niet verbonden" : "verbonden");


//Werknemer ik = new Werknemer();
//of
Werknemer ik = new();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2023, 1, 1);
Console.WriteLine(ik.Naam);


Werknemer ik = new();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2024, 4, 29);
Console.WriteLine(ik.Naam);
Werknemer mezelf;
mezelf = ik;
Console.WriteLine(mezelf.Naam);
Console.WriteLine(ik == mezelf);
ik = null!;
Console.WriteLine(ik == mezelf);
Console.WriteLine(mezelf.Naam);
Console.WriteLine(mezelf.VerjaarAncien);


//?
int? aantalKinderen = null;
int aantalKamers = aantalKinderen.HasValue ? aantalKinderen.Value : 0;
Console.WriteLine($"Er zijn {aantalKamers} kinderkamers nodig.");

//??
int? aantalKinderen2 = null;
int aantalKamers2 = aantalKinderen2 ?? 0;
Console.WriteLine($"Er zijn {aantalKamers2} kinderkamers nodig.");


Werknemer[] onzeWerknemers = new Werknemer[5];
for (int teller = 0; teller < onzeWerknemers.Length; teller++)
 onzeWerknemers[teller] = new Werknemer();


//Methods
Werknemer ik = new Werknemer();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2023, 1, 1);
Console.WriteLine(ik.GetInfo());


int AantalLijnen = 30;
char teken = '*';
Werknemer ik = new Werknemer();
ik.Naam = "Asterix";
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2023, 1, 1);

Werknemer jij = new Werknemer();
jij.Naam = "Obelix";
jij.Geslacht = Geslacht.Man;
jij.InDienst = new DateTime(2023, 1, 2);

LijnenTrekker lijnenTrekker = new LijnenTrekker();

Console.WriteLine(ik.GetInfo());
lijnenTrekker.TekenLijn(AantalLijnen, teken);

Console.WriteLine(jij.GetInfo());
lijnenTrekker.TekenLijn(79, '=');

lijnenTrekker.TekenLijn();
lijnenTrekker.TekenLijn(10);


LijnenTrekker lijnenTrekker = new LijnenTrekker();
lijnenTrekker.TekenLijn(teken: '*', lengte: 10);


//optionele parameters
LijnenTrekker lijnenTrekker = new LijnenTrekker();
lijnenTrekker.TekenLijn(10, '*');
lijnenTrekker.TekenLijn(10);
lijnenTrekker.TekenLijn(lengte: 30);
lijnenTrekker.TekenLijn(lengte: 40, teken: '=');


Omzetter omzetter = new Omzetter();
Console.Write("Afstand in cm: ");
double cm = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches");
LijnenTrekker lijnenTrekker = new LijnenTrekker();
lijnenTrekker.TekenLijn();
Console.Write("Afstand in inches: ");
double inches = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{omzetter.InchNaarCm(inches)} cm");


int eerste = 10, tweede = 20;
Verwisselaar verwisselaar = new Verwisselaar();
verwisselaar.Verwissel(ref eerste, ref tweede);
Console.WriteLine(eerste);
Console.WriteLine(tweede);


Werknemer ik = new Werknemer();
Console.WriteLine(ik.GetInfo());
Console.WriteLine(ik.Naam.ToUpper());


Werknemer ik = new Werknemer("Asterix", new DateTime(2023, 1, 1), Geslacht.Man);
Console.WriteLine(ik.GetInfo());
Werknemer jij = new Werknemer();
Console.WriteLine(jij.GetInfo());


Werknemer ik = new() //ipv Werknemer ik = new Werknemer()
{
    Naam = "Asterix",
    InDienst = new DateTime(2023, 7, 1),
    Geslacht = Geslacht.Man
};


Werknemer ik = new()
{
    Naam = "Asterix" //kan ook nog null zijn
};
ik.Geslacht = Geslacht.Man;
ik.InDienst = new DateTime(2023, 7, 1);
ik.Naam = "Obelix";
Console.WriteLine(ik.GetInfo());

Werknemer jij = new Werknemer("Obelix", new DateTime(2023, 7, 1), Geslacht.Man);


using CSharpPFCursus;
Werknemer ik = new()
{
 Naam = "Asterix",
 InDienst = new DateTime(2023, 7, 1),
 Geslacht = Geslacht.Man
};
ik.Naam = "Obelix";


Werknemer ik = new Werknemer("Asterix", new DateTime(2023, 1, 1), Geslacht.Man);
var persoon = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 };
Console.WriteLine(persoon.GetType().ToString());
Console.WriteLine(persoon.Naam);


Werknemer ik = new Werknemer("Asterix", DateTime.Today, Geslacht.Man);
Werknemer jij = new Werknemer("Obelix", DateTime.Today, Geslacht.Man);
Werknemer.Personeelsfeest = new DateOnly(2024, 12, 12);
Console.WriteLine(Werknemer.Personeelsfeest);
Console.WriteLine(ik.GetInfo());
Console.WriteLine(jij.GetInfo());


Console.WriteLine(Rekenaar.Kwadraat(3));


Arbeider ik = new Arbeider();
Console.WriteLine(ik.GetInfo());


LijnenTrekker lijnenTrekker = new LijnenTrekker();

Arbeider Kevin = new Arbeider("Kevin", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
Console.WriteLine(Kevin.GetInfo());
lijnenTrekker.TekenLijn();

Bediende Ronny = new Bediende("Ronny", new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m);
Console.WriteLine(Ronny.GetInfo());
lijnenTrekker.TekenLijn();

Manager Toon = new Manager("Toon", new DateTime(2024, 1, 26), Geslacht.Man, 19864.89m, 7000m);
Console.WriteLine(Toon.GetInfo());
lijnenTrekker.TekenLijn();


object ik = new Manager("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m, 7000m);
Console.WriteLine(ik is Manager);
Console.WriteLine(ik is Bediende);
Console.WriteLine(ik is Werknemer);
Console.WriteLine(ik is Arbeider);
Console.WriteLine(ik is string);
ik = null!;
Console.WriteLine(ik is Manager);


Manager ik = new Manager("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m, 7000m);
Console.WriteLine(ik); // ipv ik.ToString()


using CSharpPFCursus;
Manager ik = new Manager("Asterix", new DateTime(2023, 1, 1),
 Geslacht.Man, 2400.79m, 7000m);
Manager mezelf = ik;
Manager dezelfde = new Manager("Asterix", new DateTime(2023, 1, 1),
 Geslacht.Man, 2400.79m, 7000m);
Console.WriteLine(ik.Equals(mezelf));
Console.WriteLine(ik.Equals(dezelfde));


Werknemer ik = new Bediende("Asterix", DateTime.Today,
 Geslacht.Man, 1500m);

Werknemer jij = new Arbeider("Obelix", DateTime.Today,
 Geslacht.Man, 10m, 1);

Bediende? hij;

hij = (Bediende)ik;

Console.WriteLine(hij.GetInfo());

//hij = (Bediende)jij;
// Console.WriteLine(hij.GetInfo());

hij = ik as Bediende;
if (hij != null)
 Console.WriteLine(hij.GetInfo());

hij = jij as Bediende;
if (hij != null)
 Console.WriteLine(hij.GetInfo());


Arbeider asterix = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);

Console.WriteLine(asterix.Premie);
Console.WriteLine(obelix.Premie);
Console.WriteLine(idefix.Premie);


Werknemer[] wij = new Werknemer[3];
wij[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
foreach (Werknemer eenWerknemer in wij)
 Console.WriteLine(eenWerknemer.GetInfo());



var land = "belgië";
Console.WriteLine(land.ToUpperFirst());
Console.WriteLine(land.Right(3));


//Afdeling objecten via een constructor met parameters:
Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
Afdeling afdelingFeest = new Afdeling("Feest", 1);

Werknemer[] wij = new Werknemer[3];

wij[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
wij[0].Afdeling = afdelingStrijd;

wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
wij[1].Afdeling = afdelingStrijd;

wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
wij[2].Afdeling = afdelingFeest;

foreach (Werknemer eenWerknemer in wij)
{
    Console.WriteLine(eenWerknemer.GetInfo());
 Console.WriteLine();
}


//Afdeling objecten via object initializers: (Required properties)
Afdeling afdelingStrijd = new Afdeling
{
    Naam = "Strijd",
    Verdieping = 0
};

Afdeling afdelingFeest = new Afdeling
{
    Naam = "Feest",
    Verdieping = 1
};

Werknemer[] wij = new Werknemer[3];
wij[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
wij[0].Afdeling = afdelingStrijd;

wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
wij[1].Afdeling = afdelingStrijd;

wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
wij[2].Afdeling = afdelingFeest;

foreach (Werknemer eenWerknemer in wij)
{
    Console.WriteLine(eenWerknemer.GetInfo());
    Console.WriteLine();
}


//Constructor met een reference type parameter
Afdeling afdelingStrijd = new Afdeling("Strijd", 0);
Arbeider asterix = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3, afdelingStrijd);
Console.WriteLine(asterix.GetInfo());


//Werken met ? Null
Arbeider asterix = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 10m, 1);

string? afdelingsnaam;

if (asterix.Afdeling != null)
{
    afdelingsnaam = asterix.Afdeling.Naam;
    Console.WriteLine($"{asterix.Naam} werkt op de afdeling { afdelingsnaam}");
}

//of
Arbeider asterix2 = new Arbeider("Asterix2", DateTime.Today, Geslacht.Man, 10m, 1);
string? afdelingsnaam2 = asterix2.Afdeling?.Naam;
Console.WriteLine($"{asterix2.Naam} werkt op de afdeling {afdelingsnaam2}");

//?? voor defaultwaarde
Arbeider asterix3 = new Arbeider("Asterix3", DateTime.Today, Geslacht.Man, 10m, 1);
string? afdelingsnaam3 = asterix3.Afdeling?.Naam ?? "onbekende afdeling";
Console.WriteLine($"{asterix3.Naam} werkt op de afdeling {afdelingsnaam3}");


Arbeider ik = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);

ik.Regime = new Werknemer.WerkRegime
{
    Type = Werknemer.WerkRegime.RegimeType.Voltijds
};

Console.WriteLine(ik.Regime);
Console.WriteLine(ik.Regime.AantalVakantiedagen);


//Interface polymorphism
IKost[] kosten = new IKost[4];
kosten[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
kosten[1] = new Bediende("Obelix", new DateTime(2023, 2, 1), Geslacht.Man, 2400.79m);
kosten[2] = new Manager("Idefix", new DateTime(2023, 3, 1), Geslacht.Man, 2400.79m, 7000m);
kosten[3] = new Fotokopiemachine("123", 500, 0.025m);

decimal totaleKost = 0m;
foreach (IKost kost in kosten)
{
    Console.WriteLine(kost.Menselijk);
    Console.WriteLine(kost.BerekenKostprijs());
    totaleKost += kost.BerekenKostprijs();
}

Console.WriteLine(totaleKost);


//Is
Object[] dingen = new Object[3];
dingen[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
dingen[1] = new Fotokopiemachine("Racekyo", 500, 0.025m);
dingen[2] = "C#";

foreach (Object ding in dingen)
 Console.WriteLine(ding is IKost);

*/
/*
Object?[] lijst = new Object?[4];
lijst[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
lijst[1] = new Bediende("Obelix", new DateTime(2023, 2, 1), Geslacht.Man, 2400.79m);
lijst[2] = null;
lijst[3] = "C# 10";

foreach (var item in lijst)
{
    ToonGegevens(item);
}


//method ToonGegevens Klassieke schrijfwijze, geen pattern matching
static void ToonGegevens(Object? obj)
{
    if (obj is Werknemer)
    {
        Werknemer? w = obj as Werknemer;
        Console.WriteLine($"Werknemer {w?.Naam} kost" + $" {w?.BerekenKostprijs()} euro");
    }
    else if (obj is Fotokopiemachine)
    {
        Fotokopiemachine? f = (Fotokopiemachine)obj;
        Console.WriteLine($"Fotokopiemachine {f?.SerieNr} kopieerde " + $"{f?.AantalGekopieerdeBlz} en kost {f?.BerekenKostprijs()} euro");
    }
    else
    {
        Console.WriteLine("onbekend type");
    }
}


//method ToonGegevens met type pattern matching
void ToonGegevens(Object? obj)
{
    if (obj is Werknemer w)
    {
        Console.WriteLine($"Werknemer {w?.Naam} kost {w?.BerekenKostprijs()} euro");
    }
    else if (obj is Fotokopiemachine f)
    {
        Console.WriteLine($"Fotokopiemachine {f?.SerieNr} kopieerde" + $" {f?.AantalGekopieerdeBlz} en kost {f?.BerekenKostprijs()} euro");
    }
    else
    {
        Console.WriteLine("onbekend type");
    }
}



//method ToonGegevens met switch pattern matching
void ToonGegevens(Object? obj)
{
    switch (obj)
    {
        case Werknemer w:
            Console.WriteLine($"Werknemer {w?.Naam} kost " + $"{w?.BerekenKostprijs()} euro"); 
            break;
        case Fotokopiemachine f:
            Console.WriteLine($"Fotokopiemachine {f?.SerieNr} " + $"kopieerde {f?.AantalGekopieerdeBlz} " + $"en kost {f?.BerekenKostprijs()} euro"); 
            break;
        case null:
            Console.WriteLine("Parameter = null");
            break;
        default:
            Console.WriteLine("Onbekend type");
            break;
    }
}


//Case statement uitbreiden met when
Object?[] lijst = new Object?[5];
lijst[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
lijst[1] = new Bediende("Obelix", new DateTime(2023, 1, 1), Geslacht.Man, 1000m);
lijst[2] = new Bediende("Walhalla", new DateTime(2023, 1, 1), Geslacht.Vrouw, 2000m);
lijst[3] = null;
lijst[4] = "C# 10";

foreach (var item in lijst)
{
    switch (item)
    {
        case Arbeider a when a?.Geslacht == Geslacht.Vrouw:
            Console.WriteLine($"{a?.Naam}" + $" is een vrouwelijke arbeider " + $"met een uurloon van {a?.Uurloon} euro");
            break;
        case Arbeider a when a?.Geslacht == Geslacht.Man:
            Console.WriteLine($"{a?.Naam} " + $"is een mannelijke arbeider" + $" met een uurloon van {a?.Uurloon} euro");
            break;
        case Bediende b when b?.Geslacht == Geslacht.Vrouw:
            Console.WriteLine($"{b?.Naam} " + $"is een vrouwelijke bediende" + $" met een wedde van {b?.Wedde} euro");
            break;
        case Bediende b when b?.Geslacht == Geslacht.Man:
            Console.WriteLine($"{b?.Naam} " + $"is een mannelijke bediende " + $"met een wedde van {b?.Wedde} euro");
            break;
        case Werknemer w when w?.Geslacht == Geslacht.Man:
            Console.WriteLine($"{w?.Naam}" + $" is een mannelijke werknemer");
            break;
        case null:
            Console.WriteLine($"null");
            break;
        default:
            Console.WriteLine($"{item} is geen werknemer");
            break;
    }
}


//Namespace veranderd naar Firma
using Firma.Materiaal;
using Firma.Personeel;
using Firma;

Object[] dingen = new Object[3];
dingen[0] = new Firma.Personeel.Arbeider("Asterix", new DateTime(2023, 1, 1), Firma.Personeel.Geslacht.Man, 24.79m, 3);
dingen[1] = new Firma.Materiaal.Fotokopiemachine("123", 500, 0.025m);
dingen[2] = "C#";
foreach (Object ding in dingen)
    Console.WriteLine(ding is Firma.IKost);


//Using
using Firma;
using Firma.Materiaal;
using Firma.Personeel;

Object[] dingen = new Object[3];
dingen[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
dingen[1] = new Fotokopiemachine("123", 500, 0.025m);
dingen[2] = "C#";

foreach (Object ding in dingen)
    Console.WriteLine(ding is IKost);


using static System.Console;
using static System.Math;
double straal = 5.0;

WriteLine($"De omtrek van een cirkel met straal {straal} cm" + $" bedraagt {2 * PI * straal} cm.");


//Enums, verschillende namespaces
Firma.Materiaal.Status statusBoorMachine = Firma.Materiaal.Status.Werkend;
Firma.Personeel.Status statusChef = Firma.Personeel.Status.HogerKader;
Console.WriteLine(statusBoorMachine);
Console.WriteLine(statusChef);

*/
//Using Alias
/*
using Alias=NameSpace;
using Alias=NameSpace.Class;
using Alias=NameSpace.Interface;
using Alias=NameSpace.Enum;

using MateriaalStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;

MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend;
PersoneelStatus statusChef = PersoneelStatus.HogerKader;

Console.WriteLine(statusBoorMachine);
Console.WriteLine(statusChef);


//Exception
//try - catch
decimal getal1, getal2;
Console.Write("eerste getal: ");
getal1 = decimal.Parse(Console.ReadLine()!);
Console.Write("tweede getal: ");
getal2 = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("deling: " + getal1 / getal2);

//opvangen met if (Indien mogelijk is dit de beste manier)(meest perfomante manier)
decimal getal3, getal4;
Console.Write("derde getal: ");
getal3 = decimal.Parse(Console.ReadLine()!);
Console.Write("vierde getal: ");
getal4 = decimal.Parse(Console.ReadLine()!);
if (getal4 != 0m)
    Console.WriteLine($"deling: {getal3 / getal4}");
else
    Console.WriteLine("Delen door nul niet toegelaten");

//try - catch
decimal getal1, getal2;
try
{
    Console.Write("eerste getal: ");
    getal1 = decimal.Parse(Console.ReadLine()!);
    Console.Write("tweede getal: ");
    getal2 = decimal.Parse(Console.ReadLine()!);
    if (getal2 != 0m)
        Console.WriteLine("deling: " + getal1 / getal2);
    else
        Console.WriteLine("Delen door nul niet toegelaten");
}
catch
{
    Console.WriteLine("Je typt geen getal");
}


//try catch exceptions
decimal getal1, getal2;
try
{
    Console.Write("eerste getal :");
    getal1 = decimal.Parse(Console.ReadLine()!);
    Console.Write("tweede getal :");
    getal2 = decimal.Parse(Console.ReadLine()!);
    Console.WriteLine("deling: " + getal1 / getal2);
}
catch (FormatException ex)
{
    Console.WriteLine("Je typt geen getal");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Delen door nul niet toegelaten");
}
catch (Exception)
{
    Console.WriteLine("Een fout heeft zich voorgedaan");
}

//meerdere try opdrachten
decimal getal1, getal2;
try
{
    Console.Write("eerste getal: ");
    getal1 = decimal.Parse(Console.ReadLine()!);
    try
    {
        Console.Write("tweede getal: ");
        getal2 = decimal.Parse(Console.ReadLine()!);
        if (getal2 != 0m)
            Console.WriteLine("deling: " + getal1 / getal2);
        else
            Console.WriteLine("Delen door nul niet toegelaten");
    }
    catch (FormatException)
    {
        Console.WriteLine("Je typt geen getal als tweede getal");
    }
}
catch (FormatException)
{
    Console.WriteLine("Je typt geen getal als eerste getal");
}
*/
//Throw (C# geeft fout en voert rest van de set niet meer uit)
using CsharpPFCursus;
using Firma.Materiaal;
using Firma.Personeel;
using System.Collections;
/*
try
{
    Fotokopiemachine machine = new Fotokopiemachine("123", 100, 5.4m);
    Console.WriteLine("Machine goed ingevuld");
    Console.WriteLine(machine.BerekenKostprijs());
}
catch (Exception ex)
{
    Console.WriteLine("Fout:" + ex.Message);
}

Console.WriteLine("Einde programma");

//fout opvangen in hoofdprogramma
try
{
    Fotokopiemachine machine = new Fotokopiemachine("123", -100, -5.4m);
    Console.WriteLine("Machine goed ingevuld");
    Console.WriteLine(machine.BerekenKostprijs());
}
catch (Exception ex)
{
    Console.WriteLine("Fout:" + ex.Message);
}
Console.WriteLine("Einde programma");


//Eigen exception class ontwerpen (subclass van FotoKopiemachine.cs)
try
{
    Fotokopiemachine machine =
    new Fotokopiemachine("123", -100, -5.4m);
    Console.WriteLine("Machine goed ingevuld");
    Console.WriteLine(machine.BerekenKostprijs());
}
catch (Fotokopiemachine.KostPerBlzException ex)
{
    Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdeKost}");
}
catch (Fotokopiemachine.AantalGekopieerdeBlzException ex)
{
    Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdAantalBlz}");
}
Console.WriteLine("Einde programma");


//Gegarandeerde tijdige opkuis van resources
Console.Write("Provincie: ");
string provincie = Console.ReadLine()!;
try
{
    ProvincieInfo info = new ProvincieInfo();
    Console.WriteLine(info.ProvincieGrootte(provincie));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//Collections en Generics
using Firma.Personeel;
using System.Collections;
Arbeider asterix = new Arbeider("Asterix",new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
Bediende obelix = new Bediende("Obelix",new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m);
Manager idefix = new Manager("Idefix",new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m, 7000m);

List<Werknemer> personeel = new List<Werknemer>();

personeel.Add(asterix);
personeel.Add(obelix);
personeel.Insert(1, idefix);

Console.WriteLine($"{personeel[0].Naam} is de 1ste van {personeel.Count} personeelsleden.");

foreach (Werknemer personeelslid in personeel)
 Console.WriteLine(personeelslid.Naam);

Afdeling eenAfdeling = new Afdeling("Verzending", 0);


//'per ongeluk' in een arraylist personeel stoppen geeft runtime fout

//personeel.Add(eenAfdeling);

//foreach (Werknemer personeelslid in personeel)
//    Console.WriteLine(personeelslid.Naam);


//voorbeelden list
var getallen = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var maanden = new List<string>{"januari", "februari","maart","april", "mei","juni","juli","augustus","september","oktober","november","december"};
var personeel = new List<Werknemer>
{
 new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3),
 new Bediende("Obelix", new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m),
 new Manager("Idefix", new DateTime(2023, 1, 1), Geslacht.Man, 2400.79m, 7000m)
};


// 37.4.1 Een dictionary initialiseren bij de declaratie
Dictionary<int, string> opleidingen = new Dictionary<int, string>()
{
 {1, "Word" },
 {2, "Excel" },
 {3, "Access" }
};
Dictionary<string, string> extensies = new Dictionary<string, string>
{
 {"txt", "Notepad" },
 {"docx","Word" },
 {"xlsx","Excel" }
};
//of

Dictionary<int, string> opleidingen2 = new Dictionary<int, string>()
{
    [1] = "Word",
    [2] = "Excel",
    [3] = "Access"
};
Dictionary<string, string> extensies2 = new Dictionary<string, string>
{
    ["txt"] = "Notepad",
    ["docx"] = "Word",
    ["xlsx"] = "Excel"
};
//elementen toevoegen
opleidingen.Add(4, "Powerpoint");
opleidingen.Add(5, "Outlook"); //ArgumentException

//elementen opvragen
Console.WriteLine(opleidingen[5]); //Excel
Console.WriteLine(extensies["docx"]); //Word
//Console.WriteLine(extensies["xxx"]); //KeyNotFoundException


//trygetvalue
//if (opleidingen.TryGetValue(7, out string? opleiding))
//{
//    Console.WriteLine($"opleiding {opleiding} gevonden");
//}
//else
//{
//    Console.WriteLine("opleiding niet gevonden");
//}

// of 

//Console.WriteLine($"Opleiding {(opleidingen.TryGetValue(8, out string? opleiding) ? opleiding : "niet")} gevonden");

//elementen van een dictionary overlopen
foreach (KeyValuePair<int, string> opleiding in opleidingen)
{
    Console.WriteLine($"Key = {opleiding.Key}, Value = {opleiding.Value}");
}

//of met var

foreach (var opleiding in opleidingen)
{
    Console.WriteLine($"Key = {opleiding.Key}, Value = {opleiding.Value}");
}

//of enkel de keys
foreach (int key in opleidingen.Keys)
{
    Console.WriteLine(key);
}

//of enkel de values
foreach (string opleiding in opleidingen.Values)
{
    Console.WriteLine(opleiding);
}

*/
List<Werknemer>? werknemers = new List<Werknemer>
{
 new Arbeider("Asterix", DateTime.Today,Geslacht.Man,25m,1),
 new Bediende("Obelix",DateTime.Today,Geslacht.Man,1200m)
};
Console.WriteLine($"Aantal werknemers: {werknemers.Count}");

werknemers = null;

//NullReferenceException
//Console.WriteLine($"Aantal werknemers: {werknemers.Count}");
Console.WriteLine($"Aantal werknemers: {werknemers?.Count ?? 0}");