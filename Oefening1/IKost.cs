namespace Oefening1;
public interface IKost
{
    // hieronder is fout want is geen function (was gevraagd in oefening)
    //public decimal Kost();
    public decimal MaandKost { get; set; }
    public string Gegevens();
}