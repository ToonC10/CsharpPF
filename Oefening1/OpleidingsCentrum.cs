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
             $"Maandelijkse Kost: {Kost}\n";
    }

    public decimal Kost { get => HuurPrijsPerMaand; }

    //Ik snap niet waarom ik deze erbij moet zetten, anders geeft het fout (idem zoals bij Personeel.cs)
    decimal IKost.Kost()
    {
        throw new NotImplementedException();
    }
}
