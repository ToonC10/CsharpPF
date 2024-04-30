using CSharpPFCursus;
namespace CsharpPFCursus;

public class Werknemer
{
    // propfull tab tab
    private string naam;

    public string Naam
    {
        get => naam;
        set
        {
            if (value != string.Empty)
            naam = value;
        }
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

    public string GetInfo()
    {
        return  $"Naam: {Naam}\n" +
                $"Geslacht: {Geslacht}\n" + 
                $"In dienst: {InDienst}";
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
}
