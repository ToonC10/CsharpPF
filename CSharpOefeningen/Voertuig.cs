namespace CSharpPFOefeningen;
public class Voertuig
{
    public string Polishouder { get; set; }
    private decimal kostprijs;
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