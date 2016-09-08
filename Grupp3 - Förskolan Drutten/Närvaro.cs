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
    class Närvaro : Errorhandler
    {
        public int Närvaroid { get; set; }
        public DateTime Datum { get; set; }
        public int Barnid { get; set; }
        public string TidLämnad { get; set; }
        public string TidHämtad { get; set; }
        public string HämtasAv { get; set; }


        public override string ToString()
        {
            return Närvaroid + " " + Datum + " " + Barnid + " " + TidLämnad + " " + TidHämtad + " " + HämtasAv;
        }
    }
}
