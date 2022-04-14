using EsempioArchitettura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal interface IRepositoryUtente: IRepository<Utente>
    {
        Utente GetByNomeCognome(string nome, string cognome);
    }
}
