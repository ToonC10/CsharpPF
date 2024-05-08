using System.Dynamic;

namespace Oefening1;
internal abstract partial class Personeel : IKost
{
    private int personeelsNummer;
    public int PersoneelsNummer
    {
        get => personeelsNummer;
        init
        {
            if (value >= 1m)
                personeelsNummer = value;
        }
    }

    private string naam;
    public string Naam
    {
        get => naam;
        set => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";
    }

    private string familieNaam;
    public string FamilieNaam
    {
        get => familieNaam;
        set => familieNaam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende familienaam";
    }

    private decimal brutoMaandLoon;
    public decimal BrutoMaandLoon
    {
        get => brutoMaandLoon;
        set
        {
            if (value >= 0m)
                brutoMaandLoon = value;
        }
    }

    public Personeel(int personeelsNummer, string naam, string familieNaam, decimal brutoMaandLoon)
    {
        PersoneelsNummer = personeelsNummer;
        Naam = naam;
        FamilieNaam = familieNaam;
        BrutoMaandLoon = brutoMaandLoon;
    }

    public Personeel() : this(-1, "Onbekend", "Onbekend", 0)
    {
    }

    
    public virtual string Gegevens()
    {
        return $"PersoneelsNummer: {PersoneelsNummer}\n" +
        $"Naam: {Naam} {FamilieNaam}\n" +
        $"Bruto maandloon: {BrutoMaandLoon}\n";
    }

    public decimal Kost { get => brutoMaandLoon * 0.6m; }

    //Ik snap niet waarom ik deze erbij moet zetten, anders geeft het fout
    decimal IKost.Kost()
    {
        throw new NotImplementedException();
    }
}
