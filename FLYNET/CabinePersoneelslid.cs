namespace FLYNET.Personeel;
internal class CabinePersoneelslid : VliegendPersoneelslid
{
    public string? Werkpositie { get; set; }

    public override decimal BerekenTotaleKostPrijsPerDag()
    {
        decimal basisKost = base.BerekenTotaleKostPrijsPerDag();
        decimal percentage = 0m;
        decimal totaleKost;


        switch (Graad)
        {
            case Graad.Purser:
                percentage = 1.2m;
                break;
            case Graad.Steward:
                percentage = 1m;
                break;
            default: throw new Exception($"Verkeerde graad ({Graad}), deze behoort niet tot de mogelijke graden van de cabincrew (Purser, Steward)");
        }


        var certificaat = Certificaten.Where(certificaat => certificaat.CertificaatAfkorting == "EHBO");
        if (certificaat != null)
        {
            totaleKost = basisKost * percentage + 5m;
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
            $"Werkpositie: {Werkpositie} \n" +
            $"Totale kostprijs per dag: {BerekenTotaleKostPrijsPerDag()} euro \n \n";
    }
}
