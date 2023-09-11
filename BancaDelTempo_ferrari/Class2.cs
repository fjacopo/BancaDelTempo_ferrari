using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BancaDelTempo_ferrari
{
    public class Prestazione : IEquatable<Prestazione>
    {
        public string _id;
        public Socio _erogatore; //eroga la prestazione
        public Socio _ricevente; //riceve la prestazione
        public int _ore;   
        public DateTime _data; 
        public string _tipo; 

        [JsonProperty]

        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _id = value;
                else
                    throw new Exception("Id non valido");
            }
        }
        [JsonProperty]

        public Socio Erogatore
        {
            get
            {
                return _erogatore;
            }
            private set
            {
                if (value != null)
                    _erogatore = value;
                else
                    throw new Exception("Erogatore non valido");
            }
        }
        [JsonProperty]

        public Socio Ricevente
        {
            get
            {
                return _ricevente;
            }
            private set
            {
                if (value != null)
                    _ricevente = value;
                else
                    throw new Exception("Ricevente non valido");
            }
        }
        [JsonProperty]

        public int Ore  //le prestazioni devono essere da minimo 1h
        {
            get
            {
                return _ore;
            }
            private set
            {
                if (value > 0)
                    _ore = value;
                else
                    throw new Exception("Ore non valide");
            }
        }
        [JsonProperty]

        public DateTime Data
        {
            get
            {
                return _data;
            }
            private set
            {
                if (value != null)
                    _data = value;
                else
                    throw new Exception("Data non valida");
            }
        }
        [JsonProperty]
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            private set
            {
                if (value != null)
                    _tipo = value;
                else
                    throw new Exception("Tipo non valido");
            }
        }

        public Prestazione(string id, Socio erogatore, Socio ricevente, int ore, DateTime data, string tipo)
        {
            Id = id;
            Erogatore = erogatore;
            Ricevente = ricevente;
            Ore = ore;
            Data = data;
            Tipo = tipo;
        }
        public Prestazione()
        {

        }


        protected Prestazione(Prestazione other) : this(other.Id, other.Erogatore, other.Ricevente, other.Ore, other.Data, other.Tipo)
        {
        }
        public Prestazione Clone()
        {
            return new Prestazione(this);
        }
        public bool Equals(Prestazione p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }
        public override string ToString()
        {
            return $"Prestazione:{Id} {Erogatore}; {Ricevente}; {Ore}; {Data}; {Tipo}";
        }
    }
}
