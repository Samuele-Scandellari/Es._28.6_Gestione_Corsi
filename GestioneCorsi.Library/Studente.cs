using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Matricola { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Cognome} ({Matricola})";
        }
    }
}