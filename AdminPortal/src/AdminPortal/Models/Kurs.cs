using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lärare { get; set; }
        public string Klass { get; set; }
        public string DatumStart { get; set; }
        public string DatumSlut { get; set; }
    }
}
