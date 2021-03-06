﻿using Npgsql;
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
    class Barn
    {
        public int Barnid { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Avdelningsid { get; set; }
        public string Allergier { get; set; }
        public string Annat { get; set; }
        public Int64 AntalDagar { get; set; }

        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }

        public string visaBarn
        {
            get
            {
                return Förnamn + " " + Efternamn;
            }
        }

    }
}
