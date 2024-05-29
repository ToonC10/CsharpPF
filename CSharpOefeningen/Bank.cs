using CSharpPFOefeningen;

namespace CSharpOefeningen;
public class Bank
{
    public required int BankId { get; init; }
    public required string Naam { get; set; }

    public void RekeningUittrekselTonen(Rekening rekening)
    {
        Console.WriteLine($"Datum: {DateTime.Today.ToShortDateString()}");
        Console.WriteLine($"Rekeninguittreksel van rekening {rekening.Nummer}");
        Console.WriteLine($"Vorig saldo: {rekening.VorigSaldo} euro");

        if (rekening.Saldo > rekening.VorigSaldo)
        {
            Console.WriteLine($"Storting van {rekening.Saldo - rekening.VorigSaldo} euro.");
        }
        else
        {
            Console.WriteLine($"Afhaling van {rekening.VorigSaldo - rekening.Saldo} euro.");
        }
        Console.WriteLine($"Nieuw saldo: {rekening.Saldo} euro");
    }

    public void RekeningInHetRoodMelden(Rekening rekening)
    {
        Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend!");
        Console.WriteLine($"Maximum af te halen bedrag: {rekening.Saldo} euro");
    }
}

