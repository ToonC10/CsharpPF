namespace PastaPizzaNet;
public class Warmedrank : Drank
{
    const decimal PrijsWarmeDrank = 2.5m;
    public Warmedrank(Enums.Drank naam) : base(naam)
    {

    }

    private Enums.Drank naam;
    public override Enums.Drank Naam
    {
        get { return naam; }
        set
        {
            if (value == Enums.Drank.koffie || value == Enums.Drank.thee)
            {
                naam = value;
            }
            else
            {
                throw new ArgumentException("Geen correcte drank");
            }

        }
    }

    public override decimal Prijs
    {
        get { return PrijsWarmeDrank; }
    }
}
