using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Grupp3___Förskolan_Drutten
{
    class Person : Errorhandler
    {
        public int Personid { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Telefonnr { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public string ÄrPersonal { get; set; }
        public string ÄrFörälder { get; set; }
        
        public override string ToString()
        {
            return Personid + " -  " + Förnamn + " " + Efternamn;
        }
    }
}
