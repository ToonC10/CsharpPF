namespace CSharpPFOefeningen;
public class Vrachtwagen : Voertuig
{
    public Vrachtwagen()
    : base()
    {
        MaximumLading = 10000f;
    }
    public Vrachtwagen(string polishouder, decimal kostprijs, int pk,
    float gemiddeldVerbruik, string nummerplaat, float maximumLading)
    : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
    {
        MaximumLading = maximumLading;
    }
    private float maximumLading;
    public float MaximumLading
    {
        get
        {
            return maximumLading;
        }
        set
        {
            if (value >= 0f)
                maximumLading = value;
        }
    }

    public override string GetVoertuigInfo()
    {
        return "Vrachtwagen\n" +
        $"{base.GetVoertuigInfo()}\n" +
        $"Maximum lading: {MaximumLading}";
    }

    public override double GetKyotoScore()
    {
        return MaximumLading != 0 ? (GemiddeldVerbruik * Pk) / (MaximumLading / 1000.0) : 0.0;
    }

    public override double GeefVervuiling()
    {
        return GetKyotoScore() * 20;
    }
}