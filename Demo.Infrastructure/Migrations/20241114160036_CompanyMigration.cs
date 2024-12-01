using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompanyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Products_CompanyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Products");

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
    }
}
