namespace Oefening1;
internal class VerlofPeriodes
{
    private string naam;
    public string Naam
    {
        get => naam;
        set => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";
    }

    private DateOnly beginVerlof;
    public DateOnly BeginVerlof
    {
        get => beginVerlof;
        set => beginVerlof = value;
    }

    private DateOnly eindVerlof;
    public DateOnly EindVerlof
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

    public string GetInfo()
    {
        return $"VerlofPeriode: {Naam} van {BeginVerlof} - {EindVerlof}";
    }
}
