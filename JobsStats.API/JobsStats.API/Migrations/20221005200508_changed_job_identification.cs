using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class changed_job_identification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobName",
                table: "JobWatchesPerDays");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "JobWatchesPerDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4501), 1, 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4504), 2, 22 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "JobId", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4506), 3, 58 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4551), 35 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 7, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4555), 29 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 8, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4557), 46 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4561), 53 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4567), 21 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 11, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4580), 54 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4582), 17 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4589), 3 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4602), 12 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4605), 10 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4611), 67 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4620), 48 });

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
                columns: new[] { "Date", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4625), 69 });

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

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobId", "NumberOfWatches" },
                values: new object[,]
                {
                    { 48, new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4631), 4, 38 },
                    { 49, new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4633), 0, 39 },
                    { 50, new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4635), 1, 35 },
                    { 51, new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4636), 2, 9 },
                    { 52, new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4638), 3, 54 },
                    { 53, new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4640), 0, 65 },
                    { 54, new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4642), 1, 40 },
                    { 55, new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4643), 2, 46 },
                    { 56, new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4645), 3, 10 },
                    { 57, new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4647), 0, 61 },
                    { 58, new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4649), 1, 56 },
                    { 59, new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4650), 2, 4 },
                    { 60, new DateTime(2022, 10, 24, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4652), 0, 51 },
                    { 61, new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4654), 0, 35 },
                    { 62, new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4656), 1, 30 },
                    { 63, new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4657), 2, 60 },
                    { 64, new DateTime(2022, 10, 26, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4659), 0, 43 },
                    { 65, new DateTime(2022, 10, 27, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4661), 0, 46 },
                    { 66, new DateTime(2022, 10, 29, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4664), 0, 36 },
                    { 67, new DateTime(2022, 10, 30, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4665), 0, 66 },
                    { 68, new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4667), 0, 11 },
                    { 69, new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4669), 1, 62 },
                    { 70, new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4671), 2, 65 },
                    { 71, new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4672), 3, 27 },
                    { 72, new DateTime(2022, 11, 1, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4674), 0, 4 },
                    { 73, new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4676), 0, 24 },
                    { 74, new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4677), 1, 69 },
                    { 75, new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4679), 0, 43 },
                    { 76, new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4680), 1, 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "JobWatchesPerDays");

            migrationBuilder.AddColumn<string>(
                name: "JobName",
                table: "JobWatchesPerDays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9333), "refael", 41 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9369), "elal", 1 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9372), "elbit", 66 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9374), "refael", 4 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9376), "elal", 43 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 6, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9380), "elbit", 50 });

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 9, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9420), "refael", 46 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9423), "refael", 48 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 10, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9425), "elal", 69 });

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 15, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9442), "refael", 55 });

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9446), "refael", 42 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9448), "refael", 30 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9449), "elal", 55 });

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9454), "refael", 9 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9456), "elal", 53 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 23, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9458), "elbit", 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 24, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9459), "refael", 30 });

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9467), "refael", 42 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9469), "elal", 52 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 28, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9471), "elbit", 23 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9473), "refael", 59 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9475), "elal", 28 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 29, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9477), "elbit", 32 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 30, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9479), "refael", 51 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 30, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9481), "elal", 65 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 31, 22, 47, 26, 685, DateTimeKind.Local).AddTicks(9483), "refael", 27 });

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
    }
}
