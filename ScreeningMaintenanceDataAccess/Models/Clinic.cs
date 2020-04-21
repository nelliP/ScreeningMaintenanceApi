using System;

namespace ScreeningMaintenance.DataAccess.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Orgbet { get; set; }
        public string Klartext { get; set; }
        public string AvdTeam { get; set; }
        public string AvdText { get; set; }
        public string Vrdkod { get; set; }
        public string Sjukhus { get; set; }
        public string Huskropp { get; set; }
        public string Ansvar { get; set; }
        public int DatabasId { get; set; }
        public string VerkOmr { get; set; }
        public string OrgbetRemklin { get; set; }
        public string Nivaa { get; set; }
        public string AvdService { get; set; }
        public string Division { get; set; }
        public string OrgbetOver { get; set; }
        public string IrkNr { get; set; }
        public string OrgbetSvarsklin { get; set; }
        public string OrgbetDebklin { get; set; }
        public string HsaId { get; set; }
        public int Eremiss { get; set; }
        public DateTime FomDat { get; set; }
        public DateTime TomDat { get; set; }
    }
}

