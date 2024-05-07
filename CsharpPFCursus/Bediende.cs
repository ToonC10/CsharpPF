using CsharpPFCursus;

namespace Firma.Personeel;
public class Bediende : Werknemer
{
    /*
    //Voor Constructor met een reference type parameter
    public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde, Afdeling afdeling): base(naam, indienst, geslacht, afdeling)
    {
        Wedde = wedde;
    }
    */

    public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde) : base(naam, indienst, geslacht)
    {
        Wedde = wedde;
    }

    private decimal wedde;
    public decimal Wedde
    {
        get
        {
            return wedde;
        }
        set
        {
            if (value >= 0m)
                wedde = value;
        }
    }

    public override decimal Premie
    {
        get
        {
            return Wedde* 2m;
        }
    }


    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Wedde: {Wedde}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Wedde} euro/maand";
    }

    public override decimal BerekenKostprijs()
    {
        return Wedde * 12m;
    }

}
