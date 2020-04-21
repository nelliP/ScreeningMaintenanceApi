using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreeningMaintenance.Api.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public string teamOrgbet { get; set; }
        public string TelNr1 { get; set; }
        public string TelNr2 { get; set; }
        public string TelTid1 { get; set; }
        public string TelTid2 { get; set; }
        public string EReminder { get; set; }
        public string Kommentar { get; set; }
        public string WebTidbokKommentar { get; set; }
        public string Url { get; set; }
    }
}
