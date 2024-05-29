namespace PastaPizzaNet;
public class Klant
{
    public Klant(int klantId, string klantnaam)
    {
        KlantId = klantId;
        KlantNaam = klantnaam;
    }

    public int KlantId { get; init; }
    public string? KlantNaam { get; set; }

    public override string ToString()
    {
        return $"ID: {KlantId}\n Naam:{KlantNaam}";
    }
}
