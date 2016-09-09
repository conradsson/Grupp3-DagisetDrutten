using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp3___Förskolan_Drutten
{
    class Frånvaro
    {
        public DateTime Datum { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public bool Sjuk { get; set; }
        public bool Ledig { get; set; }


        public override string ToString()
        {
            return Datum + " " + Förnamn + " " + Efternamn + " " + Sjuk + " " + Ledig;
        }

    }
}
