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
            if(item == null)
            {
                return false;
            }
            else
            {
                Automobili.Add(item);
                return true;
            }
        }

        public bool Delete(Automobile item)
        {
            throw new NotImplementedException();
        }

        public IList<Automobile> GetAll()
        {
            return Automobili;
        }

        public List<Automobile> GetAutoByUtente(int idUtente)
        {
            List<Automobile> list = new List<Automobile>();
            foreach (Automobile item in Automobili)
            {
                if (item.UtenteId == idUtente)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public Automobile GetById(int id)
        {
            foreach (var item in Automobili)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Automobile GetByTarga(string targa)
        {
            foreach (var item in Automobili)
            {
                if (item.Targa == targa)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Modifica(Automobile item)
        {
            throw new NotImplementedException();
        }
    }
}
