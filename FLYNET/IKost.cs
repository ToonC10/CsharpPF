namespace FLYNET;
internal interface IKost
{
        public decimal BasisKostPrijsPerDag { get; init; }

        public decimal BerekenTotaleKostPrijsPerDag();
}
