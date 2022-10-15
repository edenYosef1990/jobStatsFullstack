using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 5, 22, 21, 24, 224, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobName", "NumberOfWatches" },
                values: new object[] { 2, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Refael", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 5, 22, 20, 8, 156, DateTimeKind.Local).AddTicks(5683));
        }
    }
}
