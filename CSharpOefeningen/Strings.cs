// zonder Stringbuilder
/*
Console.Write("Familienaam? ");
string naam = Console.ReadLine();
Console.Write("Telefoonnummer? ");
string zonenummer = Console.ReadLine();
zonenummer = zonenummer.Substring(1, 2);
Console.Write("Postcode? ");
string postcode = Console.ReadLine();

string wachtwoord =
 (naam.Substring(1, 1).ToLower() + naam.Substring(0, 1).ToUpper() + zonenummer + Math.Pow(int.Parse(postcode.Substring(postcode.Length - 1, 1)), 2)).Insert(3, "*");

Console.WriteLine($"Het wachtwoord is {wachtwoord}.");



// met stringbuilder

using System.Text;
Console.Write("Familienaam? ");
string naam = Console.ReadLine();
Console.Write("Zonenummer van je telefoonnummer? ");
string zonenummer = Console.ReadLine();
Console.Write("Postcode? ");
string postcode = Console.ReadLine();
StringBuilder wachtwoord = new StringBuilder();
wachtwoord.Append(naam.Substring(1, 1).ToLower());
wachtwoord.Append(naam.Substring(0, 1).ToUpper());
wachtwoord.Append(zonenummer.Replace("0", ""));
wachtwoord.Append(Math.Pow(
 int.Parse(postcode.Substring(postcode.Length - 1, 1)), 2));
wachtwoord.Insert(3, "*");
Console.WriteLine($"Het wachtwoord is {wachtwoord}.");
*/