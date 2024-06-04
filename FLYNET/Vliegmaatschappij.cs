using FLYNET.Vloot;

namespace FLYNET;
internal class Vliegmaatschappij
{
    public int VliegmaatschappijID { get; set; }
    public Maatschappij VliegmaatschappijNaam { get; set; }
    public required List<Vliegtuig> Vloot { get; set; }
}
