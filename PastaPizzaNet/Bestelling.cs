using System.Text;

namespace PastaPizzaNet;
public class Bestelling : IBedrag
{
    public Bestelling(Klant? klant, BestelGerecht? gerecht, Drank? drank, Dessert? dessert, int aantal = 1)
    {
        Aantal = aantal;
        Klant = klant;
        Gerecht = gerecht;
        Drank = drank;
        Dessert = dessert;
    }

    public int Aantal { get; set; }

    public Klant? Klant { get; set; }

    public BestelGerecht? Gerecht { get; set; }

    public Drank? Drank { get; set; }

    public Dessert? Dessert { get; set; }

    public decimal BerekenBedrag()
    {

        decimal totaalPrijs = 0m;

        if (Gerecht != null)
        {
            totaalPrijs += Gerecht.BerekenBedrag();
        }
        if (Drank != null)
        {
            totaalPrijs += Drank.BerekenBedrag();
        }
        if (Dessert != null)
        {
            totaalPrijs += Dessert.BerekenBedrag();
        }

        if (Gerecht == null || Drank == null || Dessert == null)
        {
            return totaalPrijs * Aantal;
        }
        else
        {
            return totaalPrijs * 0.9m * Aantal;
        }
    }

    public override string ToString()
    {
        StringBuilder bon = new();
        if (Klant != null)
        {
            bon.Append($"{Klant.ToString()}\n");
        }
        else
        {
            bon.Append("Onbekende Klant\n");
        }
        if (Gerecht != null)
        {
            bon.Append($"{Gerecht.ToString()}\n");
        }
        if (Drank != null)
        {
            bon.Append($"{Drank.ToString()}\n");
        }
        if (Dessert != null)
        {
            bon.Append($"{Dessert.ToString()}\n");
        }
        bon.Append($"Aantal: {Aantal}\n");
        bon.Append($"Bedrag van deze bestelling: {BerekenBedrag()} euro \n");

        return bon.ToString();
    }

}
