namespace Tussentijdse_oefening;
internal class Medewerkers : Personeel
{
    private int aantalCursisten;
    public int AantalCursisten
    {
        get => aantalCursisten;
        set
        {
            if (value > 0)
                aantalCursisten = value;
        }
    }

    public Medewerkers(int personeelsNummer, string naam, string familieNaam, decimal brutoMaandLoon, int aantalCursisten) : base(personeelsNummer, naam, familieNaam, brutoMaandLoon)
    {
        AantalCursisten = aantalCursisten;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}" +
        $"Aantal cursisten: {aantalCursisten}\n";
    }

}
