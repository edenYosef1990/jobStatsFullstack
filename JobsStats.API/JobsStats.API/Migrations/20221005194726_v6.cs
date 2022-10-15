using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9333), 41 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9369), 1 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9372), 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9374), 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9376), 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9380), 50 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9382), "refael", 16 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9384), "elal", 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9420), 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9423), 48 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9425), 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9427), "refael", 36 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9429), "elal", 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9431), "elbit", 1 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9432), "refael", 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9434), "refael", 39 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9436), "elal", 56 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9438), "refael", 68 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9440), "elal", 48 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9442), 55 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9444), "refael", 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9446), 42 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9448), 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9449), 55 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9451), "refael", 17 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9454), 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9456), 53 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9458), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9459), 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9461), "refael", 19 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9463), "elal", 5 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 27, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9465), "refael", 25 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9467), 42 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9469), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9471), 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9473), 59 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9475), 28 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9477), 32 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 30, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9479), 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 30, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9481), 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9483), 27 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9484), "elal", 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 1, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9486), "refael", 31 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 2, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9488), "refael", 41 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9490), "refael", 33 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9492), "elal", 18 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 11, 3, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9494), "elbit", 32 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4893), 32 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4928), 59 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4931), 22 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4933), 17 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4935), 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4938), 38 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4940), "tnuva", 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4942), "nova", 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4944), 2 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4946), 53 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4948), 5 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4950), "elbit", 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4952), "refael", 59 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4954), "elal", 37 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4955), "elbit", 7 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4957), "tnuva", 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4959), "refael", 54 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4961), "elal", 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4963), "elbit", 69 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4965), 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4967), "elal", 56 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 14, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4969), 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4971), 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4972), 27 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4974), "elbit", 12 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4976), 56 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4978), 7 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4979), 50 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4981), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4983), "elal", 28 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4985), "elbit", 31 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4986), "tnuva", 67 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4988), 36 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4991), 47 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4992), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4994), 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4996), 67 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4997), 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4999), 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 22, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5001), 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5003), 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5004), "refael", 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5006), "elal", 33 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5008), "elbit", 29 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5010), "tnuva", 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5012), "refael", 49 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 26, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5013), "refael", 68 });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobName", "NumberOfWatches" },
                values: new object[,]
                {
                    { 48, new DateTime(2022, 10, 26, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5015), "elal", 3 },
                    { 49, new DateTime(2022, 10, 27, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5017), "refael", 45 },
                    { 50, new DateTime(2022, 10, 27, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5018), "elal", 16 },
                    { 51, new DateTime(2022, 10, 29, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5020), "refael", 19 },
                    { 52, new DateTime(2022, 10, 29, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5022), "elal", 23 },
                    { 53, new DateTime(2022, 10, 29, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5023), "elbit", 65 },
                    { 54, new DateTime(2022, 10, 31, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5026), "refael", 38 },
                    { 55, new DateTime(2022, 10, 31, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5027), "elal", 68 },
                    { 56, new DateTime(2022, 10, 31, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5029), "elbit", 64 },
                    { 57, new DateTime(2022, 10, 31, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5031), "tnuva", 4 },
                    { 58, new DateTime(2022, 11, 2, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5033), "refael", 17 },
                    { 59, new DateTime(2022, 11, 2, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5034), "elal", 58 },
                    { 60, new DateTime(2022, 11, 2, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5036), "elbit", 22 },
                    { 61, new DateTime(2022, 11, 3, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5038), "refael", 58 },
                    { 62, new DateTime(2022, 11, 3, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5040), "elal", 26 },
                    { 63, new DateTime(2022, 11, 3, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5077), "elbit", 54 }
                });
        }
    }
}
