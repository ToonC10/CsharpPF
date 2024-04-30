/*
char[] sleutel ={'Q','S','P','A','T', 'V','X','B','C','R','J','Y','E','D','U', 'O','H','Z','G','I','F','L','N','W','K','M'};
Console.Write("Voer je tekst in:");
string tekst = Console.ReadLine().ToUpper();
string gecodeerd = string.Empty;
for (int teller = 0; teller < tekst.Length; teller++)
    if (tekst[teller] >= 'A' && tekst[teller] <= 'Z')
        gecodeerd += sleutel[(int)tekst[teller] - (int)'A'];
    else
        gecodeerd += tekst[teller];
Console.WriteLine($"In code: {gecodeerd}");
*/