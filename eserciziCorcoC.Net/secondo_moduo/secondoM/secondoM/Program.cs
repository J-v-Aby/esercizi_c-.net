//                                                          MODULO 2
//                                         esercizio 1 
/*
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

*/
//                                                  esercizio 2 

string[] nomi = new string[4];
int[] eta = { 23, 66, 45,50};
object[] mixed = new object[10];

nomi[0] = "giovanni";           
nomi[1] = "aldo";              
nomi[2] = "giacomo";           
nomi[3] = "franco";

 Array.Copy(nomi, mixed, 3);
Array.Copy(eta,1, mixed, 4, 3); //4 e' la posizioni nella arrey in cui inizi a copire 


foreach (string e in nomi)
{
    Console.WriteLine(e);

}


foreach (int e in eta)
{
    Console.WriteLine(e);

}

foreach (var m in mixed)
{ 
    Console.WriteLine(m);
}

/*
                                                                // esercizio 3

using System.Runtime.InteropServices;

Queue<string?> userQueue = new Queue<string?>();

while (true)
{
    Console.WriteLine("digita un numero e fa la tua scelta");
    Console.WriteLine("1 - per aggiungere un elemnto");
    Console.WriteLine("2 - per eliminare un elemnto");
    Console.WriteLine("3 - per vedere l'elemento in coda");

    string? userInput = Console.ReadLine();


    var controlling = char.IsDigit(userInput[0]); // char.IsDigit() buleano che verifica se il primo carattere e' un numero 
    if (controlling == false)
    {
        Console.WriteLine("scelta non valida");
    }
    else
    {
        char scelta = userInput[0];

        switch (scelta)
        {
            case '1':
                Console.WriteLine("aggiungi elemento");
                string? elementonew= Console.ReadLine();
                userQueue.Enqueue(elementonew);
                Console.WriteLine($"Elemento '{elementonew}' aggiunto alla coda.");
                break;
            case '2':
                if (userQueue.Count > 0)
                {
                    string? elementoRimosso = userQueue.Dequeue();
                    Console.WriteLine($"Elemento {elementoRimosso} rimosso dalla coda.");
                }
                else
                {
                    Console.WriteLine("La coda è vuota. Impossibile rimuovere.");
                }
                break;
            case '3':
                if (userQueue.Count > 0)
                {
                    string? elementoInCima = userQueue.Peek();
                    Console.WriteLine($"Elemento in cima alla coda: {elementoInCima}");
                }
                else
                {
                    Console.WriteLine("La coda è vuota. Impossibile visualizzare.");
                }
                break;
            default:
                Console.WriteLine("Scelta non valida.");
                break;
        }
    }
}

                                                                // esercizio 4

using System.Xml.Schema;

Stack<string?> userStack = new Stack<string?>();

while (true)
{
    Console.WriteLine("digita un numero e fa la tua scelta");
    Console.WriteLine("1 - per aggiungere un elemnto");
    Console.WriteLine("2 - per eliminare un elemnto");
    Console.WriteLine("3 - per vedere l'elemento in coda");

    string? userInput = Console.ReadLine();


    var controlling = char.IsDigit(userInput[0]); // char.IsDigit() buleano che verifica se il primo carattere e' un numero 
    if (controlling == false)
    {
        Console.WriteLine("scelta non valida");
    }
    else
    {
        char scelta = userInput[0];

        switch (scelta)
        {
            case '1':
                Console.WriteLine("aggiungi elemento");
                string? elementonew = Console.ReadLine();
                userStack.Push(elementonew);
                Console.WriteLine($"Elemento '{elementonew}' aggiunto alla coda.");
                break;
            case '2':
                if (userStack.Count > 0)
                {
                    string? elementoRimosso = userStack.Pop();
                    Console.WriteLine($"Elemento {elementoRimosso} rimosso dalla coda.");
                }
                else
                {
                    Console.WriteLine("La coda è vuota. Impossibile rimuovere.");
                }
                break;
            case '3':
                if (userStack.Count > 0)
                {
                    string? elementoInCima = userStack.Peek();
                    Console.WriteLine($"Elemento in cima alla coda: {elementoInCima}");
                }
                else
                {
                    Console.WriteLine("La coda è vuota. Impossibile visualizzare.");
                }
                break;
            default:
                Console.WriteLine("Scelta non valida.");
                break;
        }
    }
}

                                                                // esercizio 7

HashSet<string> nomi=new HashSet<string>();
nomi.Add("marco");
nomi.Add("marco");
nomi.Add("Marco"); 
nomi.Add("Marco"); 
nomi.Add("marcO");
nomi.Add("marcO");

foreach (string s in nomi)
{
    Console.WriteLine(s);
}foreach (string s in nomi)
{
    Console.WriteLine( $"esempio : {s.ToLower()}");   
    // non li considera duplicati perche sono dati memorizzati diversamente, anche se vengono stamapti uguali
}







                                                                // esercizio 8

List<int> numList = new List<int>();
Random random = new Random();

for(int i=0; i<=1000; i++)
{
  int  randomNumeri= random.Next(1, 1000000);
    numList.Add(randomNumeri);
}
    int min = numList.Min();
    int max = numList.Max();

Console.WriteLine($"il minimo in questa lista e': {min} mentre il massimo e': {max}");
*/