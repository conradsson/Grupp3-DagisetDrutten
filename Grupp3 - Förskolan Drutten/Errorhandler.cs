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
    class Errorhandler
    {
        public bool Error { get; set; }
        public string ErrorMeddelande { get; set; }

        public override string ToString()
        {
            return Error + ErrorMeddelande;
        }

    }
}
