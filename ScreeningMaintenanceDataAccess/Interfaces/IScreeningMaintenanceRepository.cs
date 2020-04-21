using ScreeningMaintenance.DataAccess.Models;

namespace ScreeningMaintenance.DataAccess.Interfaces
{
    public interface IScreeningMaintenanceRepository
    {
        //GET

        //get all lists - clinic, address,invitation, division
        Maintenances GetAllMaintenances();

        //generate new orgbet, return values for form
        Maintenance GetNewMaintenance(string division, string screeningType);

        //SAVE and GET

        //add new Clinic and empty Address and Invitation
        Clinic AddNewMaintenance(Maintenance maintenance);

        //update entities
        Clinic UpdateClinic(Clinic clinic);
        Address UpdateAddress(Address address);        
        Invitation UpdateInvitation(Invitation invitation);
        
    }
}
