using GestioneCorsi.Library;

namespace TestGestoreCorsi
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAggiungiRisorsa()
        {
            var aula = new Aula("Aula 1", 30);
            var risorsa = new Risorsa { Nome = "Lavagna" };

            aula.AggiungiRisorsa(risorsa);
            Assert.AreEqual("Lavagna", aula.Risorse[0].Nome);
        }

        [TestMethod]
        public void TestAggiungiStudente()
        {
            var corso = new Corso("Matematica", 1);
            var studente = new Studente { Nome = "Anna", Cognome = "Verdi", Matricola = "B001" };

            corso.AggiungiStudente(studente);
            Assert.AreEqual("Anna", corso.Studenti[0].Nome);
        }

        [TestMethod]
        public void TestAggiungiLezione()
        {
            var corso = new Corso("Fisica", 1);
            var docente = new Docente("Luca", "Neri");
            var aula = new Aula("Aula 2", 25);
            var lezione = new Lezione(DateTime.Now, "Meccanica", TimeSpan.FromHours(2), new TimeSpan(10, 0, 0), docente, aula);

            corso.AggiungiLezione(lezione);
            Assert.AreEqual("Meccanica", corso.Lezioni[0].Descrizione);
        }

        [TestMethod]
        public void TestSegnaPresente()
        {
            var docente = new Docente("Sara", "Blu");
            var aula = new Aula("Aula 3", 20);
            var lezione = new Lezione(DateTime.Now, "Chimica", TimeSpan.FromHours(2), new TimeSpan(11, 0, 0), docente, aula);

            var studente = new Studente { Nome = "Marco", Cognome = "Rossi", Matricola = "C001" };
            lezione.SegnaPresente(studente);
            Assert.AreEqual("Marco", lezione.Presenti[0].Nome);
        }

        [TestMethod]
        public void TestSegnaAssente()
        {
            var docente = new Docente("Elena", "Gialli");
            var aula = new Aula("Aula 4", 15);

            var lezione = new Lezione(DateTime.Now, "Biologia", TimeSpan.FromHours(2), new TimeSpan(12, 0, 0), docente, aula);
            var studente = new Studente { Nome = "Luca", Cognome = "Bianchi", Matricola = "D001" };

            lezione.SegnaPresente(studente);
            lezione.SegnaAssente(studente);
            Assert.AreEqual(0, lezione.Presenti.Count);
        }

        [TestMethod]
        public void TestGetIscritti()
        {
            var corso = new Corso("Informatica", 1);
            var studente1 = new Studente { Nome = "Alice", Cognome = "Verdi", Matricola = "E001" };
            var studente2 = new Studente { Nome = "Bob", Cognome = "Neri", Matricola = "E002" };

            List<Studente> risultato = new List<Studente> { studente1, studente2 };
            corso.AggiungiStudente(studente1);
            corso.AggiungiStudente(studente2);

            var iscritti = corso.GetIscritti();
            CollectionAssert.AreEqual(iscritti, risultato);
        }

        [TestMethod]
        public void TestGetLezioni()
        {
            var corso = new Corso("Storia", 1);
            var docente = new Docente("Giovanni", "Rossi");
            var aula = new Aula("Aula 5", 40);

            var lezione1 = new Lezione(DateTime.Now, "Antica", TimeSpan.FromHours(2), new TimeSpan(9, 0, 0), docente, aula);
            var lezione2 = new Lezione(DateTime.Now, "Moderna", TimeSpan.FromHours(2), new TimeSpan(11, 0, 0), docente, aula);

            List<Lezione> risultato = new List<Lezione> { lezione1, lezione2 };
            corso.AggiungiLezione(lezione1);
            corso.AggiungiLezione(lezione2);
            CollectionAssert.AreEqual(risultato, corso.GetLezioni());
        }

        [TestMethod]
        public void TestMediaPresentiCorsi()
        {
            var studente1 = new Studente { Nome = "Alice", Cognome = "Verdi", Matricola = "E001" };
            var studente2 = new Studente { Nome = "Bob", Cognome = "Neri", Matricola = "E002" };
            var studente3 = new Studente { Nome = "Charlie", Cognome = "Bianchi", Matricola = "E003" };
            var corso1 = new Corso("Letteratura", 1);
            corso1.AggiungiStudente(studente1);

            var corso2 = new Corso("Filosofia", 1);
            corso2.AggiungiStudente(studente2);

            var corso3 = new Corso("Arte", 1);
            List<Corso> corsi = new List<Corso>() { corso3, corso1, corso2 };

            var gestoreCorsi = new GestoreCorsi() { Corsi = corsi };

            corso3.AggiungiStudente(studente1);
            corso3.AggiungiStudente(studente2);
            corso3.AggiungiStudente(studente3);
            Assert.AreEqual(gestoreCorsi.MediaPresentiCorsi(), 5 / 3);
        }

        [TestMethod]
        public void TestMedia0PresentiCorsi()
        {
            var corso2 = new Corso("Filosofia", 1);
            var corso3 = new Corso("Arte", 1);
            List<Corso> corsi = new List<Corso>() { corso3, corso2 };

            var gestoreCorsi = new GestoreCorsi() { Corsi = corsi };
            Assert.AreEqual(gestoreCorsi.MediaPresentiCorsi(), 0);
        }

        [TestMethod]
        public void TestMediaPresentiLezione()
        {
            var studente1 = new Studente { Nome = "Alice", Cognome = "Verdi", Matricola = "E001" };
            var studente2 = new Studente { Nome = "Bob", Cognome = "Neri", Matricola = "E002" };
            var studente3 = new Studente { Nome = "Charlie", Cognome = "Bianchi", Matricola = "E003" };
            var corso1 = new Corso("Letteratura", 1);
            corso1.AggiungiStudente(studente1);

            List<Corso> corsi = new List<Corso>() { corso1 };
            var gestoreCorsi = new GestoreCorsi() { Corsi = corsi };
            corso1.AggiungiStudente(studente1);
            corso1.AggiungiStudente(studente2);
            corso1.AggiungiStudente(studente3);

            Lezione lezione1 = new Lezione(DateTime.Now, "Lezione 1", TimeSpan.FromHours(2), new TimeSpan(9, 0, 0),
                new Docente("Doc", "Tor"), new Aula("Aula 1", 30));
            Lezione lezione2 = new Lezione(DateTime.Now, "Lezione 2", TimeSpan.FromHours(2), new TimeSpan(11, 0, 0),
                new Docente("Doc", "Tor"), new Aula("Aula 1", 30));

            corso1.AggiungiLezione(lezione2);
            corso1.AggiungiLezione(lezione1);
            lezione1.SegnaPresente(studente1);
            lezione1.SegnaPresente(studente2);
            Assert.AreEqual(corso1.MediaPresentiLezione(), 1);
        }

        [TestMethod]
        public void TestMedia0PresentiLezione()
        {
            var corso2 = new Corso("Filosofia", 1);
            corso2.Lezioni = new List<Lezione>()
            {
                new Lezione(DateTime.Now, "Lezione 1", TimeSpan.FromHours(2), new TimeSpan(9, 0, 0),
                    new Docente("Doc", "Tor"), new Aula("Aula 1", 30)),
                new Lezione(DateTime.Now, "Lezione 2", TimeSpan.FromHours(2), new TimeSpan(11, 0, 0), 
                    new Docente("Doc", "Tor"), new Aula("Aula 1", 30))
            };

            List<Corso> corsi = new List<Corso>() { corso2 };
            var gestoreCorsi = new GestoreCorsi() { Corsi = corsi };
            Assert.AreEqual(corso2.MediaPresentiLezione(), 0);
        }
    }
}