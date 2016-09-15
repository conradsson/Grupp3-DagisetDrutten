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
        public bool EndastFörPersonal { get; set; }

        public override string ToString()
        {
            return Datum + " - " + InläggsRubrik;
        }

        public string VisaInläggsText
        {
            get
            {
                return Datum + "\n" + "\n" + InläggsRubrik + "\n" + InläggsText;
            }
        }
    }
}
