using Microsoft.EntityFrameworkCore.Migrations;

namespace Flashcards.Migrations
{
    public partial class RestoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "b23f3f84-4660-4531-bcbf-c3721990c82c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b8aa04c-aa1d-4fbb-8334-0b0609117193", "AQAAAAEAACcQAAAAECRwT4HSTWdyRy7jBX264t0Gs1rBQupGI/42wPQl7k3Wdow7MOJ8gk4sIJi8Ep1d5g==" });
        }
    }
}
