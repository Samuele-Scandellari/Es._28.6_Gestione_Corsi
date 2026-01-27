using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Corso
    {
        public string Nome { get; set; }
        public int Edizione { get; set; }
        public List<Lezione> Lezioni { get; set; } = new List<Lezione>();
        public List<Studente> Studenti { get; set; } = new List<Studente>();

        public Corso(string nome, int edizione)
        {
            Nome = nome;
            Edizione = edizione;
        }

        public float MediaPresentiLezione()
        {
            int totalePresenti = 0;
            foreach (Lezione lezione in Lezioni)
            {
                totalePresenti += lezione.Presenti.Count;
            }

            if (Lezioni.Count < 1)
            {
                return 0;

            }
            return totalePresenti / Lezioni.Count;
        }

        public void AggiungiStudente(Studente s)
        {
            Studenti.Add(s);
        }

        public void AggiungiLezione(Lezione l)
        {
            Lezioni.Add(l);
        }

        public List<Studente> GetIscritti()
        {
            return Studenti;
        }

        public List<Lezione> GetLezioni()
        {
            return Lezioni;
        }
    }
}