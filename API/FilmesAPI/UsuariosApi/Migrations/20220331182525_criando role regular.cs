using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "26f11206-e09a-4106-9c9e-ac8e5046ba1e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "0c6ac513-e836-4a32-826b-412b6212144d", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42f81cea-3f7f-416d-b231-f3c9bbb0b2ed", "AQAAAAEAACcQAAAAEEu1Q1ua2F1zetuNELE7EVqaS5mEwhPnLHdOM8N1+kBICv0W/l3YF4wCfyQ1ruNQUQ==", "039fa432-4215-4a1e-9648-f755fae6b52d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d4c06de4-d084-4a2c-b040-29e2345bfbc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60567f06-4181-490d-8a37-a98f8f30990b", "AQAAAAEAACcQAAAAEFibR0A0YohympvHhim2Sa5EY7rc7kJBA4FK2yyLGl99gGGw8hrDwle+Mx0CMG2giw==", "2e6ab3c7-775f-41f2-bcd7-ad7dc4943e43" });
        }
    }
}
