namespace FLYNET.Personeel;
internal class Certificaat
{
    public string? CertificaatAfkorting { get; set; }
    public string? CertificaatOmschrijving { get; set; }
    public new string ToString()
    {
        return $"{CertificaatOmschrijving}  ({CertificaatAfkorting})";
    }
}
