using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4JProjekat.QueryEntities
{
    public class Klijent
    {
        public String ime { get; set; }
        public String prezime { get; set; }
        public String grad { get; set; }
        public String telefon { get; set; }
        public String licnaKarta { get; set; }

        //public List<Automobil> automobiliKlijenta { get; set; }
        //public List<Rezervacija> rezervacijeKlijenta { get; set; }
        
    }
}
