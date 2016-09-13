using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp3___Förskolan_Drutten
{
    class Information
    {
        public int InläggsId { get; set; }
        public string Datum { get; set; }
        public string InläggsRubrik { get; set; }
        public string InläggsText { get; set; }
        public string SkrivetAv { get; set; }

        public string InäggsDisplay
        {
            get
            {
                return Datum + " - " + InläggsRubrik;
            }
        }
    }
}
