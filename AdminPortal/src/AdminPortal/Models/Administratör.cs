using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Models
{
    public class Administratör
    {
        public int Id { get; set; }
        public string Inloggningsnamn { get; set; }
        public string Lösenord { get; set; }
    }
}
