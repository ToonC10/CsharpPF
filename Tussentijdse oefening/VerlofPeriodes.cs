namespace Tussentijdse_oefening;
internal class VerlofPeriodes : Personeel
{
    private string naam;
    public string Naam
    {
        get => naam;
        set => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";
    }

    private static DateOnly beginVerlof;
    public static DateOnly BeginVerlof
    {
        get => beginVerlof;
        set => beginVerlof = value;
    }

    private static DateOnly eindVerlof;
    public static DateOnly EindVerlof
    {
        get => eindVerlof;
        set => eindVerlof = value;
    }

    public VerlofPeriodes(string naam, DateOnly beginVerlof, DateOnly eindVerlof)
    {
        Naam = naam;
        BeginVerlof = beginVerlof;
        EindVerlof = eindVerlof;
    }

    public override string GetInfo()
    {
        return $"VerlofPeriode: {Naam} van {BeginVerlof} - {EindVerlof}";
    }
}
