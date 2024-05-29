
namespace PastaPizzaNet;
public abstract class Drank : IBedrag
{
    public Drank(Enums.Drank naam)
    {
        Naam = naam;
    }


    public abstract Enums.Drank Naam { get; set; }  

    public abstract decimal Prijs { get; }

    public decimal BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return $"Drank: {Naam} ({BerekenBedrag()} euro)";
    }
}
