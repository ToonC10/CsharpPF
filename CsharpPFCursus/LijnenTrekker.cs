namespace CsharpPFCursus;
public class LijnenTrekker
{
    public void TekenLijn(int lengte = 30, char teken = '-')
    {
        for (int i = 0; i<lengte; i++)
        {
            Console.Write(teken);
        }
        Console.WriteLine();
    }
}
