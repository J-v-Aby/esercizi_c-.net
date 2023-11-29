using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml;
Console.WriteLine("\n primo esercizio modulo 3\n");//query sintax

Random random = new Random();

List<int> list = Enumerable.Range(0, 1000).Select(list => random.Next(1001)).ToList();
//Il simbolo _ è spesso utilizzato quando il nome del parametro non è utilizzato ex: Select(_ => random.Next(1001)).ToList();

var result = from item in list
             where item % 3 == 0
             select item;

Console.WriteLine(string.Join(" ", result));

Console.WriteLine("\n secondo esercizio modulo 3\n");//sintax

var result2 = list.Where(item => item % 3 == 0);
Console.WriteLine(string.Join(" ", result2));

Console.WriteLine("\n terzo esercizio modulo 3\n");

List<int> list3 = Enumerable.Range(0, 100).Select(l=> random.Next(1001)).ToList();

var sortedList = list3.OrderByDescending(item => item).ToList();
Console.WriteLine("Lista ordinata in modo Decrescente:\n" + string.Join(" ", sortedList));

var longList = list3.OrderBy(item => item).ToList();
Console.WriteLine("\nLista ordinata in modo Crescente:\n" + string.Join(" ", longList));

Console.WriteLine("\n quarto esercizio modulo 3\n");

List<int> list4 = Enumerable.Range(0, 10).Select(l => random.Next(1001)).ToList();

var numeroDiNumeri = list4.Select(item => $"{item} = {item.ToString().Length} carattere");

Console.WriteLine(string.Join(" \n*", numeroDiNumeri));



Console.WriteLine("quinto esercizio modulo 3");

/*List<double> douleList = Enumerable.Range(0, 10).Select(_ => random.NextDouble()).ToList();

Console.WriteLine("Lista di 10 numeri double casuali:");
Console.WriteLine(string.Join(", ", douleList));*/
/*while (true)
{
    Console.WriteLine("Inserisci una lista di numeri double separati da virgola:");
    string? input = Console.ReadLine();

    List<double> doubleList = ParseInput(input);

    if (doubleList.Count > 0)
    {
        double sum = doubleList.Sum();
        double average = doubleList.Average();
        int count = doubleList.Count;

        Console.WriteLine($"Somma: {sum}");
        Console.WriteLine($"Media: {average}");
        Console.WriteLine($"Numero totale di elementi: {count}");
    }
    else
    {
        Console.WriteLine("La lista è vuota o non contiene numeri validi.");
    }


    static List<double> ParseInput(string? input)
    {
        return input.Split(',')
                    .Select(number => double.TryParse(number, out double parsedNumber) ? parsedNumber : 0)
                    .ToList();
    }
}*/

List<List<double>> allLists = new List<List<double>>();

while (true)
{
    Console.WriteLine("Inserisci una lista di numeri double separati da virgola (o 'exit' per uscire):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break; // Uscire dal ciclo se l'utente inserisce "exit"
    }

    List<double> doubleList = ParseInput2(input);

    if (doubleList.Count > 0)
    {
        double sum = doubleList.Sum();
        double average = doubleList.Average();
        int count = doubleList.Count;

        Console.WriteLine($"Somma: {sum}");
        Console.WriteLine($"Media: {average}");
        Console.WriteLine($"Numero totale di elementi: {count}");

        allLists.Add(doubleList); // Aggiungi la lista corrente alla lista più ampia
    }
    else
    {
        Console.WriteLine("La lista è vuota o non contiene numeri validi.");
    }
}

// Fai qualcosa con tutte le liste accumunate (ad esempio, stampale)
Console.WriteLine("Liste accumulate:");
foreach (var list in allLists)
{
    Console.WriteLine(string.Join(", ", list));
}
    }

    static List<double> ParseInput2(string input)
{
    return input.Split(',')
                .Select(number => double.TryParse(number, out double parsedNumber) ? parsedNumber : 0)
                .ToList();
}
