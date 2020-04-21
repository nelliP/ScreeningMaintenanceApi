using Microsoft.EntityFrameworkCore.Migrations;

namespace ScreeningMaintenance.DataAccess.Migrations
{
    public partial class SerialNumberChangedToVerkOmr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vrdkod",
                table: "SerialNumbers",
                newName: "VerkOmr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VerkOmr",
                table: "SerialNumbers",
                newName: "Vrdkod");
        }
    }
}
