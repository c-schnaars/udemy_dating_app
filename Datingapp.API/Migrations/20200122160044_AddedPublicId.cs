using Microsoft.EntityFrameworkCore.Migrations;

namespace Datingapp.API.Migrations
{
    public partial class AddedPublicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lookingfor",
                table: "Users",
                newName: "LookingFor");

            migrationBuilder.AddColumn<string>(
                name: "PublicID",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicID",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "Lookingfor");
        }
    }
}
