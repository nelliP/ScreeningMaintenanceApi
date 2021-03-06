﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScreeningMaintenanceDataAccess.Context;

namespace ScreeningMaintenance.DataAccess.Migrations
{
    [DbContext(typeof(ScreeningMaintenanceContext))]
    [Migration("20180531074708_SerialNumberChangedToVerkOmr")]
    partial class SerialNumberChangedToVerkOmr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScreeningMaintenance.DataAccess.Models.Address", b =>
                {
                    b.Property<string>("Orgbet")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Epost");

                    b.Property<string>("GAdress");

                    b.Property<int>("Id");

                    b.Property<string>("KontaktPers");

                    b.Property<string>("Land");

                    b.Property<string>("PAdress");

                    b.Property<string>("PostNr");

                    b.Property<string>("TelNr");

                    b.Property<string>("TelNr2");

                    b.HasKey("Orgbet");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ScreeningMaintenance.DataAccess.Models.Clinic", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Orgbet");

                    b.Property<string>("Ansvar");

                    b.Property<string>("AvdService");

                    b.Property<string>("AvdTeam");

                    b.Property<string>("AvdText");

                    b.Property<int>("DatabasId");

                    b.Property<string>("Division");

                    b.Property<int>("Eremiss");

                    b.Property<DateTime>("FomDat");

                    b.Property<string>("HsaId");

                    b.Property<string>("Huskropp");

                    b.Property<string>("IrkNr");

                    b.Property<string>("Klartext");

                    b.Property<string>("Nivaa");

                    b.Property<string>("OrgbetDebklin");

                    b.Property<string>("OrgbetOver");

                    b.Property<string>("OrgbetRemklin");

                    b.Property<string>("OrgbetSvarsklin");

                    b.Property<string>("Sjukhus");

                    b.Property<DateTime>("TomDat");

                    b.Property<string>("VerkOmr");

                    b.Property<string>("Vrdkod");

                    b.HasKey("Id", "Orgbet");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("ScreeningMaintenance.DataAccess.Models.Invitation", b =>
                {
                    b.Property<string>("Orgbet")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EReminder");

                    b.Property<int>("Id");

                    b.Property<string>("Kommentar");

                    b.Property<string>("TelNr1");

                    b.Property<string>("TelNr2");

                    b.Property<string>("TelTid1");

                    b.Property<string>("TelTid2");

                    b.Property<string>("Url");

                    b.Property<string>("WebTidbokKommentar");

                    b.HasKey("Orgbet");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("ScreeningMaintenance.DataAccess.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beskrivning");

                    b.Property<string>("Division");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ScreeningMaintenance.DataAccess.Models.SerialNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrgbetValue");

                    b.Property<string>("VerkOmr");

                    b.HasKey("Id");

                    b.ToTable("SerialNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
