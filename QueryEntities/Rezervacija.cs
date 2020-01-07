using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4JProjekat.QueryEntities
{
    public class Rezervacija
    {
        public int id { get; set; }
        public String odVremena { get; set; }
        public String doVremena { get; set;}
        public String imeKompanije { get; set; }
        public String imeKlijenta { get; set; }
        public String prezimeKlijenta { get; set; }
        public String lkKlijenta { get; set; }
        public String telefonKlijenta { get; set; }

        //public List<Automobil> automobiliRezervacije { get; set; }


    }
}
