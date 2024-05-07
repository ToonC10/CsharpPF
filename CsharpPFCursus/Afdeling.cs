namespace Firma.Personeel;

 //Constructor met parameters (Class Afdeling met een constructor met parameters)
public class Afdeling
{
    public const int Verdiepingen = 10;
 public Afdeling(string naam, int verdieping)
    {
        Naam = naam;
        Verdieping = verdieping;
    }
    public string Naam { get; set; }
    private int verdieping;
    public int Verdieping
    {
        get { return verdieping; }
        set
        {
            if (value >= 0 && value <= Verdiepingen)
        verdieping = value;
        }
    }
    public override string ToString()
    {
        return $"Afdeling: {Naam} op verdieping {Verdieping}";
    }
}


//Via object initializers (Class Afdeling met required properties:)
/*
public class Afdeling
{
    public const int Verdiepingen = 10;
    public required string Naam { get; set; }

    private int verdieping;
    public required int Verdieping
    {
        get { return verdieping; }
        set
        {
            if (value >= 0 && value <= Verdiepingen)
                verdieping = value;
        }
    }
    public override string ToString()
    {
        return $"Afdeling: {Naam} op verdieping {Verdieping}";
    }
}
*/