using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioClasse
{
    internal class ClasseStudente
    {
        public string? nome  { get; set; }
        public int voto  { get; set; }

        public ClasseStudente(string? nome, int voto)
        {
            this.nome = nome;
            this.voto = voto;
        }
    }
}
