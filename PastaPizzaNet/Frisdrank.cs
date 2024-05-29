namespace PastaPizzaNet;
internal class Frisdrank : Drank
{
    const decimal PrijsFrisDrank = 2m;
    public Frisdrank(Enums.Drank naam) : base(naam)
    {
    }

    private Enums.Drank naam;
    public override Enums.Drank Naam
    {
        get { return naam; }
        set
        {
            if (value == Enums.Drank.water || value == Enums.Drank.limonade || value == Enums.Drank.cocacola)
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
        get
        {
            return PrijsFrisDrank;
        }
    }
}
