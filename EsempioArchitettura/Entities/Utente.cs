using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioArchitettura.Entities
{
    public class Utente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        //public List<Veicolo> Veicoli { get; set; }

        public Utente()
        {

        }
        public Utente(int id, string nome, string cognome, DateTime dataNascita)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }

        public override string ToString()
        {
            return $"{Id} - {Nome} {Cognome} nato il {DataNascita.ToShortDateString()}";
        }
    }
}
