using EsempioArchitettura.Entities;
using EsempioArchitettura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal static class Menu
    {
        private static IRepositoryUtente repoUtente = new RepositoryUtenteMock();
        private static IRepositoryAutomobile repoAutomobile = new RepositoryAutomobileMock();
        internal static void Start()
        {
            bool continua = true;

            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("******************Menu*********************");
            //Funzionalità Utente

            Console.WriteLine("1. Visualizza Utenti");
            Console.WriteLine("2. Inserire un nuovo Utente");
            Console.WriteLine("3. Modifica un Utente");
            Console.WriteLine("4. Elimina un Utente");
            Console.WriteLine("5. Visualizza le auto di un Utente");
            Console.WriteLine("6. Aggiungi Automobile");
            Console.WriteLine("7. Visualizza Automobili");


            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");

            int scelta;
            Console.WriteLine("Inserisci la tua scelta: ");
            while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 7))
            {
                Console.WriteLine("Scelta errata. Inserisci scelta corretta:");
            }
            return scelta;
        }

        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VisualizzaUtenti();
                    break;
                case 2:
                    InserisciUtente();
                    break;
                case 3:
                    //ModificaUtente();
                    break;
                case 4:
                    //EliminaUtente();
                    break;
                case 5:
                    CercaAutoDiUnUtente();
                    break;
                case 6:
                    InserisciAutomobile();
                    break;
                case 7:
                    VisualizzaAutomobili();
                    break;
                case 0:
                    return false;
                default:
                    Console.WriteLine("Scelta errata. Riprova");
                    break;
            }
            return true;
        }

        private static void CercaAutoDiUnUtente()
        {
            Console.WriteLine("Elenco Utenti:");
            VisualizzaUtenti();
            Console.WriteLine("Le auto di quale utente vuoi vedere?");
            int idUtente;
            do
            {
                Console.Write("Inserisci un id utente valido: ");
            } while (!(int.TryParse(Console.ReadLine(), out idUtente) && repoUtente.GetById(idUtente) != null));

            List<Automobile> autoRestituite=repoAutomobile.GetAutoByUtente(idUtente);

            if (autoRestituite.Count == 0)
            {
                Console.WriteLine("L'utente non ha auto!");
            }
            else
            {
                Console.WriteLine("Ecco le auto dell'utente:");
                foreach (var item in autoRestituite)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void VisualizzaAutomobili()
        {
            Console.WriteLine("Elenco Automobili");
            foreach (var item in repoAutomobile.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void InserisciAutomobile()
        {
            Console.WriteLine("\nInserisci dati per aggiungere una nuova auto:");
            //raccolgo dati dall'utente con opportuni controlli.
            Console.Write("\nId auto:"); //TODO: incrementato automaticamente
            int id = 0;
            while (!(int.TryParse(Console.ReadLine(), out id) && id > 0 && repoAutomobile.GetById(id) == null))
            {
                Console.Write("\nId errato o già presente. Inserisci un id intero > 0. Riprova: ");

            }

            Console.Write("\nTarga auto:");
            string targa = Console.ReadLine();
            while (repoAutomobile.GetByTarga(targa) != null)
            {
                Console.Write("\nTarga già presente. Riprova: ");
                targa = Console.ReadLine();
            }

            Console.WriteLine("Chi è il proprietario di questa auto?");
            Console.WriteLine("Elenco Utenti:");
            VisualizzaUtenti();
            int idUtente;
            do
            {
                Console.Write("Inserisci un id utente valido: ");


            } while (!(int.TryParse(Console.ReadLine(), out idUtente) && repoUtente.GetById(idUtente) != null));

            //Altri dati utili per "costruire" un'automobile
            Console.WriteLine("Inserisci brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("è elettrica? true o false");
            bool isElettrica = bool.Parse(Console.ReadLine());
            Console.WriteLine("Numero posti a sedere: ");
            int numeroPosti = int.Parse(Console.ReadLine()); //TODO: TryParse..

            Automobile nuovaAutomobile = new Automobile(id, brand, targa, isElettrica, idUtente, numeroPosti);
            bool esito = repoAutomobile.Aggiungi(nuovaAutomobile);
            if (esito == true)
            {
                Console.WriteLine("Auto inserita");
            }
            else
            {
                Console.WriteLine("Errore");
            }
        }

        private static void InserisciUtente()
        {
            Console.WriteLine("\nInserisci dati per creare un nuovo utente:");
            //raccolgo dati dall'utente con opportuni controlli.
            Console.Write("\nId utente:");
            int id = 0;
            while (!(int.TryParse(Console.ReadLine(), out id) && id > 0 && repoUtente.GetById(id) == null))
            {
                Console.Write("\nId errato o già presente. Inserisci un id intero > 0. Riprova: ");

            }

            Utente u = null;
            string nome;
            string cognome;
            do
            {
                Console.Write("\nNome utente:");
                nome = Console.ReadLine();
                Console.Write("\nCognome utente:");
                cognome = Console.ReadLine();
                u = repoUtente.GetByNomeCognome(nome, cognome);
                if (u != null)
                {
                    Console.WriteLine($"Utente {nome} {cognome} già presente. Reinserisci i dati:");
                }
            } while (!(u == null));




            Console.Write("\nData di nascita utente:");
            DateTime dataNascita = new DateTime();
            while (!(DateTime.TryParse(Console.ReadLine(), out dataNascita) && dataNascita <= DateTime.Today.AddDays(1)))
            {
                Console.Write("\nData errata o futura. Riprova: ");
            };

            Utente nuovoUtente = new Utente(id, nome, cognome, dataNascita);

            bool esito = repoUtente.Aggiungi(nuovoUtente);
            if (esito == true)
            {
                Console.WriteLine("Utente aggiunto correttamente");
            }
            else
            {
                Console.WriteLine("Errore. Impossibile aggiungere l'utente");
            }
        }



        private static void VisualizzaUtenti()
        {
            IList<Utente> listaUtentiRecuperata = repoUtente.GetAll();

            if (listaUtentiRecuperata.Count == 0)
            {
                Console.WriteLine("Lista vuota");
            }
            else
            {

                foreach (Utente item in listaUtentiRecuperata)
                {
                    Console.WriteLine(item.ToString());

                }
            }

        }
    }
}

