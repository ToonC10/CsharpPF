namespace PastaPizzaNet;
public class Pasta : Gerecht
{
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

    public Pasta(string naam, decimal prijs, string? omschrijving) : base(naam, prijs)
    {
        Omschrijving = omschrijving;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Omschrijving}";
    }
}
