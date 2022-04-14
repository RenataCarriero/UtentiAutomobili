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
        private static IRepositoryAutomobile repoVeicolo = new RepositoryAutomobileMock();
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
            Console.WriteLine("\nFunzionalità Utente");
            Console.WriteLine("1. Visualizza Utenti");
            Console.WriteLine("2. Inserire un nuovo Utente");
            Console.WriteLine("3. Modifica un Utente");
            Console.WriteLine("4. Elimina un Utente");
            //Console.WriteLine("5. Visualizza le auto di un Utente");
            //Funzionalità su Automobili
            //Console.WriteLine("\nFunzionalità Automobili");            

            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");

            int scelta;
            Console.WriteLine("Inserisci la tua scelta: ");
            while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 4))
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
                case 0:
                    return false;
                default:
                    Console.WriteLine("Scelta errata. Riprova");
                    break;
            }
            return true;
        }

        private static void InserisciUtente()
        {
            Console.WriteLine("Inserisci dati per creare un nuovo utente:");
            //raccolgo dati dall'utente con opportuni controlli.
            
            Utente nuovoUtente = new Utente(3, "Renata", "Carriero", new DateTime(1987, 04, 01));

            bool esito= repoUtente.Aggiungi(nuovoUtente);
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

