namespace CSharpPFOefeningen;
public class Stookketel : IVervuiler
{
    public Stookketel(float cONorm)
    {
        this.CONorm = cONorm;
    }
    private float cONorm;
    public float CONorm
    {
        get
        {
            return cONorm;
        }
        set
        {
            if (value > 0)
            {
                cONorm = value;
            }
        }
    }
    public double GeefVervuiling()
    {
        return CONorm * 100;
    }
}
