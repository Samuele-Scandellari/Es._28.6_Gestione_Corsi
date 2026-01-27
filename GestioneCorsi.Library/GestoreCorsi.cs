using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class GestoreCorsi
    {
        public List<Corso> Corsi { get; set; } = new List<Corso>();

        public float MediaPresentiCorsi()
        {
            int totalePresenti = 0;
            foreach (var corso in Corsi)
            {
                totalePresenti += corso.Studenti.Count;
            }

            if (Corsi.Count < 1)
            {
                return 0;
            }

            return totalePresenti / Corsi.Count;
        }

        public void AggiungiCorso(Corso c)
        {
            Corsi.Add(c);
        }
    }
}