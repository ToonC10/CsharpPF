namespace Oefening1;
internal class OpleidingsCentrum : IKost
{
    private string naam;
    public string Naam
    {
        get => naam;
        set => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";
    }

    private decimal huurPrijsPerMaand;
    public decimal HuurPrijsPerMaand
    {
        get => huurPrijsPerMaand;
        set
        {
            if (value >= 0m)
                huurPrijsPerMaand = value;
        }
    }

    public OpleidingsCentrum(string naam, decimal huurprijspermaand)
    {
        Naam = naam;
        HuurPrijsPerMaand = huurprijspermaand;
    }

    public virtual string Gegevens()
    {
        return $"Gebouw {Naam} - Huurprijs per maand: {HuurPrijsPerMaand}\n" +
             $"Maandelijkse Kost: {MaandKost}\n";
    }

    public decimal MaandKost { get => HuurPrijsPerMaand; set => throw new NotImplementedException();}

}
