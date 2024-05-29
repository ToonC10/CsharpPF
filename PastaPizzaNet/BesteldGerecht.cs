using Enums;
using System.Drawing;
using System.Text;

namespace PastaPizzaNet;
public class BesteldGerecht : IBedrag
{
    private const decimal PrijsPerExtra = 1m;
    private const decimal PrijsGroot = 3m;

    public BesteldGerecht(Gerecht gerecht, Grootte grootte, List<Extra>? extras)
    {
        Gerecht = gerecht;
        Grootte = grootte;
        Extras = extras;
    }

    public Gerecht Gerecht { get; set;}

    public Grootte Grootte { get; set;}


    private List<Extra>? extras;

    public List<Extra>? Extras
    {
        get { return extras;}
        set { extras = value;}
    }

    public decimal BerekenBedrag()
    {
        decimal totaalBedrag = 0m;

        if (Gerecht != null)
        {
            totaalBedrag = Gerecht.BerekenBedrag();
            if (Grootte == Grootte.groot)
            {
                totaalBedrag += PrijsGroot;
            }
            if (Extras != null)
            {
                totaalBedrag += Extras.Count * PrijsPerExtra;
            }
        }
        return totaalBedrag;
    }

    public override string ToString()
    {
        if (Gerecht != null)
        {
            StringBuilder bon = new();
            bon.Append($"{Gerecht.ToString()} ({Grootte})");
            if (Extras != null)
            {
                bon.Append($" extra: {string.Join(' ', Extras)}");
            }
            bon.Append($" (bedrag: {BerekenBedrag()} euro)");
            return bon.ToString();
        }
        else
        {
            return "Onbekend gerecht\n";
        }
    }
}
