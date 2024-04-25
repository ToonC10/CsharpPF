/*
const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string belgischRekeningNr, ibanRekeningNr,
 ibanRekeningNrControle, controlegetal, controleNr;
ulong rest97;
belgischRekeningNr = "739-0102134-91";
ibanRekeningNrControle = belgischRekeningNr.Replace("-", "") + "BE00";
//vervanging letters door cijfers: A=10, B=11, ...
System.Text.StringBuilder nr = new System.Text.StringBuilder();
char teken;
for (int teller = 0; teller < ibanRekeningNrControle.Length; teller++)
{
    teken = ibanRekeningNrControle[teller];
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
//IBAN rekeningnummer samenstellen
rest97 = ulong.Parse(controleNr) % 97ul;
controlegetal = (98 - rest97).ToString();
ibanRekeningNr = "BE" +
 (controlegetal.Length == 2 ? controlegetal : "0" + controlegetal) +
 ibanRekeningNrControle.Substring(0, ibanRekeningNrControle.Length - 4);
ibanRekeningNr = ibanRekeningNr.Insert(12, "-");
ibanRekeningNr = ibanRekeningNr.Insert(8, "-");
ibanRekeningNr = ibanRekeningNr.Insert(4, "-");

Console.WriteLine($"rekeningnummer: {belgischRekeningNr}" +
 $" als IBAN rekeningnummer: {ibanRekeningNr}");
*/