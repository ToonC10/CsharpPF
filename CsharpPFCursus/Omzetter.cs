namespace CsharpPFCursus;
public class Omzetter
{
    public const double CentimetersPerInch = 2.54;
    public double CmNaarInch(double cm) => cm / CentimetersPerInch;
    public double InchNaarCm(double inch) => inch * CentimetersPerInch;
}
