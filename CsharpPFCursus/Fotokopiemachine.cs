using CsharpPFCursus;

namespace Firma.Materiaal;
public class Fotokopiemachine : IKost
{
    private int aantalGekopieerdeBlz;
    public int AantalGekopieerdeBlz
    {
        get { return aantalGekopieerdeBlz; }
        set
        {
            if (value < 0)
                throw new AantalGekopieerdeBlzException("Aantal blz. < 0!", value);
            aantalGekopieerdeBlz = value;

        }
    }

    public class AantalGekopieerdeBlzException : Exception
    {
        public int VerkeerdAantalBlz { get; set; }
        public AantalGekopieerdeBlzException(string message,
            int verkeerdAantalBlz) : base(message)
        {
            VerkeerdAantalBlz = verkeerdAantalBlz;
        }
    }

    private decimal kostPerBlz;
    public decimal KostPerBlz
    {
        get { return kostPerBlz; }
        set
        {
            if (value <= 0)
                throw new KostPerBlzException("Kost per blz. <=0!", value);
            kostPerBlz = value;


            kostPerBlz = value;
        }
    }

    public class KostPerBlzException : Exception
    {
        public decimal VerkeerdeKost { get; set; }
        public KostPerBlzException(string message, decimal verkeerdeKost): base(message)
        {
            VerkeerdeKost = verkeerdeKost;
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
