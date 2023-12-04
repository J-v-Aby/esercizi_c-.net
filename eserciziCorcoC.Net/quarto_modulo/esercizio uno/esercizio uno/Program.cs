using esercizio_uno;
using System;
using System.Collections.Generic;


MyQueue<int> codaInt=new MyQueue<int>();
codaInt.AddQ(1);
codaInt.AddQ(2);
codaInt.AddQ(3);

Console.WriteLine($"Elemento {codaInt.SeeQ()}"); 

codaInt.DeliteQ();

Console.WriteLine($"Elemento in testa alla coda dopo la rimozione: {codaInt.SeeQ()}"); 
    
