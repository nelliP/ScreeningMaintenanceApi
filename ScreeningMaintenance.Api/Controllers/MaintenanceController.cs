using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScreeningMaintenance.DataAccess.Interfaces;
using ScreeningMaintenance.DataAccess.Models;
using api = ScreeningMaintenance.Api.Models;

namespace ScreeningMaintenance.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MaintenanceController : Controller
    {
        private readonly IScreeningMaintenanceRepository _context;
        private readonly IMapper _mapper;

        public MaintenanceController(IScreeningMaintenanceRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public api.Maintenances GetAllMaintenanceLists()
        {
            try
            {
                var maintenances = new api.Maintenances();
                return _mapper.Map(_context.GetAllMaintenances(), maintenances);
            }
            catch (System.Exception)
            {
                return new api.Maintenances();
            }
            
        }

        [HttpGet]
        public api.Maintenance CreateMaintenance(string regionDivision, string screeningType)
        {           
            try
            {
                var maintenance = new api.Maintenance();
                return _mapper.Map(_context.GetNewMaintenance(regionDivision, screeningType), maintenance);
            }
            catch (System.Exception )
            { 
            return new api.Maintenance();
            }
        }

        [HttpPut]
        public Clinic PutClinic([FromBody]Clinic clinic)
        {
            try
            {
                return _context.UpdateClinic(clinic);
            }
            catch (System.Exception)
            {
                return new Clinic();
            }
            
        }

        [HttpPut]
        public Address PutAddress([FromBody]Address address)
        {
            try
            {
                return _context.UpdateAddress(address);
            }
            catch (System.Exception)
            {
                return new Address();
            }
            
        }

        [HttpPut]
        public api.Invitation PutInvitation([FromBody]api.Invitation invitation)
        {
            try
            {
                var dbInvitation = new Invitation();
                return _mapper.Map(_context.UpdateInvitation(_mapper.Map(invitation, dbInvitation)), invitation);
            }
            catch (System.Exception)
            {
                return new api.Invitation();
            }
            
        }

        [HttpPut]
        public Clinic PutMaintenance([FromBody]api.Maintenance maintenance)
        {
            try
            {
                var dbMaintenance = new Maintenance();
                return _context.AddNewMaintenance(_mapper.Map(maintenance, dbMaintenance));
            }
            catch (System.Exception)
            {
                return new Clinic();
            }
            
        }
    }
}