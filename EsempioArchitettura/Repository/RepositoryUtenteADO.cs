using EsempioArchitettura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura.Repository
{
    internal class RepositoryUtenteADO : IRepositoryUtente
    {
        public bool Aggiungi(Utente item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Utente item)
        {
            throw new NotImplementedException();
        }

        public IList<Utente> GetAll()
        {
            throw new NotImplementedException();
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
