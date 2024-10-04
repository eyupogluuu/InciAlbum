using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InciAlbum.DataAccessLayer.Migrations
{
    public partial class image_class_add_imageUrl_prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descreption",
                table: "Images",
                newName: "imageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Images",
                newName: "descreption");
        }
    }
}
