namespace CSharpPFOefeningen;
public class Klant
{
    public required string Voornaam { get; set; }
    public required string Familienaam { get; set; }
    public string GetKlantInfo() => $"{Voornaam} {Familienaam}";
}
/*
of
namespace CSharpPFOefeningen;
public class Klant
{
    public string Voornaam { get; set; }
    public string Familienaam { get; set; }

    public Klant(string voornaam, string familienaam)
    {
        Voornaam = voornaam;
        Familienaam = familienaam;
    }

    public string GetKlantInfo() => $"{Voornaam} {Familienaam}";
}
*/