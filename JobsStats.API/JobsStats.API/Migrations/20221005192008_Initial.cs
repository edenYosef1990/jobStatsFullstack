using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobWatchesPerDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfWatches = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobWatchesPerDays", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobName", "NumberOfWatches" },
                values: new object[] { 1, new DateTime(2022, 10, 5, 22, 20, 8, 156, DateTimeKind.Local).AddTicks(5683), "El-al", 34 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobWatchesPerDays");
        }
    }
}
