using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ECCompanyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B690889-501F-4A19-B2F7-3C55F6D8BAC9",
                column: "ConcurrencyStamp",
                value: "d252637c-eed8-4cb3-b829-f75d823ae566");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40FEB7B4-B530-4EA2-B96F-582D88277E4B",
                column: "ConcurrencyStamp",
                value: "869e94fc-2809-4948-89fe-c4a42fa6e08d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "891E6770-C605-4D45-B959-8906C5728935",
                column: "ConcurrencyStamp",
                value: "6f7b7c0a-7ab1-4424-8085-456d9cd8214e");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3B690889-501F-4A19-B2F7-3C55F6D8BAC9",
                column: "ConcurrencyStamp",
                value: "b4890ed4-1b21-4a70-ba87-7865180fd921");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40FEB7B4-B530-4EA2-B96F-582D88277E4B",
                column: "ConcurrencyStamp",
                value: "c77fa920-ec48-4222-9299-55d50a68518d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "891E6770-C605-4D45-B959-8906C5728935",
                column: "ConcurrencyStamp",
                value: "eed63c57-5b9b-4c17-b169-ac10b5bbb2b1");
        }
    }
}
