using CsharpPFCursus;

namespace Firma.Materiaal;
public class Fotokopiemachine : IKost
{
    private int aantalGekopieerdeBlz;
    public int AantalGekopieerdeBlz
    {
        get
        {
            return aantalGekopieerdeBlz;
        }
        set
        {
            if (value >= 0)
                aantalGekopieerdeBlz = value;
        }
    }

    private decimal kostPerBlz;
    public decimal KostPerBlz
    {
        get
        {
            return kostPerBlz;
        }
        set
        {
            if (value > 0)
                kostPerBlz = value;
        }
    }
    public string SerieNr { get; init; }

    public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz, decimal kostPerBlz)
    {
        SerieNr = serieNr;
        AantalGekopieerdeBlz = aantalGekopieerdeBlz;
        KostPerBlz = kostPerBlz;
    }

    public bool Menselijk => false;

    public decimal BerekenKostprijs() => AantalGekopieerdeBlz * KostPerBlz;
}
