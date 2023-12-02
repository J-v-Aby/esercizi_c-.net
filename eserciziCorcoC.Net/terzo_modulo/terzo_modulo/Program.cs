using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml;
                                                                Console.WriteLine("\n primo esercizio modulo 3\n");//query sintax

Random random = new Random();

List<int> list = Enumerable.Range(0, 1000).Select(list => random.Next(1001)).ToList();
//Il simbolo _ è spesso utilizzato quando il nome del parametro non è utilizzato ex: Select(_ => random.Next(1001)).ToList();

var result = from item in list
             where item % 2 != 0
             select item;

Console.WriteLine(string.Join(" ", result));

                                                            Console.WriteLine("\n secondo esercizio modulo 3\n");//sintax

var result2 = list.Where(item => item % 2 != 0);
Console.WriteLine(string.Join(" ", result2));

                                                            Console.WriteLine("\n terzo esercizio modulo 3\n");

List<int> list3 = Enumerable.Range(0, 100).Select(l => random.Next(1001)).ToList();

var sortedList = list3.OrderByDescending(item => item).ToList();
Console.WriteLine("Lista ordinata in modo Decrescente:\n" + string.Join(" ", sortedList));

var longList = list3.OrderBy(item => item).ToList();
Console.WriteLine("\nLista ordinata in modo Crescente:\n" + string.Join(" ", longList));

                                                             Console.WriteLine("\n quarto esercizio modulo 3\n");


List<int> list4 = Enumerable.Range(0, 10).Select(l => random.Next(1001)).ToList();

var numeriordinati = list4.OrderBy(o => o).ToList();

var numeroDiNumeri = numeriordinati.Select(item => $"{item} = {item.ToString().Length} carattere");


Console.WriteLine(string.Join(" \n*", numeroDiNumeri));


                                                            Console.WriteLine("\n quinto esercizio modulo 3\n");

List<double> lista = new List<double> { 5.5, 2.3, 8.7, 1.2, 9.9, 80.0, 8, 5.6, 98, 5 };

double somma = lista.Sum();
double media = lista.Average();
double totale = lista.Count();
Console.WriteLine("Sottoinsieme di elementi: " + string.Join(", ", lista));
Console.WriteLine($"\n{somma}\n{media}\n{totale}");

                                                            Console.WriteLine("\n sesto esercizio modulo 3\n");

Console.WriteLine($"isnerisci un numero, tra 1 e {totale - 1}");
int skiper = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 converte un valore in un intero cosi evito di usare int.parse
Console.WriteLine($" bel lavoro, un po di pasienza ma il tutor vuole che inserisci un altro numerotra 1 e {totale - 1} (prenditela con lui)");
int taker = Convert.ToInt32(Console.ReadLine());
List<double> listaModificata = lista.Skip(skiper).Take(taker).ToList();

double somma2 = listaModificata.Sum();
double media2 = listaModificata.Average();
double totale2 = listaModificata.Count();
Console.WriteLine("Sottoinsieme di elementi: " + string.Join(", ", listaModificata));
Console.WriteLine($"\n{somma2}\n{media2}\n{totale2}");

                                                            Console.WriteLine("\n settimo  esercizio modulo 3\n");

List<int> lista5 = new List<int> { 1, 2, 3, 4, 3, 5,8,6,90};
int risultato1 = lista5.FirstOrDefault(x => x == 3); 
int risultato2 = lista5.FirstOrDefault(x => x > 5); 
int risultato3 = lista5.FirstOrDefault(x => x < 5); 
int risultato4 = lista5.FirstOrDefault(x => x > 91); // Restituisce 0 perche la condizione non viene soddisfatta
Console.WriteLine($"FirstOrDefault:\n{risultato1}\n{risultato2}\n{risultato3}\n{risultato4}");

int risultato_A = lista5.SingleOrDefault(x => x == 3); 
int risultato_B = lista5.SingleOrDefault(x => x > 5); 
int risultato_C = lista5.SingleOrDefault(x => x < 5); 
int risultato_D = lista5.SingleOrDefault(x => x > 91); // Restituisce InvalidOperationException
Console.WriteLine($"SingleOrDefaultt:\n{risultato_A}\n{risultato_B}\n{risultato_C}\n{risultato_D}");



                                                                Console.WriteLine("\n ottavo esercizio modulo 3\n");

List<int> numeri = new List<int> { 27, 44, 60, 58, 16 };

bool pari = numeri.Any(numero => numero % 2 == 0);  // qualcuno

bool dispari = numeri.All(numero => numero % 2 != 0); // tutti

Console.WriteLine("ci sono numeri pari: " + pari);
Console.WriteLine("ci sono numeri dipsari: " + dispari);


