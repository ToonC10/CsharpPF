using FLYNET.Personeel;
using FLYNET.Vloot;

namespace FLYNET;
internal class Vlucht
{
    public required int VluchtID { get; set; }
    public required string Bestemming { get; set; }
    public required Vliegmaatschappij Vliegmaatschappij { get; set; }
    public required Vliegtuig Vliegtuig { get; set; }
    public required int DuurtijdInDagen { get; set; }
    public required List<Personeelslid> Personeel { get; set; }


    private decimal TotaalPersoneelsKostPerDag
    {
        get
        {
            decimal PersoneelsKostPerDag = 0m;

            foreach (var persoon in Personeel)
            {
                PersoneelsKostPerDag += persoon.BerekenTotaleKostPrijsPerDag();
            }
            return PersoneelsKostPerDag;
        }
    }

    public decimal BerekenVluchtKost()
    {
        return (Vliegtuig.BerekenTotaleKostPrijsPerDag() + TotaalPersoneelsKostPerDag) * DuurtijdInDagen;
    }

    private decimal KostCockpitCrew
    {
        get
        {
            decimal TotaalCockpit = 0m;

            foreach (var persoon in Personeel)
            {
                if (persoon is CockpitPersoneelslid)
                {
                    TotaalCockpit += persoon.BerekenTotaleKostPrijsPerDag();
                }
            }

            return TotaalCockpit;
        }
    }

    private decimal KostCabinCrew
    {
        get
        {
            decimal TotaalCabin = 0m;

            foreach (var persoon in Personeel)
            {
                if (persoon is CabinePersoneelslid)
                {
                    TotaalCabin += persoon.BerekenTotaleKostPrijsPerDag();
                }
            }

            return TotaalCabin;
        }
    }

    public new string ToString()
    {
        string CockpitCrew = "";
        string CabineCrew = "";

        foreach (var persoon in Personeel)
        {
            if (persoon is CockpitPersoneelslid)
            {
                CockpitCrew += persoon.ToString();
            }
            else
            {
                CabineCrew += persoon.ToString();
            }
        }

        return $"VluchtID: {VluchtID} - Bestemming {Bestemming} ({DuurtijdInDagen} dag(en)) \n \n" +
            $"Vliegmaatschappij: {Vliegmaatschappij.VliegmaatschappijNaam} - Toestel: {Vliegtuig.Type} (basis kostprijs per dag: {Vliegtuig.BerekenTotaleKostPrijsPerDag()} euro) \n" +
            $"Vluchtprijs: {BerekenVluchtKost()} euro \n \n" +
            $"Totale vliegtuigkost: {(Vliegtuig.BerekenTotaleKostPrijsPerDag() * DuurtijdInDagen)} euro \n" +
            $"Totale personeelskost: {(TotaalPersoneelsKostPerDag * DuurtijdInDagen)} euro \n" +
            $"  Totale kost cockpitCrew: {(KostCockpitCrew * DuurtijdInDagen)} euro \n" +
            $"  Totale kost cabineCrew: {(KostCabinCrew * DuurtijdInDagen)} euro  \n " +
            $"\n" +
            "Cockpitpersoneel: \n" +
            CockpitCrew +
            $"\n" +
            "Cabinepersoneel: \n" +
            CabineCrew +
            $"-------------------------------------------------------------------------------------------";
    }
}
