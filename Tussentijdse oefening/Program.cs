using Tussentijdse_oefening;

VerlofPeriodes[] verlof = new VerlofPeriodes[2];
verlof[0] = new VerlofPeriodes("Kerstmis", new DateOnly(2023, 12, 25), new DateOnly(2024, 1, 1));
verlof[1] = new VerlofPeriodes("Zomervakantie", new DateOnly(2023, 7, 1), new DateOnly(2023, 7, 31));

foreach (VerlofPeriodes infoVerlof in verlof)
    Console.WriteLine(infoVerlof.GetInfo());


Instructeurs ik = new Instructeurs(1, "Toon", "Claessens", 3000m, Vakgebied.Ontwikkeling, "Toonclaessens@outlook.be");
Console.WriteLine(ik.GetInfo());
Medewerkers jij = new Medewerkers(2, "Toon", "Claessens", 3000m, 4);
Console.WriteLine(jij.GetInfo());
OpleidingsCentrum hier = new OpleidingsCentrum("T2 campus", 1500);
Console.WriteLine(hier.GetInfo());
