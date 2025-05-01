using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projet_fin_etude.Migrations
{
    /// <inheritdoc />
    public partial class Correctseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 30, 17, 22, 21, 678, DateTimeKind.Local).AddTicks(3360));
        }
    }
}
