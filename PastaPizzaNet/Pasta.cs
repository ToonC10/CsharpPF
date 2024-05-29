namespace PastaPizzaNet;
public class Pasta : Gerecht
{
    public Pasta(string naam, decimal prijs, string? omschrijving) : base(naam, prijs)
    {
        Omschrijving = omschrijving;
    }

    private string? omschrijving;
    public string? Omschrijving
    {
        get { return omschrijving; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
                omschrijving = value;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Omschrijving}";
    }
}
