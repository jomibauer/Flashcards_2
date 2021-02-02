using Microsoft.EntityFrameworkCore.Migrations;

namespace Flashcards.Migrations
{
    public partial class CheckUpToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "a582761d-96fc-4550-826e-d7e29c695827");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "843d5c5a-4dc0-4bc8-b468-442c15a4cae1", "AQAAAAEAACcQAAAAEAJxXAQeWxSB+q2iz5LN6+7Mu1cL1puSa6/LwODz1lE0tSacQuxtjHKKoO32BSGicA==" });
        }
    }
}
