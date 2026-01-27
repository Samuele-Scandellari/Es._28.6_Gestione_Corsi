using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Aula
    {
        public string Nome { get; set; }
        public int Capienza { get; set; }

        public List<Risorsa> Risorse { get; set; } = new List<Risorsa>();

        public Aula(string nome, int capienza)
        {
            Nome = nome;
            Capienza = capienza;
        }

        public void AggiungiRisorsa(Risorsa r)
        {
            Risorse.Add(r);
        }
    }
}