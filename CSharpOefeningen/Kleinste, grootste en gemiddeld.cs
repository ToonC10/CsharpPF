/*
int getal;
//invoer eerste getal
do
{
    Console.Write("Typ een positief geheel getal of -1 (= stoppen): ");
    getal = int.Parse(Console.ReadLine());
}
while (getal < 0 && getal != -1);
int kleinste = getal, grootste = getal, totaal = 0, aantal = 0;
while (getal != -1)
{
    if (getal < kleinste)
        kleinste = getal;
    else if (getal > grootste)
        grootste = getal;
    totaal += getal;
    aantal++;
    //een volgend getal inlezen
    do
    {
        Console.Write("Typ een positief geheel getal of -1 (= stoppen): ");
        getal = int.Parse(Console.ReadLine());
    }
    while (getal < 0 && getal != -1);
}
if (aantal > 0)
{
    Console.WriteLine("Het kleinste getal: {0}", kleinste);
    Console.WriteLine("Het grootste getal: {0}", grootste);
    Console.WriteLine("Het gemiddelde: {0}", (double)totaal / aantal);
}
else
    Console.WriteLine("Er werden geen getallen ingevoerd.");
*/
