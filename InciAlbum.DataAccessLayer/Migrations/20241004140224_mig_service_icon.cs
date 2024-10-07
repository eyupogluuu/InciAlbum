using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InciAlbum.DataAccessLayer.Migrations
{
    public partial class mig_service_icon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "image",
                table: "myServices",
                newName: "icon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "icon",
                table: "myServices",
                newName: "image");
        }
    }
}
