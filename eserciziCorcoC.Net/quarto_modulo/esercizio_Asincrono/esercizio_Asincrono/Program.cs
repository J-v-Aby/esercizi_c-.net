Console.WriteLine("Inserisci del testo:");
string? userInput = Console.ReadLine();
string filePath = "C:\\Users\\pc\\Documents\\DEVELHOP PACKAGES\\eserciziCorcoC.Net\\quarto_modulo\\esercizio_Asincrono\\esercizio_Asincrono\\File.txt";

async Task WriteToFileAsync(string content)
{
   _= File.WriteAllTextAsync(filePath, content);
    Console.WriteLine("Testo scritto nel file con successo.");
}
 

await WriteToFileAsync( userInput);// Scrive il testo in un file in modo asincrono usando await 
                                   //(await indica al programma di sospendere l'esecuzione fino
                                   //a quando l'operazione asincrona non è completata

async Task<string> ReadFromFileAsync(string filePath)
{
    string content = await File.ReadAllTextAsync(filePath);
    return content;
}

string fileContent = await ReadFromFileAsync(filePath);


Console.WriteLine($"Contenuto del file: {fileContent}");
    

