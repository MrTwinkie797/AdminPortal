using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Models
{
    public class Elev
    {
        public int Id  { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Personnummer { get; set; }
        public int Klass { get; set; }


    }
}
