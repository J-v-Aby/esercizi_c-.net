// 1' esercizio                                    Create a "Hello, World!" application
using esercizi;

Console.WriteLine("Hello, World!");


// 2' esercizio                                         Now it's personal
Console.WriteLine("Insersci il tuo nome");  

String? userName = Console.ReadLine();

Console.WriteLine($" piacere di conoscerti {userName} mi chiamo C3pO.2 e sono il tuo nuovo assistente virtuale");


// 3' esercizio                                             The match checks out

Console.WriteLine("inseri numero ");
String? primoInput = Console.ReadLine();

Console.WriteLine("inseri operatore artimentico (base) ");
String? operatoreInput = Console.ReadLine();

Console.WriteLine("inseri numero ");
String? secondoInput = Console.ReadLine();

bool primo = double.TryParse(primoInput, out double result1);
bool secondo = double.TryParse(secondoInput, out double result2);

//int somma = result1 + result2;
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
Console.WriteLine("Insersci il tuo motto");

String? userQuote = Console.ReadLine();

String reverseQuote = ReverseString(userQuote);

string ReverseString(string? userQuote)
{
    char[] charArray = userQuote.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

Console.WriteLine($" perdonami hai detto {reverseQuote}?\n\n scusa ho elaborato male, volevi dire {userQuote}");



//e 6' esercizio                                                Inheritance

Animal dog = new Dog();    
dog.Name = "Balto";                    
dog.Age = 10;               
dog.Speak();                 

Animal cat = new Cat();
cat.Name = "Silvestro";
cat.Age = 20;
cat.Speak();


// 5' esercizio
