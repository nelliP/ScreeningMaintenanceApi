using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScreeningMaintenance.DataAccess.Migrations
{
    public partial class fluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Orgbet = table.Column<string>(nullable: false),
                    GAdress = table.Column<string>(nullable: true),
                    PostNr = table.Column<string>(nullable: true),
                    PAdress = table.Column<string>(nullable: true),
                    Land = table.Column<string>(nullable: true),
                    KontaktPers = table.Column<string>(nullable: true),
                    TelNr = table.Column<string>(nullable: true),
                    TelNr2 = table.Column<string>(nullable: true),
                    Epost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Orgbet);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Orgbet = table.Column<string>(nullable: false),
                    Klartext = table.Column<string>(nullable: true),
                    AvdTeam = table.Column<string>(nullable: true),
                    AvdText = table.Column<string>(nullable: true),
                    Vrdkod = table.Column<string>(nullable: true),
                    Sjukhus = table.Column<string>(nullable: true),
                    Huskropp = table.Column<string>(nullable: true),
                    Ansvar = table.Column<string>(nullable: true),
                    DatabasId = table.Column<int>(nullable: false),
                    VerkOmr = table.Column<string>(nullable: true),
                    OrgbetRemklin = table.Column<string>(nullable: true),
                    Nivaa = table.Column<string>(nullable: true),
                    AvdService = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    OrgbetOver = table.Column<string>(nullable: true),
                    IrkNr = table.Column<string>(nullable: true),
                    OrgbetSvarsklin = table.Column<string>(nullable: true),
                    OrgbetDebklin = table.Column<string>(nullable: true),
                    HsaId = table.Column<string>(nullable: true),
                    Eremiss = table.Column<int>(nullable: false),
                    FomDat = table.Column<DateTime>(nullable: false),
                    TomDat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => new { x.Id, x.Orgbet });
                });

            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Orgbet = table.Column<string>(nullable: false),
                    TelNr1 = table.Column<string>(nullable: true),
                    TelNr2 = table.Column<string>(nullable: true),
                    TelTid1 = table.Column<string>(nullable: true),
                    TelTid2 = table.Column<string>(nullable: true),
                    EReminder = table.Column<string>(nullable: true),
                    Kommentar = table.Column<string>(nullable: true),
                    WebTidbokKommentar = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => new { x.Id, x.Orgbet });
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Division = table.Column<string>(nullable: true),
                    Beskrivning = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
