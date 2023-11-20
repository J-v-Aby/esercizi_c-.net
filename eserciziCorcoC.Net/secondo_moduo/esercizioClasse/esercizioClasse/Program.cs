using esercizioClasse;
using System.ComponentModel;
using System.Xml;

List<ClasseStudente> listaStudenti=new List<ClasseStudente>();

listaStudenti.Add(new ClasseStudente("gianni", 77));
listaStudenti.Add(new ClasseStudente("gianni", 60));
listaStudenti.Add(new ClasseStudente("gianni", 68));
listaStudenti.Add(new ClasseStudente("gianni", 88));
listaStudenti.Add(new ClasseStudente("arioi", 88));
listaStudenti.Add(new ClasseStudente("gianni", 67));

double mediaVoti = listaStudenti.Select(s => s.voto).Average();
double migliore = listaStudenti.Select(s => s.voto).Max();

Console.WriteLine($"la media della classe e': {mediaVoti}");


foreach (var student in listaStudenti)
{
    if (student.voto == migliore)
    {
        Console.WriteLine($"Lo studente {student.nome} ha ottenuto il voto più alto: {student.voto}");
    }
}

                                                                // esercizio 10
var studentiVotoPiùAlto = listaStudenti.Where(s => s.voto == migliore).OrderBy(s => s.nome);
foreach(var student in studentiVotoPiùAlto)
{
    Console.WriteLine($"Nome: {student.nome}, Voto: {student.voto}");
}