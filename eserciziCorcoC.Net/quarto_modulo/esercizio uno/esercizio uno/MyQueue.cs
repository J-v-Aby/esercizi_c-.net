using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_uno
{
    public class MyQueue<T>
{
    private Queue<T> elemento;

    public MyQueue()
    {
        elemento = new Queue<T>();
    }

    // Metodo per aggiungere un elemento alla coda
    public void AddQ(T elemento)
    {
        this.elemento.Enqueue(elemento);
    }

    // Metodo per rimuovere e restituire l'elemento in testa alla coda
    public T DeliteQ()
    {
        if (elemento.Count == 0)
        {
                Console.WriteLine("La coda è vuota");
        }

        return elemento.Dequeue();
    }

    // Metodo per sbirciare l'elemento in testa alla coda senza rimuoverlo
    public T SeeQ()
    {
        if (elemento.Count == 0)
        {
                Console.WriteLine("La coda è vuota");
        }

        return elemento.Peek();
    }

}

}

