namespace Oefening1;
internal class Instructeurs : Personeel
{
    public Vakgebied VakGebied { get; }

    private string email;

    public string Email
    {
        get => email;
        set
        {
                if (email.Contains('@'))
                {
                    email = value;
                }
        }
    }

    public Instructeurs(int personeelsNummer, string naam, string familieNaam, decimal brutoMaandLoon, Vakgebied vakGebied, string eMail) : base(personeelsNummer, naam, familieNaam, brutoMaandLoon)
    {
        VakGebied = vakGebied;
        email = eMail;
    }

    public override string Gegevens()
    {
        return $"{base.Gegevens()}" +
        $"Instructeur: {VakGebied} (e-mail: {email})\n" +
        $"Maandelijkse kost: {Kost} euro\n";
    }
}