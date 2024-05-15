using System.Diagnostics.Metrics;

namespace CsharpPFCursus;
internal class ProvincieInfo
{
    //met using (bastand sluit na using uit zichzelf )
    public int ProvincieGrootte(string provincieNaam)
    {
        using (StreamReader lezer = new StreamReader(@"C:\VS2022-DOTNETPF\provincies.txt"))
 {
            String? regel;
            while ((regel = lezer.ReadLine()) != null)
            {
                int dubbelPuntPos = regel.IndexOf(':');
                string provincie = regel.Substring(0, dubbelPuntPos);
                if (provincie == provincieNaam)
                    return int.Parse(regel.Substring(dubbelPuntPos + 1));
            }
        }
        throw new Exception("Onbestaande provincie:" + provincieNaam);
    }
    /*
    //met finally (finally runt altijd na de try)
    public int ProvincieGrootte(string provincieNaam)
    {
        StreamReader lezer = new
        StreamReader(@"C:\Users\Toon\Desktop\School\VDAB .NET\C#\Taken\VSCode-DOTNETPF\provincies.txt");
        try
        {
            String? regel;
            while ((regel = lezer.ReadLine()) != null)
            {
                int dubbelPuntPos = regel.IndexOf(':');
                string provincie = regel.Substring(0, dubbelPuntPos);
                if (provincie == provincieNaam)
                    return int.Parse(regel.Substring(dubbelPuntPos + 1));
            }
        }
        finally
        {
            lezer.Close();
        }
        throw new Exception("Onbestaande provincie: " + provincieNaam);
    }
    */
}
