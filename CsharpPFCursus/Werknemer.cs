using CSharpPFCursus;
using System.Diagnostics.CodeAnalysis;
namespace CsharpPFCursus;

public abstract class Werknemer
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

    public virtual string GetInfo()
    {
        return $"Naam: {Naam}\n" +
            $"Geslacht: {Geslacht}\n" +
            $"In dienst: {InDienst}\n" +
            $"Personeelsfeest: {Personeelsfeest}\n ";
    }

    //ctor tab tab
    /*
    public Werknemer()
    {
        Naam = "Onbekend";
        InDienst = DateTime.Today;
    }
    of
    */
    public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
    {
    }

    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
    {
        this.Naam = naam;
        this.InDienst = inDienst;
        this.Geslacht = geslacht;
    }

    public override string ToString()
    {
        return $"{Naam} {Geslacht}";
    }

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
