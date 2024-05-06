﻿//een voorbeeld
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

using CsharpPFCursus;
using CSharpPFCursus;
using static CsharpPFCursus.Werknemer;
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

*/
