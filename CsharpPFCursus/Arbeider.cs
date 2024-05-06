using CSharpPFCursus;

namespace CsharpPFCursus;
public class Arbeider : Werknemer
{

    private decimal uurloon;
    public decimal Uurloon
    {
        get
        {
            return uurloon;
        }
        set
        {
            if (value >= 0m)
                uurloon = value;
        }
    }

    private byte ploegenstelsel;
    public byte Ploegenstelsel
    {
        get
        {
            return ploegenstelsel;
        }
        set
        {
            if (value >= 1 && value <= 3)
                ploegenstelsel = value;
        }
    }

    public Arbeider(string naam, DateTime inDienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) : base(naam, inDienst, geslacht)
    {
        Uurloon = uurloon;
        Ploegenstelsel = ploegenstelsel;
    }

    public override decimal Premie
    {
        get
        {
            return Uurloon * 150m;
        }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
            $"Uurloon: {Uurloon}\n" +
            $"Ploegenstelsel: {Ploegenstelsel}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Uurloon} euro/uur";
    }


}
