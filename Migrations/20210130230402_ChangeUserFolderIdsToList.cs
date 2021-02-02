using Microsoft.EntityFrameworkCore.Migrations;

namespace Flashcards.Migrations
{
    public partial class ChangeUserFolderIdsToList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "13fcadeb-bc28-4db3-b180-e9a68cd536d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c930224-8db4-4bfd-98c1-3285e861b445", "AQAAAAEAACcQAAAAEIAbwyUd7gPC7Y53/LokXJciBDiGt/HYwZRbaFom4OYTDMHYXcbT4K97x7aI1rIAHw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
