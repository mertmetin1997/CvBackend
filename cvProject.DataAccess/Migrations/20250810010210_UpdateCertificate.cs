using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cvProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCertificate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("81b30493-dc68-4b2d-a03f-193bbeae985e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("c9dfec70-d527-4210-a444-3ad6c01373e0"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Certificates",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateAt", "IsActive", "IsDeleted", "Level", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("19d3e146-0064-432f-83f5-60dede08a2f7"), new DateTime(2025, 8, 10, 4, 2, 10, 35, DateTimeKind.Local).AddTicks(9102), true, false, (byte)60, "Almanca", null },
                    { new Guid("d44d4375-d125-470e-845e-7aac72bfb84d"), new DateTime(2025, 8, 10, 4, 2, 10, 35, DateTimeKind.Local).AddTicks(9063), true, false, (byte)80, "İngilizce", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("19d3e146-0064-432f-83f5-60dede08a2f7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("d44d4375-d125-470e-845e-7aac72bfb84d"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Certificates",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateAt", "IsActive", "IsDeleted", "Level", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("81b30493-dc68-4b2d-a03f-193bbeae985e"), new DateTime(2025, 7, 25, 19, 39, 50, 323, DateTimeKind.Local).AddTicks(7160), true, false, (byte)60, "Almanca", null },
                    { new Guid("c9dfec70-d527-4210-a444-3ad6c01373e0"), new DateTime(2025, 7, 25, 19, 39, 50, 323, DateTimeKind.Local).AddTicks(7118), true, false, (byte)80, "İngilizce", null }
                });
        }
    }
}
