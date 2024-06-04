namespace FLYNET.Personeel;
internal class CockpitPersoneelslid : VliegendPersoneelslid
{
    public int VliegUren { get; set; }

    public override decimal BerekenTotaleKostPrijsPerDag()
    {
        decimal basisKost = base.BerekenTotaleKostPrijsPerDag();
        decimal percentage = 0m;
        decimal totaleKost;

        switch (Graad)
        {
            case Graad.Captain:
                percentage = 1.3m;
                break;
            case Graad.SeniorFlightOfficer:
                percentage = 1.2m;
                break;
            case Graad.SecondOfficer:
                percentage = 1.1m;
                break;
            case Graad.JuniorFlightOfficer:
                percentage = 1m;
                break;
            default: throw new Exception($"Verkeerde graad ({Graad}), deze behoort niet tot de mogelijke graden van de cockpitcrew (Captain, SeniorFlightOfficer, SecondOfficer of JuniorFlightOfficer)");
        }

        var certificaat = Certificaten.Where(certificaat => certificaat.CertificaatAfkorting == "CPL");
        if (certificaat != null)
        {
            totaleKost = basisKost * percentage + 50m;
        }
        else
        {
            totaleKost = basisKost * percentage;
        }

        return totaleKost;
    }

    public override string ToString()
    {
        string certificaten = "";

        foreach (Certificaat item in Certificaten)
        {
            certificaten += $"  {item.ToString()} \n";
        }

        return base.ToString() +
            $"Graad: {Graad} \n" +
            $"Certificaten: \n" +
            certificaten +
            $"Vlieguren: {VliegUren} \n" +
            $"Totale kostprijs per dag: {BerekenTotaleKostPrijsPerDag()} euro \n \n";
    }
}

