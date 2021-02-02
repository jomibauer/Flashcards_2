using Microsoft.EntityFrameworkCore.Migrations;

namespace Flashcards.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "77b6cde0-5e29-4111-a197-5198ba180324");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bab1b724-0d9b-435f-b18e-48f0a809c770", "AQAAAAEAACcQAAAAEEFOtpyIDcG0gwXBizwDxGq77X1E0alqk8WiNOj76Z52hN2WWgIXX0x6D6OrCPCtMg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "81d0e752-887e-41d0-9946-2df95e523610");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "566c9a68-6586-4357-baac-6282d30ac163", "AQAAAAEAACcQAAAAEO6lY46XPu8zG1gZ7XswGilvw0yPwkaqE/Il/dYlQCtWMEyszQBJNDqYhePxBZX9sQ==" });
        }
    }
}
