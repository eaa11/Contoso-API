using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contoso.API.Persistence.Migrations
{
    public partial class addregisterDateproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IdentificationCard", "LastName", "Name", "PhoneNumber", "RegisterDate" },
                values: new object[] { 1, "450-7852014-5", "Adames", "Aljandra", "809-985-9878", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IdentificationCard", "LastName", "Name", "PhoneNumber", "RegisterDate" },
                values: new object[] { 2, "780-7452014-5", "Adames", "Estrella", "829-975-9988", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDescription", "CustomerId", "Municipality", "Sector", "StreetName", "ZipCode" },
                values: new object[] { 1, "por el colmado la Santiaguera", 2, "Santo Domingo Sur", "Algo", "St/ Gregorio", "11807" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDescription", "CustomerId", "Municipality", "Sector", "StreetName", "ZipCode" },
                values: new object[] { 2, "Casa Azul #25", 1, "Santo Domingo Norte", "Villa Mella", "St/ Una calle cualquiera", "11201" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Customers");
        }
    }
}
