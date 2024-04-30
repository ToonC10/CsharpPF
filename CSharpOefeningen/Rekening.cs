namespace CSharpPFOefeningen;
public class Rekening
{
    private readonly DateOnly EersteCreatie = new DateOnly(1900, 1, 1);

    private string nummer;
    public string Nummer
    {
        get => nummer;
        set
        {
            if (IsGeldigRekeningNummer(value))
            {
                nummer = value;
            }
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
            if (value >= EersteCreatie)
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
        return $"Rekeningnummer: {Nummer}\n" +
        $"Saldo: {Saldo}\n" +
        $"Creatiedatum: {CreatieDatum.ToShortDateString()}";
    }
    public void Storten(decimal bedrag)
    {
        Saldo += bedrag;
    }
}
