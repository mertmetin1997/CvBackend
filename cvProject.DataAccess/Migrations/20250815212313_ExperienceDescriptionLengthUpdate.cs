using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cvProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExperienceDescriptionLengthUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Experinces",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateAt", "IsActive", "IsDeleted", "Level", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22b8705f-ee06-4e0f-be85-a363a8b70741"), new DateTime(2025, 8, 16, 0, 23, 12, 274, DateTimeKind.Local).AddTicks(5280), true, false, (byte)80, "İngilizce", null },
                    { new Guid("d0cf602b-0bf2-4108-843d-403670d05608"), new DateTime(2025, 8, 16, 0, 23, 12, 274, DateTimeKind.Local).AddTicks(5312), true, false, (byte)60, "Almanca", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("22b8705f-ee06-4e0f-be85-a363a8b70741"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("d0cf602b-0bf2-4108-843d-403670d05608"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Experinces",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateAt", "IsActive", "IsDeleted", "Level", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("19d3e146-0064-432f-83f5-60dede08a2f7"), new DateTime(2025, 8, 10, 4, 2, 10, 35, DateTimeKind.Local).AddTicks(9102), true, false, (byte)60, "Almanca", null },
                    { new Guid("d44d4375-d125-470e-845e-7aac72bfb84d"), new DateTime(2025, 8, 10, 4, 2, 10, 35, DateTimeKind.Local).AddTicks(9063), true, false, (byte)80, "İngilizce", null }
                });
        }
    }
}
