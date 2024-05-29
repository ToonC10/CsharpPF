namespace PastaPizzaNet;
public abstract class Gerecht : IBedrag
{
    public Gerecht(string naam, decimal prijs)
    {
        Naam = naam;
        Prijs = prijs;
    }

    private string? naam;
    public string? Naam
    {
        get { return naam; }
        set { if (!string.IsNullOrEmpty(value)) naam = value; }
    }

    private decimal prijs;
    public decimal Prijs
    {
        get { return prijs; }
        set { prijs = value; }
    }

    public virtual decimal BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return $"Gerecht: {Naam} {BerekenBedrag()} (euro)";
    }
}
