namespace PastaPizzaNet;
public class Dessert : IBedrag
{
    public Dessert(Enums.Dessert naam)
    {
        Naam = naam;
    }

    public decimal Prijs
    {
        get
        {
            switch (Naam)
            {
                case Enums.Dessert.tiramisu:
                case Enums.Dessert.ijs:
                    return 3m;
                case Enums.Dessert.cake:
                    return 2m;
                default:
                    return 0m;
            }
        }
    }
    private Enums.Dessert naam;
    public Enums.Dessert Naam
    {
        get
        {
            return naam;
        }
        set
        {
            naam = value;
        }
    }
    public decimal BerekenBedrag()
    {
        return Prijs;
    }
    public override string ToString()
    {
        return $"Dessert: {Naam} ({BerekenBedrag()} euro)";
    }
}
