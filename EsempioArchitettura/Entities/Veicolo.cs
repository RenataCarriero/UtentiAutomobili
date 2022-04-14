using EsempioArchitettura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura
{
    public abstract class Veicolo
    {        
        public int Id { get; set; }
        public string Brand { get; set; } = "sconosciuto";
        public bool IsElettrico { get; set; }
        
        //FK
        public int UtenteId { get; set; }
        //public Utente Utente { get; set; }

        public Veicolo()
        {

        }
        public Veicolo(int id, string brand, bool isElettric, int idUtente)
        {
            Id=id;
            Brand = brand;
            IsElettrico=isElettric;
            UtenteId=idUtente; 
        }

     
    }
}
