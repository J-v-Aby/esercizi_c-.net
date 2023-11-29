// esercizio 6

using System.Runtime.ConstrainedExecution;

string? urlPath = "C:\\Users\\pc\\Documents\\DEVELHOP PACKAGES\\eserciziCorcoC.Net\\secondo_moduo\\dictionary\\dictionary\\file.txt";

List<string> listaDiNomi = File.ReadAllLines(urlPath).Select(s => s.ToLower()).ToList();
// o in alternativa: string[] listaDiNomi = File.ReadAllLines(urlPath);

Dictionary<string, int> dic = new Dictionary<string, int>();

foreach (string s in listaDiNomi.SelectMany(s => s.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s))))
//.SelectMany(s=>s.Split(' ')) necessario per prendere un nome alla volta contenuto nella stessa linea
//.Where(s => !string.IsNullOrWhiteSpace(s)) per evitare che vengano contatti anche gli spazi vuoti
{
    if (!dic.ContainsKey(s))
    {
        dic.Add(s, 1);
    }
    else
    {
        dic[s]++;
    }
}
foreach (string d in dic.Keys)
{
    Console.WriteLine($"la parola {d} e' conenuta {dic[d]}");
}


