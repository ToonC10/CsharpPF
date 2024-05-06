namespace CSharpPFCursus;
public sealed class Manager : Bediende
{
    public Manager(string naam, DateTime indienst, Geslacht geslacht, decimal wedde, decimal bonus): base(naam, indienst, geslacht, wedde)
    {
        Bonus = bonus;
    }
    private decimal bonus;
    public decimal Bonus
    {
        get
        {
            return bonus;
        }
        set
        {
            if (value > 0m)
                bonus = value;
        }
    }

    public override decimal Premie
    {
        get
        {
            return Bonus * 3m;
        }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Bonus: {Bonus}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Bonus: {Bonus}";
    }
}
