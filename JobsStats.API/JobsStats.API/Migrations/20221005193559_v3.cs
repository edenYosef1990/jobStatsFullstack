using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 5, 22, 35, 59, 385, DateTimeKind.Local).AddTicks(868));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 5, 22, 21, 24, 224, DateTimeKind.Local).AddTicks(6040));
        }
    }
}
