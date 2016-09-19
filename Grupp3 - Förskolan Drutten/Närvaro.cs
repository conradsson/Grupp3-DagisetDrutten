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
    class Närvaro
    {
        public DateTime Datum { get; set; }
        public int barnid { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string TidLämnad { get; set; }
        public string TidHämtad { get; set; }
        public string HämtasAv { get; set; }
        public bool närvarande { get; set; }
        public bool hämtad { get; set; }


        public override string ToString()
        {
            return Datum + " " + barnid + " " + Förnamn + " " + Efternamn + " " + TidLämnad + " " + TidHämtad + " " + HämtasAv + " " + närvarande + " " + hämtad;
        }

        //public string visaBarnTider
        //{
        //    get
        //    {
        //        return Datum.ToString("yyyy-MM-dd") + "\t " + TidLämnad + "\t" + TidHämtad + "\t     " + HämtasAv;
        //    }
        //}
    }
}
