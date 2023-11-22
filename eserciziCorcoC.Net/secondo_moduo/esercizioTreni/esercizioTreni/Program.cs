using esercizioTreni;

LinkedList<Treno> listaTreni = new LinkedList<Treno>();

listaTreni.AddLast(new Treno("Palermo"));
listaTreni.AddLast(new Treno("Trapani"));
listaTreni.AddLast(new Treno("Catania"));
listaTreni.AddLast(new Treno("Messina"));
listaTreni.AddFirst(new Treno("Roma"));

    foreach (Treno t in listaTreni)
    {
        Console.WriteLine(t.nome);
    }

    listaTreni.RemoveFirst();

Console.WriteLine("");

foreach (Treno t in listaTreni)
{
    Console.WriteLine(t.nome);
}

