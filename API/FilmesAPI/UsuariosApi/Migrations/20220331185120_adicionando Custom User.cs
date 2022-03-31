using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class adicionandoCustomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "5504c6c9-ce85-48a9-8c64-93e7947f3e68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "53c88cd4-e6f6-4964-b9f3-cb9597821ea9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b35127-5bb9-4e31-a5b7-e49adeedf521", "AQAAAAEAACcQAAAAEB0ucgpA+oV9r12q7QIZVNRhMHwukF6W73GXlB+ofmlkaGQ7p0ufn2UERcpk6yfXdg==", "2d94a361-6485-4873-a0b1-d39365e9fa1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "0c6ac513-e836-4a32-826b-412b6212144d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "26f11206-e09a-4106-9c9e-ac8e5046ba1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42f81cea-3f7f-416d-b231-f3c9bbb0b2ed", "AQAAAAEAACcQAAAAEEu1Q1ua2F1zetuNELE7EVqaS5mEwhPnLHdOM8N1+kBICv0W/l3YF4wCfyQ1ruNQUQ==", "039fa432-4215-4a1e-9648-f755fae6b52d" });
        }
    }
}
