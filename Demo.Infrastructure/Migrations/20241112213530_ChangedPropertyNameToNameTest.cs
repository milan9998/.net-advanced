using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPropertyNameToNameTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "nameTest");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B690889-501F-4A19-B2F7-3C55F6D8BAC9",
                column: "ConcurrencyStamp",
                value: "8b82b16c-ccb3-42a6-97b9-d9648fb0eb11");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40FEB7B4-B530-4EA2-B96F-582D88277E4B",
                column: "ConcurrencyStamp",
                value: "dbd8513c-426f-43d9-8da3-4a15a2790025");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "891E6770-C605-4D45-B959-8906C5728935",
                column: "ConcurrencyStamp",
                value: "078eaa98-4ffc-46f2-af88-921704dd4477");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nameTest",
                table: "Products",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B690889-501F-4A19-B2F7-3C55F6D8BAC9",
                column: "ConcurrencyStamp",
                value: "5b92d378-c56e-400f-a39d-a44f6fc7c5b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40FEB7B4-B530-4EA2-B96F-582D88277E4B",
                column: "ConcurrencyStamp",
                value: "66fc7bd0-8c47-485d-8a5a-2e4a82e3685f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "891E6770-C605-4D45-B959-8906C5728935",
                column: "ConcurrencyStamp",
                value: "0a4b87f6-cb8a-4bbf-b8da-2a7eb8289f7d");
        }
    }
}
