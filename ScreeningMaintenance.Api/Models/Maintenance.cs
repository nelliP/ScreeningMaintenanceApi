using db = ScreeningMaintenance.DataAccess.Models;

namespace ScreeningMaintenance.Api.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public db.Clinic Clinic { get; set; }
        public db.Address Address { get; set; }
        public Invitation Invitation { get; set; }
        public db.Region Region { get; set; }
    }
}
