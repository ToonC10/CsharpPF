namespace CSharpPFOefeningen;
public class Voertuig
{
    public string Polishouder { get; init; }
    private decimal kostprijs;
    public Voertuig() : this("onbepaald", 0m, 0, 0f, "onbepaald")
    {
    }
    public Voertuig(string polishouder, decimal kostprijs,
    int pk, float gemiddeldVerbruik, string nummerplaat)
    {
        Polishouder = polishouder;
        Kostprijs = kostprijs;
        Pk = pk;
        GemiddeldVerbruik = gemiddeldVerbruik;
        Nummerplaat = nummerplaat;
    }
    public decimal Kostprijs
    {
        get
        {
            return kostprijs;
        }
        set
        {
            if (value > 0m)
            {
                kostprijs = value;
            }
        }
    }
    private int pk;
    public int Pk
    {
        get
        {
            return pk;
        }
        set
        {
            if (value >= 0)
            {
                pk = value;
            }
        }
    }
    private float gemiddeldVerbruik;
    public float GemiddeldVerbruik
    {
        get
        {
            return gemiddeldVerbruik;
        }
        set
        {
            if (value >= 0f)
            {
                gemiddeldVerbruik = value;
            }
        }
    }
    public string Nummerplaat { get; set; }
    public string GetVoertuigInfo()
    {
        return $"Polishouder: {Polishouder}\n" +
        $"Kostprijs: {Kostprijs}\n" +
        $"Aantal pk: {Pk}\n" +
        $"Gemiddeld verbruik: {GemiddeldVerbruik}\n" +
        $"Nummerplaat: {Nummerplaat}";
    }
}