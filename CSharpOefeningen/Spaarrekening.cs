namespace CSharpPFOefeningen;
public class Spaarrekening : Rekening
{
    private static decimal intrest;
    public static decimal Intrest
    {
        get
        {
            return intrest;
        }
        set
        {
            if (value >= 0m)
                intrest = value;
        }
    }

    public Spaarrekening(string nummer, decimal saldo, DateOnly creatieDatum, Klant eigenaar) : base(nummer, saldo, creatieDatum, eigenaar)
    {
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Intrest: {Intrest}";
    }
}