namespace CSharpPFOefeningen;
public class Zichtrekening : Rekening
{
    private decimal maxKrediet;
    public decimal MaxKrediet
    {
        get
        {
            return maxKrediet;
        }
        set
        {
            if (value > 0m)
                throw new Exception("De waarde van MaxKrediet mag niet positief zijn!");
            maxKrediet = value;
        }
    }
    public Zichtrekening(string nummer, decimal saldo, DateOnly creatieDatum, decimal maxKrediet, Klant eigenaar): base(nummer, saldo, creatieDatum, eigenaar)
    {
        MaxKrediet = maxKrediet;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Max.krediet: {MaxKrediet}";
    }
}