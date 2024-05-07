using CSharpPFCursus;
using System.Diagnostics.CodeAnalysis;
//using static CsharpPFCursus.Werknemer.WerkRegime;
namespace Firma.Personeel;

public abstract partial class Werknemer: IKost
{
    // propfull tab tab
    private string naam;
    //public required string Naam voor required ipv
    public string Naam
    {
        get => naam;
        //init => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";   <-- gaat ook
        init
        {
            if (value != string.Empty)
            naam = value;
        }
    }
    
    private static DateOnly personeelsfeest;
    public static DateOnly Personeelsfeest
    {
        set
        {
            personeelsfeest = value;
        }
        get
        {
            return personeelsfeest;
        }
    }
    
    //of een auto property
    //public static DateOnly Personeelsfeest { get; set; }
    //of een expression-bodied property
    //private static DateOnly personeelsfeest;
    //of
    //public static DateOnly Personeelsfeest
    //{
    // set => personeelsfeest = value;
    // get => personeelsfeest;
    //}

    static Werknemer()
    {
        Personeelsfeest = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
        Personeelsfeest = Personeelsfeest.AddDays(1);
    }

//prop tab tab
    public DateTime InDienst { get; set; }
    public Geslacht Geslacht { get; set; }

    public bool VerjaarAncien
    {
        get {
            return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
        }
    }

    public Afdeling Afdeling { get; set; }

    public virtual string GetInfo()
    {
        return $"Naam: {Naam}\n" +
        $"Geslacht: {Geslacht}\n" +
        $"In dienst: {InDienst}\n" +
        $"Personeelsfeest: {Personeelsfeest}\n" +
        $"{Afdeling?.ToString() ?? "Onbekende afdeling"}";
    }

    public WerkRegime Regime { get; set; }

    //ctor tab tab
    /*
    public Werknemer()
    {
        Naam = "Onbekend";
        InDienst = DateTime.Today;
    }
    of
    */
    //Default constructor
    public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
    {
    }
    

    /*
    //Voor Constructor met een reference type parameter
    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht, Afdeling afdeling)
    {
        Naam = naam;
        InDienst = inDienst;
        Geslacht = geslacht;
        Afdeling = afdeling;
    }
    */

    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
    {
        Naam = naam;
        InDienst = inDienst;
        Geslacht = geslacht;
    }

    /*
    public override string ToString()
    {
        return $"{Naam} {Geslacht}";
    }
    */

    //Generated
    public override bool Equals(object? obj)
    {
        return obj is Werknemer werknemer &&
               Naam == werknemer.Naam;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Naam);
    }

    public bool Menselijk
    { 
        get { return true; } 
    }
    //of
    //public bool Menselijk => true;

    public abstract decimal BerekenKostprijs();

    /*
//zelfgeschreven
public override bool Equals(object? obj)
{
   if (obj is Werknemer)
   {
       Werknemer deAndere = (Werknemer)obj;
       return this.Naam == deAndere.Naam;
   }
   else
       return false;
}

public override int GetHashCode()
{
   return Naam.GetHashCode();
}
*/

    public abstract decimal Premie
    {
        get;
    }

    /*
    public static class Rekenaar
    {
        public static int Kwadraat(int getal) { return getal * getal; }
    }
    */
}

/*
//Nested class Werkregime in een partial class
public abstract partial class Werknemer
{
    public class WerkRegime
    {
        public enum RegimeType
        {
            Voltijds,
            Viervijfde,
            Halftijds
        }
        public required RegimeType Type { get; set; }
        public int AantalVakantiedagen
        {
            get
            {
                switch (Type)
                {
                    case RegimeType.Voltijds:
                        return 25;
                    case RegimeType.Viervijfde:
                        return 20;
                    case RegimeType.Halftijds:
                        return 12;
                    default:
                        return 0;
                }
            }
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
*/