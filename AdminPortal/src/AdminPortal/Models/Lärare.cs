using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Models
{
    public class Lärare
    {
        public int Id  { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Kurs { get; set; }
    }
}
