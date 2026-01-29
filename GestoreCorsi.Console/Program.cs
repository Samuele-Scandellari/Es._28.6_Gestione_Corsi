using GestioneCorsi.Library;

namespace Es._28._6_Gestione_Corsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestoreCorsi gestione = new GestoreCorsi();

            var corso = new Corso("informatica", 1);
            gestione.AggiungiCorso(corso);

            var s1 = new Studente { Nome = "Luca", Cognome = "Rossi", Matricola = "A001" };
            corso.AggiungiStudente(s1);

            var s2 = new Studente { Nome = "Marco", Cognome = "Bianchi", Matricola = "A002" };
            corso.AggiungiStudente(s2);

            var s3 = new Studente { Nome = "Anna", Cognome = "Verdi", Matricola = "A003" };
            corso.AggiungiStudente(s3);

            var docente = new Docente("Giulia", "Verdi");
            var aula = new Aula("Aula 1", 30);
            aula.AggiungiRisorsa(new Risorsa { Nome = "Proiettore" });

            var lezione = new Lezione(DateTime.Now, "Introduzione C#", TimeSpan.FromHours(2), new TimeSpan(9, 0, 0), docente, aula);
            lezione.SegnaPresente(s1);
            lezione.SegnaPresente(s2);
            lezione.SegnaAssente(s3);

            Console.WriteLine("Elenco studenti presenti alla lezione:");
            foreach (var studente in lezione.Presenti)
            {
                Console.WriteLine(studente);
            }
            corso.AggiungiLezione(lezione);

            Console.WriteLine("Elenco corsi:");
            foreach (Corso c in gestione.Corsi)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Elenco studenti iscritti:");
            foreach (Studente s in corso.Studenti)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Elenco lezioni:");
            foreach (var l in corso.Lezioni)
            {
                Console.WriteLine(l);
            }
        }
    }
}