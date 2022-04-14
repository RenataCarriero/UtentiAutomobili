using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal class Bicicletta : Veicolo
    {
        public int Size { get; set; }

        public Bicicletta()
        {
                
        }

        public Bicicletta(int id, string brand, bool isElectric, int utenteId, int size)
            : base(id, brand, isElectric, utenteId)
        {
           Size = size;
        }

    }
}
