namespace FLYNET.Personeel;

internal abstract class VliegendPersoneelslid : Personeelslid
{
    public required Graad Graad { get; set; }
    public required List<Certificaat> Certificaten { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
