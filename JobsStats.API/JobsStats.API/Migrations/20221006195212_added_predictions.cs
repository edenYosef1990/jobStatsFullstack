using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class added_predictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PredictedJobWatchesPerDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PredictedNumberOfWatches = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictedJobWatchesPerDays", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(123), 49 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(160), 24 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(163), 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(164), 13 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(166), 4, 41 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(169), 5, 13 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(200), 6, 15 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(202), 0, 47 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(204), 1, 40 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(206), 2, 22 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(208), 3, 16 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(209), 4, 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(211), 5, 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(212), 0, 28 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(214), 0, 8 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(215), 1, 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(217), 0, 45 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(220), 1, 61 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(221), 2, 14 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(223), 3, 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(225), 0, 56 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(226), 1, 60 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(228), 0, 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(229), 1, 16 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(231), 2, 7 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(233), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(235), 0, 38 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(237), 1, 34 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(238), 2, 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(240), 3, 2 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(242), 0, 21 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(243), 1, 39 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(245), 2, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(247), 3, 19 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(249), 0, 62 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(250), 1, 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(252), 2, 34 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(254), 3, 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(255), 0, 29 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(257), 1, 13 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(258), 2, 20 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(260), 3, 59 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(262), 0, 55 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(263), 1, 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(265), 2, 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(266), 3, 25 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(268), 0, 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(270), 1, 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(272), 2, 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(273), 3, 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(275), 4, 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(276), 5, 41 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(278), 6, 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(279), 0, 68 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(281), 1, 55 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(282), 2, 33 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(284), 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(286), 0, 34 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(288), 1, 39 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(289), 2, 37 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(291), 54 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(293), 60 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(294), 26 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(296), 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(297), 1, 36 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(300), 2, 47 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(301), 3, 67 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(303), 53 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(305), 0, 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(307), 1, 27 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(308), 2, 14 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(310), 3, 40 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(312), 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(313), 29 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(315), 2, 28 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(316), 0, 56 });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobId", "NumberOfWatches" },
                values: new object[,]
                {
                    { 77, new DateTime(2022, 10, 29, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(318), 1, 26 },
                    { 78, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(319), 0, 28 },
                    { 79, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(321), 1, 67 },
                    { 80, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(323), 2, 60 },
                    { 81, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(324), 3, 13 },
                    { 82, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(326), 4, 4 },
                    { 83, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(328), 5, 23 },
                    { 84, new DateTime(2022, 10, 31, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(329), 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobId", "NumberOfWatches" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 10, 31, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(331), 1, 43 },
                    { 86, new DateTime(2022, 10, 31, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(332), 2, 16 },
                    { 87, new DateTime(2022, 11, 2, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(334), 0, 69 },
                    { 88, new DateTime(2022, 11, 2, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(336), 1, 47 },
                    { 89, new DateTime(2022, 11, 2, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(337), 2, 32 },
                    { 90, new DateTime(2022, 11, 3, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(339), 0, 11 },
                    { 91, new DateTime(2022, 11, 3, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(340), 1, 25 },
                    { 92, new DateTime(2022, 11, 3, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(342), 2, 12 },
                    { 93, new DateTime(2022, 11, 3, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(343), 3, 39 }
                });

            migrationBuilder.InsertData(
                table: "PredictedJobWatchesPerDays",
                columns: new[] { "Id", "Date", "PredictedNumberOfWatches" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(388), 30 },
                    { 2, new DateTime(2022, 10, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(392), 7 },
                    { 3, new DateTime(2022, 10, 8, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(393), 14 },
                    { 4, new DateTime(2022, 10, 9, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(395), 2 },
                    { 5, new DateTime(2022, 10, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(418), 8 },
                    { 6, new DateTime(2022, 10, 11, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(420), 59 },
                    { 7, new DateTime(2022, 10, 12, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(422), 14 },
                    { 8, new DateTime(2022, 10, 13, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(424), 35 },
                    { 9, new DateTime(2022, 10, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(426), 38 },
                    { 10, new DateTime(2022, 10, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(427), 26 },
                    { 11, new DateTime(2022, 10, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(429), 3 },
                    { 12, new DateTime(2022, 10, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(431), 13 },
                    { 13, new DateTime(2022, 10, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(433), 50 },
                    { 14, new DateTime(2022, 10, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(434), 33 },
                    { 15, new DateTime(2022, 10, 20, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(436), 13 },
                    { 16, new DateTime(2022, 10, 21, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(437), 68 },
                    { 17, new DateTime(2022, 10, 22, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(439), 69 },
                    { 18, new DateTime(2022, 10, 23, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(441), 56 },
                    { 19, new DateTime(2022, 10, 24, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(442), 45 },
                    { 20, new DateTime(2022, 10, 25, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(444), 8 },
                    { 21, new DateTime(2022, 10, 26, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(445), 64 },
                    { 22, new DateTime(2022, 10, 27, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(446), 31 },
                    { 23, new DateTime(2022, 10, 28, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(448), 45 },
                    { 24, new DateTime(2022, 10, 29, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(449), 45 },
                    { 25, new DateTime(2022, 10, 30, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(451), 19 },
                    { 26, new DateTime(2022, 10, 31, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(452), 16 },
                    { 27, new DateTime(2022, 11, 1, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(453), 11 },
                    { 28, new DateTime(2022, 11, 2, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(455), 67 },
                    { 29, new DateTime(2022, 11, 3, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(457), 28 },
                    { 30, new DateTime(2022, 11, 4, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(458), 20 },
                    { 31, new DateTime(2022, 11, 5, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(459), 20 },
                    { 32, new DateTime(2022, 11, 6, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(461), 47 },
                    { 33, new DateTime(2022, 11, 7, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(462), 10 }
                });

            migrationBuilder.InsertData(
                table: "PredictedJobWatchesPerDays",
                columns: new[] { "Id", "Date", "PredictedNumberOfWatches" },
                values: new object[,]
                {
                    { 34, new DateTime(2022, 11, 8, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(464), 38 },
                    { 35, new DateTime(2022, 11, 9, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(465), 57 },
                    { 36, new DateTime(2022, 11, 10, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(467), 61 },
                    { 37, new DateTime(2022, 11, 11, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(468), 65 },
                    { 38, new DateTime(2022, 11, 12, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(470), 62 },
                    { 39, new DateTime(2022, 11, 13, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(471), 39 },
                    { 40, new DateTime(2022, 11, 14, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(473), 64 },
                    { 41, new DateTime(2022, 11, 15, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(474), 42 },
                    { 42, new DateTime(2022, 11, 16, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(476), 24 },
                    { 43, new DateTime(2022, 11, 17, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(477), 57 },
                    { 44, new DateTime(2022, 11, 18, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(479), 60 },
                    { 45, new DateTime(2022, 11, 19, 22, 52, 11, 822, DateTimeKind.Local).AddTicks(480), 26 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PredictedJobWatchesPerDays");

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4468), 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4501), 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4504), 22 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4506), 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4551), 0, 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4555), 0, 29 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4557), 0, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4559), 1, 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4561), 0, 53 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4564), 1, 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4566), 2, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4567), 0, 21 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4569), 1, 1 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4570), 2, 13 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4572), 3, 16 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4574), 4, 24 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4576), 5, 67 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4578), 6, 49 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4580), 0, 54 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4582), 0, 17 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4584), 1, 19 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4585), 2, 40 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4587), 3, 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4589), 0, 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4590), 1, 50 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4592), 15 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4594), 1, 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4596), 2, 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4597), 3, 7 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4599), 4, 63 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4600), 5, 47 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4602), 0, 12 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4605), 0, 10 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4607), 1, 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4609), 2, 24 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4611), 0, 67 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4613), 1, 3 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4614), 2, 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4616), 3, 22 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4618), 4, 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4620), 0, 48 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4621), 1, 8 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4623), 2, 1 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4625), 0, 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4626), 1, 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4628), 2, 47 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4629), 3, 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4631), 4, 38 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4633), 0, 39 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4635), 1, 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4636), 2, 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4638), 3, 54 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4640), 0, 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4642), 1, 40 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4643), 2, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4645), 3, 10 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4647), 0 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4649), 1, 56 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4650), 2, 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4652), 0, 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4654), 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4656), 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4657), 60 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 26, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4659), 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4661), 0, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4664), 0, 36 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 30, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4665), 0, 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4667), 11 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4669), 1, 62 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4671), 2, 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4672), 3, 27 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 1, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4674), 0, 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4676), 24 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4677), 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4679), 0, 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4680), 1, 35 });
        }
    }
}
