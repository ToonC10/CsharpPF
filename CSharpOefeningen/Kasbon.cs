namespace CSharpPFOefeningen;
public class Kasbon : ISpaarmiddel
{
    private readonly DateTime EersteAankoop = new DateTime(1900, 1, 1);
    private DateTime aankoopDatum;
    public DateTime AankoopDatum
    {
        get { return aankoopDatum; }
        set
        {
            if (value < EersteAankoop)
                throw new Exception($"De aankoopdatum mag niet voor {EersteAankoop.ToShortDateString()} zijn!");
            aankoopDatum = value;
        }
    }
    private decimal bedrag;
    public decimal Bedrag
    {
        get { return bedrag; }
        set
        {
            if (value <= 0m)
                throw new Exception("Het bedrag moet positief zijn!");
            bedrag = value;
        }
    }
    private int looptijd;
    public int Looptijd
    {
        get { return looptijd; }
        set
        {
            if (value <= 0)
                throw new Exception("De looptijd moet positief zijn!");
            looptijd = value;
        }
    }
    private decimal intrest;
    public decimal Intrest
    {
        get { return intrest; }
        set
        {
            if (value <= 0m)
                throw new Exception("Intrest moet positief zijn!");
            intrest = value;
        }
    }
    public Klant Eigenaar { get; set; }
    public Kasbon(DateTime aankoopDatum, decimal bedrag,
    int looptijd, decimal intrest, Klant eigenaar)
    {
        AankoopDatum = aankoopDatum;
        Bedrag = bedrag;
        Looptijd = looptijd;
        Intrest = intrest;
        Eigenaar = eigenaar;
    }
    public string GetInfo()
    {
        string eigenaar = Eigenaar?.GetKlantInfo() ?? "onbekend";
        return $"Eigenaar: {eigenaar}\n" +
        $"Aankoopdatum: {AankoopDatum:dd-MM-yyyy}\n" +
        $"Bedrag: {Bedrag}\n" +
        $"Looptijd: {Looptijd}\n" +
        $"Intrest: {Intrest}";
    }
}