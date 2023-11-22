// 1' esercizio                                    Create a "Hello, World!" application
using esercizi;

Console.WriteLine("Hello, World! (esercizio 1");

// 2' esercizio                                         Now it's personal
Console.WriteLine("esercizio 2"); 


Console.WriteLine("Insersci il tuo nome");  

String? userName = Console.ReadLine();

Console.WriteLine($" piacere di conoscerti {userName} mi chiamo C3pO.2 e sono il tuo nuovo assistente virtuale");


// 3' esercizio                                             The match checks out
Console.WriteLine("esercizi 3");

Console.WriteLine("inseri numero ");
String? primoInput = Console.ReadLine();

Console.WriteLine("inseri operatore artimentico (base) ");
String? operatoreInput = Console.ReadLine();

Console.WriteLine("inseri numero ");
String? secondoInput = Console.ReadLine();

bool primo = double.TryParse(primoInput, out double result1);
bool secondo = double.TryParse(secondoInput, out double result2);

if (primo != true || secondo != true)
{
    Console.WriteLine("inserimento numeri non valido");
}
else
{
   switch (operatoreInput)
   {
            case "+":
                double somma = result1 + result2;
                Console.WriteLine($"la somma tra {result1} e {result2} è {somma}");
                break;
            case "-":
                double sottrazione = result1 - result2;
                Console.WriteLine($"la sottrazione tra {result1} e {result2} è {sottrazione}");
                break;
            case "*":
                double moltiplicazione = result1 * result2;
                Console.WriteLine($"la moltiplicazione tra {result1} e {result2} è {moltiplicazione}");
                break;
            case "/":
                double divisione = result1 / result2;
                Console.WriteLine($"la diviione tra {result1} e {result2} è {divisione}");
                break;
            default:
            Console.WriteLine("operatore non valido, scgli:\n   + per addizionare\n   - per sottrarre\n   * per moltiplicare\n   / per dividere");
                return;
   }
    
   
}

// 4' esercizio                                    txet gnitalupinaM
Console.WriteLine("esercizio 4");
Console.WriteLine("Insersci il tuo motto");

String? userQuote = Console.ReadLine();

String reverseQuote = ReverseString(userQuote);

string ReverseString(string? userQuote)
{
    char[] oppositString = userQuote.ToCharArray();
    Array.Reverse(oppositString);
    return new string(oppositString);
}

Console.WriteLine($" perdonami hai detto {reverseQuote}?\n\n scusa ho elaborato male, volevi dire {userQuote}");



// 5' esercizio                                               Reading from a file
Console.WriteLine("esercizio 5");
Console.WriteLine("inserisci i tuoi proverbi preferiti");
string? userQuote2 = Console.ReadLine();
const string path = "./ output.txt";                                            
//File.WriteAllText( "./ output.txt",userQuote);     crea sempre un file
//File.AppendAllText("./ output.txt", userQuote);    modifica il file attaccando i risultati
File.AppendAllLines(path, new[] { userQuote2 });       // ????        contents:
Console.WriteLine("il tuo ultimo proverbio");
var text= File.ReadAllText(path); 
//var text2= File.ReadAllText("C:/Users/pc/Desktop/ptresentazione secondo progetto.txt");  // esempio con mio file locale
Console.WriteLine(text);
//Console.WriteLine(text2);


//e 6' esercizio                                                Inheritance
Console.WriteLine("esercizio 6");

Animal dog = new Dog();    
dog.Name = "Balto";                    
dog.Age = 10;               
dog.Speak();                 
                                                                                                     //  chiedere per i modificatori d'accesso
Animal cat = new Cat();
cat.Name = "Silvestro";
cat.Age = 20;
cat.Speak();

// 7' sesercizio
Modificari mod= new Modificari();
Modificatori2 mod2= new Modificatori2();

// Accedi ai membri utilizzando i metodi pubblici
Console.WriteLine($"Membro Privato: {mod.OttieniMembroPrivato()}");
Console.WriteLine($"Membro Protetto: {mod2.OttieniMembroProtetto()}");
Console.WriteLine($"Membro Interno: {mod.OttieniMembroInterno()}");
Console.WriteLine($"Membro Pubblico: {mod.membroPubblico}");
    


//8' esercizio                                              Was it a car or a cat I saw?

Console.WriteLine("inserici una frase");

string? userInput = Console.ReadLine();

string ReverseStrings(string? userInput)
{
    string input = userInput.Replace(" ", "").ToLower();
    char[] oppositString = input.ToCharArray();
    Array.Reverse(oppositString);
    return new string(oppositString);
}
bool IsPalindrome(string userInput)
{
    string originString = userInput.Replace(" ", "").ToLower();
    string reversedInput = ReverseStrings(userInput);

    return originString == reversedInput;
}
if (IsPalindrome(userInput))
{
    Console.WriteLine("La stringa è una palindroma.");
}
else
{
    Console.WriteLine("La stringa NON è una palindroma.");
}


// 9'-10' esercizio                                          Unit conversion and  Advanced: Converting back and forth
Console.WriteLine("esercizi 9 e 10");

Convertitore_Da_CEL_aFar celsius = new CelsiusToFahrenheit();
Convertitore_Da_CEL_aFar fahrenheit = new FahrenheitToCelsius();

fahrenheit.Calcolatore(656);
celsius.Calcolatore(95);



