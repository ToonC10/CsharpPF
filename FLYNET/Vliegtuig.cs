namespace FLYNET.Vloot;
internal class Vliegtuig : IKost
{
    public required string Type { get; set; }
    public required int KruisSnelheid { get; set; }
    public required int VliegBereik { get; set; }
    public decimal BasisKostPrijsPerDag { get; init; }

    public decimal BerekenTotaleKostPrijsPerDag()
    {
        return BasisKostPrijsPerDag;
    }
}
