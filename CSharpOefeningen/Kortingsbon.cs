/*
Console.Write("Voer het aankoopbedrag in: ");
decimal aankoopBedrag = Decimal.Parse(Console.ReadLine());
decimal kortingsPercentage;
kortingsPercentage = aankoopBedrag switch
{
    < 25m => 0.01m,
    < 50m => 0.02m,
    < 100m => 0.03m,
    >= 100 => 0.05m
};
Console.WriteLine($"Je korting bedraagt: " +
 $"{aankoopBedrag * kortingsPercentage} euro");
*/