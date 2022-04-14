using EsempioArchitettura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura.Repository
{
    internal class RepositoryUtenteMock : IRepositoryUtente
    {
        static private List<Utente> Utenti = new List<Utente>()
        {
            new Utente(1,"Mario", "Rossi", new DateTime(1980,10,10)),
            new Utente(2,"Maria", "Bianchi", new DateTime(1982,12,12))
        };

        public bool Aggiungi(Utente item)
        {
            if(item == null)
            {
                return false;
            }
            else
            {
                Utenti.Add(item);
                return true;
            }
        }

        public bool Delete(Utente item)
        {
            throw new NotImplementedException();
        }

        public IList<Utente> GetAll()
        {
            return Utenti;           
        }

        public Utente GetById(int id)
        {
            foreach (var item in Utenti)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Utente GetByNomeCognome(string nome, string cognome)
        {
            foreach (var item in Utenti)
            {
                if (item.Nome == nome && item.Cognome==cognome)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Modifica(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
