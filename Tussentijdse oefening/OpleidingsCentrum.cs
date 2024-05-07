namespace Tussentijdse_oefening;
internal class OpleidingsCentrum
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

    public virtual string GetInfo()
    {
        return $"Gebouw {Naam} - Huurprijs per maand: {HuurPrijsPerMaand}\n" +
             $"Maandelijkse Kost: {HuurPrijsPerMaand}";
    }
}
