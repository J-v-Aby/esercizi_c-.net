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



              