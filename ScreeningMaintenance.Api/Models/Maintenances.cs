using db = ScreeningMaintenance.DataAccess.Models;
using System.Collections.Generic;

namespace ScreeningMaintenance.Api.Models
{
    public class Maintenances
    {
        public int Id { get; set; }
        public List<db.Clinic> Clinics { get; set; }
        public List<db.Address> Addresses { get; set; }
        public List<Invitation> Invitations { get; set; }
        public List<db.Region> Regions { get; set; }
    }
}
