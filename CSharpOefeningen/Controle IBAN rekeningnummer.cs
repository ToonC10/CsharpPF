/*
const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string ibanRekeningNr, controleNr;
ibanRekeningNr = "BE23 7390 1021 3491";
controleNr = ibanRekeningNr.Replace(" ", "");
controleNr = controleNr.Substring(4) +
 controleNr.Substring(0, 4);
//Vervang letters
System.Text.StringBuilder nr = new System.Text.StringBuilder();
char teken;
for (int teller = 0; teller < controleNr.Length; teller++)
{
    teken = controleNr[teller];
    if (teken >= 'A' && teken <= 'Z')
    {
        nr.Append(ALFABET.IndexOf(teken) + 10);
    }
    else
    {
        nr.Append(teken);
    }
}
controleNr = nr.ToString();
Console.WriteLine(ulong.Parse(controleNr) % 97ul == 1 ?
 "geldig rekeningnummer" : "geen geldig rekeningnummer");
*/