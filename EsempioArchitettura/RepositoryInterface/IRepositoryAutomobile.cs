using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal interface IRepositoryAutomobile: IRepository<Automobile>
    {
        Automobile GetByTarga(string targa);
        List<Automobile> GetAutoByUtente(int idUtente);
    }
}
