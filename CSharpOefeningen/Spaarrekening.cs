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

    public Spaarrekening(string nummer, decimal saldo, DateOnly creatieDatum): base(nummer, saldo, creatieDatum)
    {
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Intrest: {Intrest}";
    }
}