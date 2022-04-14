using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura.Repository
{
    internal class RepositoryAutomobileMock : IRepositoryAutomobile
    {
        static private List<Automobile> Automobili = new List<Automobile>
        {
            new Automobile(1,"FIAT","AA123BC",false,1, 5),           
            new Automobile(2,"BMW","AA111BB",true,2, 4)           
        };

        public bool Aggiungi(Automobile item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Automobile item)
        {
            throw new NotImplementedException();
        }

        public IList<Automobile> GetAll()
        {
            throw new NotImplementedException();
        }

        public Automobile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Automobile GetByTarga(string targa)
        {
            throw new NotImplementedException();
        }

        public bool Modifica(Automobile item)
        {
            throw new NotImplementedException();
        }
    }
}
