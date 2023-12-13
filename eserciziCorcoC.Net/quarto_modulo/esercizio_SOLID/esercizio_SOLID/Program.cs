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
using esercizio_SOLID.IMyQueueMethods;

Logger log = new Logger();

IntQueue codaInt = new IntQueue();
codaInt.AddQ(1);
codaInt.AddQ(2);
codaInt.AddQ(3);
((ILogger)log).Logger($"Elemento {codaInt.SeeQInt()}");

codaInt.DeliteQ();

((ILogger)log).Logger($"Elemento in testa alla coda dopo la rimozione: {codaInt.SeeQInt()}");


StringQueue stringa= new StringQueue();

stringa.AddQString("pippo");
stringa.AddQString("pippo2");
stringa.AddQString("pippo3");
((ILogger)log).Logger($"Elemento {stringa.SeeQString()}");

stringa.DeliteQString();
((ILogger)log).Logger($"Elemento in testa alla coda dopo la rimozione: {stringa.SeeQString()}");