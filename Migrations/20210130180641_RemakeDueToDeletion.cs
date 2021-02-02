using Microsoft.EntityFrameworkCore.Migrations;

namespace Flashcards.Migrations
{
    public partial class RemakeDueToDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "b487d2b9-3bb8-4600-9e92-80004565390d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "313756ce-1179-44d7-ad94-f1e1366c841f", "AQAAAAEAACcQAAAAEH8NKsVOXVnFf2IveX9O+WxS7vqR+c8wRgTFsCD+zbUtbVY4LzDxlmwt1NYVt4/2pA==" });
        }
    }
}
