using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Docente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string TitoloDiStudio { get; set; }

        public Docente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}