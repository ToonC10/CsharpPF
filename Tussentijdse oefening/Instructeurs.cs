namespace Tussentijdse_oefening;
internal class Instructeurs : Personeel
{
    public Vakgebied VakGebied { get; }

    private string email;

    public string Email
    {
        get => email;
        set
        {
            if (value != string.Empty)
                //foreach (char letter in Email)
                    if(Email.Contains('@'))
                    {
                        email = value;
                    }
                    else
                    {
                        Console.WriteLine("Verkeerde ingave email");
                    }
        }
    }

    public Instructeurs(int personeelsNummer, string naam, string familieNaam, decimal brutoMaandLoon, Vakgebied vakGebied, string email): base (personeelsNummer, naam, familieNaam, brutoMaandLoon)
    {
        VakGebied = vakGebied;
        //Email = email;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}" +
        $"Instructeur: {VakGebied} (e-mail: {email})\n";
    }

    public override string ToString()
    {
        return $"{base.ToString()}" + 
            $"Instructeur: {VakGebied} (e-mail: {email})";
    }

    /*
    public override decimal BerekenKostprijs()
    {
        return base.BerekenKostprijs() + Bonus;
    }
    */
}
