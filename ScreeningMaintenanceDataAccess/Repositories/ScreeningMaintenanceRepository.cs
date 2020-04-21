using ScreeningMaintenance.DataAccess.Interfaces;
using ScreeningMaintenanceDataAccess.Context;
using ScreeningMaintenance.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.SqlTypes;

namespace ScreeningMaintenance.DataAccess.Repositories
{
    public class ScreeningMaintenanceRepository : IScreeningMaintenanceRepository
    {
        private ScreeningMaintenanceContext _context;
        public ScreeningMaintenanceRepository(ScreeningMaintenanceContext context)
        {
            _context = context;
        }

        public Maintenances GetAllMaintenances()
        {
            Maintenances maintenances = null;
            try
            {
                maintenances = new Maintenances()
                {
                    Id = 0,
                    //get all clinics which are operated at the time
                    Clinics = _context.Clinics
                .Where(c => c.TomDat >= DateTime.Today || c.TomDat < SqlDateTime.MinValue.Value.AddYears(100))
                .Where(c => c.Nivaa == "T")
                .OrderBy(c => c.Klartext).ToList(),
                    Addresses = _context.Addresses.ToList(),
                    Invitations = _context.Invitations.ToList(),
                    Regions = _context.Regions.OrderBy(r => r.Beskrivning).ToList()
                };
            }
            catch (Exception)
            {
                throw;
            }
            
            return maintenances;
        }

        public Maintenance GetNewMaintenance(string division, string verkOmr)
        {
            //getting SerialNumber for clinicOver and clinic     
            Maintenance maintenance = null;
            try
            {
                var orgbetOver = UpdateSerialNumber(verkOmr);
                var orgbet = UpdateSerialNumber(verkOmr);

                maintenance = new Maintenance()
                {
                    Clinic = new Clinic()
                    {
                        Id = 0,
                        Ansvar = "",
                        AvdService = "",
                        AvdTeam = "",
                        AvdText = "",
                        DatabasId = 0,
                        Eremiss = 0,
                        HsaId = "",
                        Huskropp = "",
                        IrkNr = "",
                        Klartext = "",
                        Nivaa = "T",
                        OrgbetDebklin = "",
                        OrgbetRemklin = "",
                        OrgbetSvarsklin = "",
                        Sjukhus = "",
                        Vrdkod = "O",
                        Division = division,
                        OrgbetOver = orgbetOver,
                        Orgbet = orgbet,
                        VerkOmr = verkOmr,

                        TomDat = DateTime.MinValue
                    },
                    Address = new Address() { Orgbet = orgbet, Land = "SE" },
                    Invitation = new Invitation() { Orgbet = orgbet, EReminder = "N" }
                };
            }
            catch (Exception)
            {
                throw;
            }
            
            return maintenance;
        }

        public Address UpdateAddress(Address address)
        {
            try
            {
                _context.Addresses.Update(address);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            
            return _context.Addresses.Find(address.Orgbet);
        }

        public Clinic UpdateClinic(Clinic clinic)
        {
            try
            {
                _context.Clinics.Update(clinic);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }           
            return _context.Clinics.Find(clinic.Id, clinic.Orgbet);
        }

        public Invitation UpdateInvitation(Invitation invitation)
        {
            try
            {
                _context.Invitations.Update(invitation);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }            
            return _context.Invitations.Find(invitation.Orgbet);
        }

        public Clinic AddNewMaintenance(Maintenance maintenance)
        {
            //adding clinicOver, clinic, address and invitation to db
            try
            {
                var clinicOver = new Clinic()
                {
                    Division = maintenance.Clinic.Division,
                    OrgbetOver = "",
                    Orgbet = maintenance.Clinic.OrgbetOver,
                    VerkOmr = maintenance.Clinic.VerkOmr,
                    Nivaa = "A",
                    Eremiss = 0,
                    Klartext = maintenance.Clinic.Klartext,
                    AvdTeam = " "
                };
                _context.Clinics.Add(clinicOver);
                _context.Clinics.Add(maintenance.Clinic);
                _context.Addresses.Add(maintenance.Address);
                _context.Invitations.Add(maintenance.Invitation);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


            //getting the new clinic including Id
            Clinic newClinic = null;
            try
            {
                newClinic = _context.Clinics.FirstOrDefault(c => c.Orgbet == maintenance.Clinic.Orgbet);
            }
            catch (Exception)
            {
                throw;
            }
            
            return newClinic;
        }

        //SerialNumber increases by 1
        private string UpdateSerialNumber(string verkOmr)
        {
            try
            {
                var serialNumber = _context.SerialNumbers.Where(s => s.VerkOmr == verkOmr).FirstOrDefault();
                serialNumber.OrgbetValue++;
                _context.SerialNumbers.Update(serialNumber);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            //get new SerialNumber as string
            string newSerialNumber = "";
            try
            {
               newSerialNumber = _context.SerialNumbers.Where(s => s.VerkOmr == verkOmr).FirstOrDefault().OrgbetValue.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return newSerialNumber;
        }
    }
}
