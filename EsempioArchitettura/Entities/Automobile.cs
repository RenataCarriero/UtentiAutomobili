using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    internal class Automobile: Veicolo
    {
        public string Targa { get; set; }
        public int NumeroPosti { get; set; }


        public Automobile()
        {

        }

        public Automobile(int id, string brand, string targa, bool isElectric, int utenteId,  int numPosti) 
            : base(id, brand,isElectric, utenteId)
        {
            Targa = targa;
            NumeroPosti = numPosti;
        }

        public override string ToString()
        {
            return base.ToString() + $" Targa: {Targa} - numero posti: {NumeroPosti}";
        }

    }
}
