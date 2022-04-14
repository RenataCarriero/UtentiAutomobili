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
            throw new NotImplementedException();
        }

        public Utente GetByNomeCognome(string nome, string cognome)
        {
            throw new NotImplementedException();
        }

        public bool Modifica(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
