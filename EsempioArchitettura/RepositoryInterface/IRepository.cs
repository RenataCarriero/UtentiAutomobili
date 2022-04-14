using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal interface IRepository<T> 
    {

        //operazioni CRUD
        IList<T> GetAll();
        T GetById(int id);
        bool Aggiungi(T item);
        bool Modifica(T item);
        bool Delete(T item);
    }
}
