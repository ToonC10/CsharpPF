/*
Console.Write("Voer jaartal in: ");
int jaar = int.Parse(Console.ReadLine());

string schrikkel;
if (jaar % 4 == 0)
    if (jaar % 100 == 0 && jaar % 400 != 0)
        schrikkel = "geen";
    else
        schrikkel = "een";
else
    schrikkel = "geen";
Console.WriteLine("Het jaar {0} is {1} schrikkeljaar", jaar, schrikkel);

//oplossing coach
Console.WriteLine($"Het jaar {jaar} is " +
 $"{((jaar % 4 == 0 && jaar % 100 != 0) || jaar % 400 == 0 ? "een" : "geen")}" +
 $" schrikkeljaar");
*/