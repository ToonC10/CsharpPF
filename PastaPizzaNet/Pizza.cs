namespace PastaPizzaNet;
public class Pizza : Gerecht
{
    public Pizza(string naam, decimal prijs, List<string>? onderdelen) : base(naam, prijs)
    {
        Onderdelen = onderdelen;
    }

    private List<string>? onderdelen;
    public List<string>? Onderdelen
    {
        get { return onderdelen; }
        set { onderdelen = value; }
    }

    public override string ToString()
    {
        return $"{base.ToString()} {(Onderdelen != null ? string.Join("#", Onderdelen) : string.Empty)}";
    }
}

