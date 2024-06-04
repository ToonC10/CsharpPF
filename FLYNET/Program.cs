//****************************************************************************************
// Certificaten
//****************************************************************************************

using FLYNET;
using FLYNET.Personeel;
using FLYNET.Vloot;

Certificaat PPL = new()
{
    CertificaatAfkorting = "PPL",
    CertificaatOmschrijving = "Private Pilot License"
};


Certificaat ATPL = new()
{
    CertificaatAfkorting = "ATPL",
    CertificaatOmschrijving = "Airline Transport Pilot License"
};

Certificaat IR = new()
{
    CertificaatAfkorting = "IR",
    CertificaatOmschrijving = "Instrument Rating"
};

Certificaat CPL = new()
{
    CertificaatAfkorting = "CPL",
    CertificaatOmschrijving = "Commercial Pilot License"
};

Certificaat ME = new()
{
    CertificaatAfkorting = "ME",
    CertificaatOmschrijving = "Multi Engine"
};

Certificaat MCC = new()
{
    CertificaatAfkorting = "MCC",
    CertificaatOmschrijving = "Multi Crew Concept"
};

Certificaat EHBO = new()
{
    CertificaatAfkorting = "EHBO",
    CertificaatOmschrijving = "First Aid"
};

Certificaat EVAC = new()
{
    CertificaatAfkorting = "EVAC",
    CertificaatOmschrijving = "Evacution Procedures"
};

Certificaat FIRE = new()
{
    CertificaatAfkorting = "FIRE",
    CertificaatOmschrijving = "Fire Fighting"
};


Certificaat SURV = new()
{
    CertificaatAfkorting = "SURV",
    CertificaatOmschrijving = "Survival"
};


Certificaat IFS = new()
{
    CertificaatAfkorting = "IFS",
    CertificaatOmschrijving = "In Flight Service"
};

// PERSONEEL

CockpitPersoneelslid persoonCockpit1 = new()
{
    PersoneelsID = 1,
    Naam = "Captain Kirk",
    Graad = Graad.Captain,
    Certificaten = [PPL, ATPL, CPL, SURV],
    BasisKostPrijsPerDag = 500m,
    VliegUren = 5000
};

CockpitPersoneelslid persoonCockpit2 = new()
{
    PersoneelsID = 2,
    Naam = "Spock",
    Graad = Graad.SecondOfficer,
    Certificaten = [PPL, ATPL, CPL, IFS],
    BasisKostPrijsPerDag = 400m,
    VliegUren = 4500
};

CabinePersoneelslid persoonCabine1 = new()
{
    PersoneelsID = 3,
    Naam = "Pavel Chekov",
    Graad = Graad.Purser,
    Certificaten = [ME, MCC, EHBO, IFS],
    BasisKostPrijsPerDag = 300m,
    Werkpositie = "deur1"
};

CabinePersoneelslid persoonCabine2 = new()
{
    PersoneelsID = 4,
    Naam = "Luke SkyWalker",
    Graad = Graad.Steward,
    Certificaten = [FIRE, SURV, IFS, EHBO],
    BasisKostPrijsPerDag = 300m,
    Werkpositie = "nooduitgang",
};

//Console.WriteLine(persoonCockpit1.ToString());
//Console.WriteLine(persoonCockpit2.ToString());
//Console.WriteLine(persoonCabine1.ToString());
//Console.WriteLine(persoonCabine2.ToString());

//VLIEGTUIGEN

Vliegtuig vliegtuig1 = new()
{
    Type = "Airbus A330-200",
    KruisSnelheid = 870,
    VliegBereik = 10800,
    BasisKostPrijsPerDag = 4000m
};

Vliegtuig vliegtuig2 = new()
{
    Type = "Airbus A320",
    KruisSnelheid = 840,
    VliegBereik = 6100,
    BasisKostPrijsPerDag = 3000m
};

Vliegtuig vliegtuig3 = new()
{
    Type = "Boeing 737-800",
    KruisSnelheid = 820,
    VliegBereik = 6204,
    BasisKostPrijsPerDag = 2500m
};

Vliegtuig vliegtuig4 = new()
{
    Type = "Boeing 787-700",
    KruisSnelheid = 820,
    VliegBereik = 6370,
    BasisKostPrijsPerDag = 2000m
};

//Console.WriteLine(vliegtuig1.ToString());
//Console.WriteLine(vliegtuig2.ToString());
//Console.WriteLine(vliegtuig3.ToString());
//Console.WriteLine(vliegtuig4.ToString());

//MAATSCHAPPIJEN

Vliegmaatschappij BrusselsAirlines = new()
{
    VliegmaatschappijID = 1,
    VliegmaatschappijNaam = Maatschappij.BrusselsAirlines,
    Vloot = [vliegtuig1, vliegtuig2],
};

Vliegmaatschappij TUIFly = new()
{
    VliegmaatschappijID = 2,
    VliegmaatschappijNaam = Maatschappij.TUIFly,
    Vloot = [vliegtuig3, vliegtuig4],
};

//VLUCHTEN

Vlucht Vlucht1 = new()
{
    VluchtID = 1,
    Bestemming = "New York",
    Vliegmaatschappij = BrusselsAirlines,
    Vliegtuig = vliegtuig1,
    DuurtijdInDagen = 2,
    Personeel = [ persoonCockpit1, persoonCockpit2, persoonCabine1]
};

Vlucht Vlucht2 = new()
{
    VluchtID = 2,
    Bestemming = "Sydney",
    Vliegmaatschappij = TUIFly,
    Vliegtuig = vliegtuig3,
    DuurtijdInDagen = 3,
    Personeel = [persoonCockpit2, persoonCabine2, persoonCockpit1]
};

Vlucht Vlucht3 = new()
{
    VluchtID = 3,
    Bestemming = "Singapore",
    Vliegmaatschappij = BrusselsAirlines,
    Vliegtuig = vliegtuig2,
    DuurtijdInDagen = 1,
    Personeel = [persoonCockpit1, persoonCabine2]
};

//PRINT VLUCHTEN

//List<Vlucht> vluchten = [vlucht1, vlucht2, vlucht3];

//foreach (var vlucht in vluchten)
//{
//    Console.WriteLine(vlucht.ToString());
//}

Console.WriteLine(Vlucht1.ToString());
Console.WriteLine(Vlucht2.ToString());
Console.WriteLine(Vlucht3.ToString());