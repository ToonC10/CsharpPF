using System.Globalization;

namespace FLYNET.Personeel;
internal abstract class Personeelslid : IKost
{
    public required int PersoneelsID { get; init; }

    public required string Naam { get; init; }

    public decimal BasisKostPrijsPerDag { get; init; }


    public virtual decimal BerekenTotaleKostPrijsPerDag()
    {
        return BasisKostPrijsPerDag;
    }

    public new virtual string ToString() => $"{PersoneelsID} - {Naam} (basiskostprijs per dag: {BasisKostPrijsPerDag.ToString("C2", CultureInfo.CurrentCulture)} euro) \n";
}
