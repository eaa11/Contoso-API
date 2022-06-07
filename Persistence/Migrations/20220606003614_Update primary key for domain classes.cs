using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contoso.API.Persistence.Migrations
{
    public partial class Updateprimarykeyfordomainclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Addresses",
                newName: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Addresses",
                newName: "Id");
        }
    }
}
