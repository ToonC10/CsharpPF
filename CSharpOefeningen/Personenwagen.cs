namespace CSharpPFOefeningen;
public class Personenwagen : Voertuig
{
    public Personenwagen()
    : base()
    {
        AantalDeuren = 4;
        AantalPassagiers = 5;
    }
    public Personenwagen(string polishouder, decimal kostprijs, int pk,
    float gemiddeldVerbruik, string nummerplaat,
    int aantalDeuren, int aantalPassagiers)
    : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
    {
        AantalDeuren = aantalDeuren;
        AantalPassagiers = aantalPassagiers;
    }
    private int aantalDeuren;
    public int AantalDeuren
    {
        get
        {
            return aantalDeuren;
        }
        set
        {
            if (value > 0)
            {
                aantalDeuren = value;
            }
        }
    }
    private int aantalPassagiers;
    public int AantalPassagiers
    {
        get
        {
            return aantalPassagiers;
        }
        set
        {
            if (value >= 0)
            {
                aantalPassagiers = value;
            }
        }
    }

    public override string GetVoertuigInfo()
    {
        return "Personenwagen\n" +
        $"{base.GetVoertuigInfo()}\n" +
        $"Aantal Deuren: {AantalDeuren}\n" +
        $"Aantal passagiers: {AantalPassagiers}";
    }

    public override double GetKyotoScore()
    {
        return AantalPassagiers != 0 ? (GemiddeldVerbruik * Pk) / AantalPassagiers : 0.0;
    }
}