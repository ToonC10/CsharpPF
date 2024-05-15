
namespace CSharpPFOefeningen;
public abstract class Rekening: ISpaarmiddel
{

    public Klant Eigenaar { get; set; }

    private readonly DateOnly EersteCreatie = new DateOnly(1900, 1, 1);
    public Rekening(string nummer, decimal saldo, DateOnly creatieDatum, Klant eigenaar)
    {
        Nummer = nummer;
        Saldo = saldo;
        CreatieDatum = creatieDatum;
        Eigenaar = eigenaar;
    }

    private string nummer;
    public string Nummer
    {
        get => nummer;
        init
        {
            if (!IsGeldigRekeningNummer(value))
            {
                throw new Exception("Ongeldig rekeningnummer!");
            }
            nummer = value;
        }
    }
    public decimal Saldo { get; set; }

    private DateOnly creatieDatum;
    public DateOnly CreatieDatum
    {
        get
        {
            return creatieDatum;
        }
        set
        {
            if (value < EersteCreatie)
                throw new Exception($"De creatiedatum mag niet voor " +
                $"{EersteCreatie.ToShortDateString()} zijn!");
            creatieDatum = value;
        }
    }
    private bool IsGeldigRekeningNummer(string rekeningNummer)
    {
        if (string.IsNullOrWhiteSpace(rekeningNummer))
            return false;
        if (rekeningNummer.Length != 16)
            return false;
        if (rekeningNummer[..2] != "BE")
            return false;
        if (!int.TryParse(rekeningNummer.Substring(2, 2),
        out int derdevierdeteken))
            return false;
        if (!ulong.TryParse(rekeningNummer.Substring(4, 12),
        out ulong belgischRekeningNummer))
            return false;
        ulong eerste10 = belgischRekeningNummer / 100ul;
        int laatste2 = (int)(belgischRekeningNummer % 100ul);
        return (int)(eerste10 % 97ul) == laatste2;
    }
    public virtual string GetInfo()
    {
        string eigenaar = Eigenaar?.GetKlantInfo() ?? "onbekend";
        return $"Eigenaar: {eigenaar}\n" +
        $"Rekeningnummer: {Nummer}\n" +
        $"Saldo: {Saldo}\n" +
        $"Creatiedatum: {CreatieDatum.ToShortDateString()}";
    }
    public void Storten(decimal bedrag)
    {
        Saldo += bedrag;
    }
}