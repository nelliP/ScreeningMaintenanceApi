using System.Collections.Generic;

namespace ScreeningMaintenance.DataAccess.Models
{
    public class Maintenances
    {
        public int Id { get; set; }
        public List<Clinic> Clinics { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Invitation> Invitations { get; set; }
        public List<Region> Regions { get; set; }
    }
}