using esercizio_projecting;
/*using System;
using System.Collections.Generic;
using System.Linq;*/


 List<int> GeneraNumeriCasuali(int n)
{
    Random random = new Random();
    return Enumerable.Range(1, n).Select(_ => random.Next(1, 1001)).ToList();
}

List<int> numeriCasuali = GeneraNumeriCasuali(100);

List<MetaData> metadatiNumeri = numeriCasuali
        .Select(numero => new MetaData
        {
           Numero = numero,
           IsEven = numero % 2 == 0,
           NumberOfCharacters = numero.ToString().Length
        })
            .ToList();

 foreach (var metaDato in metadatiNumeri)
 {
    Console.WriteLine($"Numero: {metaDato.Numero}, IsEven: {metaDato.IsEven}, NumberOfCharacters: {metaDato.NumberOfCharacters}");
 }

