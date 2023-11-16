 

Console.WriteLine("inserisci dati");

List<string?> datiUtenteStringList = new ();
List<int> datiUtenteInteriList = new List<int>();

int numUtenti;

for(int i = 0; i < 10; i++)
{
    string? datiUtente = Console.ReadLine();
    if (int.TryParse(datiUtente, out numUtenti))
{
    datiUtenteInteriList.Add(numUtenti);
}
else
{
    datiUtenteStringList.Add(datiUtente);
}

}
string? elements = string.Join(", ", datiUtenteStringList);
string elemInt = string.Join(", ", datiUtenteInteriList.Select(x => x.ToString()));

Console.WriteLine($"hai inserito queste parole: {elements}\n e questi numeri{elemInt}");

datiUtenteInteriList.Reverse();
datiUtenteStringList.Reverse();

string? elementst = string.Join(", ", datiUtenteStringList);
string elemIntt = string.Join(", ", datiUtenteInteriList.Select(x => x.ToString()));

Console.WriteLine($"hai inserito queste parole: {elementst}\n e questi numeri: {elemIntt}");

