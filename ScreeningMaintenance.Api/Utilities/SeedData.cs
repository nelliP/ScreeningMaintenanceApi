using Microsoft.Extensions.DependencyInjection;
using ScreeningMaintenance.DataAccess.Models;
using ScreeningMaintenanceDataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreeningMaintenance.Api.Utilities
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ScreeningMaintenanceContext>();
            context.Database.EnsureCreated();
            if (!context.Clinics.Any())
            {
                try
                {
                    //Clinic 1
                    context.Clinics.Add(new Clinic()
                    {
                        Id = 0,
                        AvdTeam = "NTC1",
                        AvdText = "NTC1",
                        HsaId = "",
                        Huskropp = "",
                        OrgbetDebklin = "",
                        OrgbetRemklin = "",
                        OrgbetSvarsklin = "",
                        Sjukhus = "",
                        Klartext = "New Test Clinic 1",
                        Orgbet = "70001",
                        Division = "NTR1",
                        Vrdkod = "O",
                        Ansvar = "12345",
                        DatabasId = 0,
                        VerkOmr = "BUKAORTA",
                        Nivaa = "T",
                        AvdService = "VC",
                        OrgbetOver = "70000",
                        IrkNr = "654321",
                        Eremiss = 1,
                        FomDat = System.DateTime.Parse("2018-05-20T00:00:00"),
                        TomDat = System.DateTime.MinValue
                    });
                    context.Clinics.Add(new Clinic()
                    {
                        Id = 0,
                        AvdTeam = "NTC1",
                        AvdText = "NTC1",
                        HsaId = "",
                        Huskropp = "",
                        OrgbetDebklin = "",
                        OrgbetRemklin = "",
                        OrgbetSvarsklin = "",
                        Sjukhus = "",
                        Klartext = "New Test Clinic 1",
                        Orgbet = "70000",
                        Division = "NTR1",
                        Vrdkod = "O",
                        Ansvar = "",
                        DatabasId = 0,
                        VerkOmr = "BUKAORTA",
                        Nivaa = "A",
                        AvdService = "VC",
                        OrgbetOver = "",
                        IrkNr = "",
                        Eremiss = 1,
                        FomDat = System.DateTime.Parse("2018-05-20T00:00:00"),
                        TomDat = System.DateTime.MinValue
                    });
                    //Clinic 2
                    context.Clinics.Add(new Clinic()
                    {
                        Id = 0,
                        AvdTeam = "NTC2",
                        AvdText = "NTC2",
                        HsaId = "",
                        Huskropp = "",
                        OrgbetDebklin = "",
                        OrgbetRemklin = "",
                        OrgbetSvarsklin = "",
                        Sjukhus = "",
                        Klartext = "New Test Clinic 2",
                        Orgbet = "60001",
                        Division = "NTR3",
                        Vrdkod = "O",
                        Ansvar = "12345",
                        DatabasId = 0,
                        VerkOmr = "GYN",
                        Nivaa = "T",
                        AvdService = "VC",
                        OrgbetOver = "60000",
                        IrkNr = "654321",
                        Eremiss = 1,
                        FomDat = System.DateTime.Parse("2018-06-20T00:00:00"),
                        TomDat = System.DateTime.MinValue
                    });
                    context.Clinics.Add(new Clinic()
                    {
                        Id = 0,
                        AvdTeam = "NTC2",
                        AvdText = "NTC2",
                        HsaId = "",
                        Huskropp = "",
                        OrgbetDebklin = "",
                        OrgbetRemklin = "",
                        OrgbetSvarsklin = "",
                        Sjukhus = "",
                        Klartext = "New Test Clinic 2",
                        Orgbet = "60000",
                        Division = "NTR2",
                        Vrdkod = "O",
                        Ansvar = "",
                        DatabasId = 0,
                        VerkOmr = "GYN",
                        Nivaa = "A",
                        AvdService = "VC",
                        OrgbetOver = "",
                        IrkNr = "",
                        Eremiss = 1,
                        FomDat = System.DateTime.Parse("2018-06-20T00:00:00"),
                        TomDat = System.DateTime.MinValue
                    });

                    context.Addresses.Add(new Address()
                    {
                        Id = 0,
                        Orgbet = "70001",
                        GAdress = "Gatan",
                        PAdress = "Staden"
                    });
                    context.Addresses.Add(new Address()
                    {
                        Id = 0,
                        Orgbet = "60001",
                        GAdress = "Gatan",
                        PAdress = "Staden"
                    });

                    context.Invitations.Add(new Invitation()
                    {
                        Id = 0,
                        Orgbet = "70001",
                        TelNr1 = "033445566"
                    });
                    context.Invitations.Add(new Invitation()
                    {
                        Id = 0,
                        Orgbet = "60001",
                        TelNr1 = "033445566"
                    }); 
                    context.Regions.Add(new Region()
                    {
                        Division = "NTR1",
                        Beskrivning = "New Test Region 1"
                    });
                    context.Regions.Add(new Region()
                    {
                        Division = "NTR2",
                        Beskrivning = "New Test Region 2"
                    });
                    context.Regions.Add(new Region()
                    {
                        Division = "NTR3",
                        Beskrivning = "New Test Region 3"
                    });
                    context.SerialNumbers.Add(new SerialNumber()
                    {
                        OrgbetValue = 60001,
                        VerkOmr = "GYN"
                    });
                    context.SerialNumbers.Add(new SerialNumber()
                    {
                        OrgbetValue = 70001,
                        VerkOmr = "BUKAORTA"
                    });
                    context.SaveChanges();
                }
                catch (Exception e)
                { }

            }
           
        }
       
    }
}
