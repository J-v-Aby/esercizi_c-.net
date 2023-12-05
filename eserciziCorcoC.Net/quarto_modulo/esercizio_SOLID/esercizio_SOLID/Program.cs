// Principio SOLID:


//Single Responsibility Principle - SRP:
//una classe dovrebbe avere una sola responsabilità. 
// creo una classe che si occupa solo dei metodi ( o potrei creare una classe per ognio metdodo....
//... ho detto potrei ma mi sciccia)

//Open / Closed Principle - OCP:
//Questo significa che dovresti poter aggiungere nuove funzionalità senza modificare il codice esistente.
// va be in questo esercizio c'è poco da aggiungere

//Liskov Substitution Principle - LSP:
//Questo principio afferma che gli oggetti di una classe derivata
//dovrebbero essere sostituibili con oggetti della classe base senza alterare la correttezza del programma.
// in questo caso anche se sostituisco una classe queueu di tipo int alla classe padre di tipo T
// i metodi continua no a funzionare


//Interface Segregation Principle - ISP
//: Questo principio afferma che è meglio avere molte interfacce specializzate
//che una sola interfaccia generale. Le classi non dovrebbero essere costrette ad implementare metodi che non usano.
//riguardo al primo principiol, mi hai fregato perche ho dovuto cmq care ogni singola classe,
//anzi interfaccia, per ciascun metododo

//Dependency Inversion Principle - DIP:
//Questo principio afferma che gli alti livelli di un'applicazione non dovrebbero dipendere dai livelli inferiori,
//ma entrambi dovrebbero dipendere da astrazioni... in questo caso le interfacce

using esercizio_SOLID;

MyQueueMethods<int> codaInt = new MyQueueMethods<int>();
codaInt.AddQ(1);
codaInt.AddQ(2);
codaInt.AddQ(3);
Console.WriteLine($"Elemento {codaInt.SeeQ()}");

codaInt.DeliteQ();

Console.WriteLine($"Elemento in testa alla coda dopo la rimozione: {codaInt.SeeQ()}");