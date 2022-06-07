using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contoso.API.Persistence.Migrations
{
    public partial class UpdateregisterDatetobecalculatedonlyinthedomainclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegisterDate",
                value: "6/5/2022");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "RegisterDate",
                value: "6/5/2022");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
