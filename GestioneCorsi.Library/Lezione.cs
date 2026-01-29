using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Lezione
    {
        public DateTime Data { get; set; }
        public string Descrizione { get; set; }
        public TimeSpan Durata { get; set; }
        public TimeSpan OrarioInizio { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }
        public List<Studente> Presenti { get; set; } = new List<Studente>();

        public Lezione(DateTime data, string descrizione, TimeSpan durata, TimeSpan orarioInizio, Docente docente, Aula aula)
        {
            Data = data;
            Descrizione = descrizione;
            Durata = durata;
            OrarioInizio = orarioInizio;
            Docente = docente;
            Aula = aula;
        }

        public void SegnaPresente(Studente s)
        {
            bool trovato = false;
            foreach (var st in Presenti)
            {
                if (st.Matricola == s.Matricola)
                {
                    trovato = true;
                    break;
                }
            }

            if (!trovato)
            {
                Presenti.Add(s);
            }
        }

        public void SegnaAssente(Studente s)
        {
            for (int i = 0; i < Presenti.Count; i++)
            {
                if (Presenti[i].Matricola == s.Matricola)
                {
                    Presenti.RemoveAt(i);
                    break;
                }
            }
        }
    }
}