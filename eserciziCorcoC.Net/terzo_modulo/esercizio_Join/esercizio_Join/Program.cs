using esercizio_Join;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Category> categorie = new List<Category>
        {
            new Category { CategoryId = 1, Nome = "Manga" },
            new Category { CategoryId = 2, Nome = "Libri" },
            new Category { CategoryId = 3, Nome = "Giornali" }
        };

        List<Product> prodotti = new List<Product>
        {
            new Product { ProductId = 1, Nome = "Naruto", CategoryId = 1 },
            new Product { ProductId = 2, Nome = "One Piece", CategoryId = 1 },
            new Product { ProductId = 3, Nome = "Pippo Franco sul nilo", CategoryId = 2 },
            new Product { ProductId = 4, Nome = "Franco e Ciccio contro tutti", CategoryId = 2 },
            new Product { ProductId = 5, Nome = "New York Time", CategoryId = 3 },
            new Product { ProductId = 6, Nome = "Mialno Finanza", CategoryId = 3 }
        };

        var risultato = from prodotto in prodotti
                        join categoria in categorie on prodotto.CategoryId equals categoria.CategoryId
                        select new
                        {
                            ProductName = prodotto.Nome,
                            CategoryName = categoria.Nome
                        };

        foreach (var item in risultato)
        {
            Console.WriteLine($" Larticolo {item.ProductName}, E un {item.CategoryName}");
        }
    }
}


