namespace ScreeningMaintenance.DataAccess.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public Clinic Clinic { get; set; }
        public Address Address { get; set; }
        public Invitation Invitation { get; set; }
        public Region Region { get; set; }
    }
}
