using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RevertMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "fa00deac-692a-4a28-b050-c7628be94226");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40FEB7B4-B530-4EA2-B96F-582D88277E4B",
                column: "ConcurrencyStamp",
                value: "1bae1ff8-f8a8-4fb8-97ec-0544d5f57bcb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "891E6770-C605-4D45-B959-8906C5728935",
                column: "ConcurrencyStamp",
                value: "80d9c19a-64cb-48fe-861d-b2f9ec7e84f3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
