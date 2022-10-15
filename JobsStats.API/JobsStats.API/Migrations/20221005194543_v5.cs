using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsStats.API.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4893), "refael", 32 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4928), "elal", 59 });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobName", "NumberOfWatches" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 10, 5, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4931), "elbit", 22 },
                    { 4, new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4933), "refael", 17 },
                    { 5, new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4935), "elal", 65 },
                    { 6, new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4938), "elbit", 38 },
                    { 7, new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4940), "tnuva", 52 },
                    { 8, new DateTime(2022, 10, 6, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4942), "nova", 66 },
                    { 9, new DateTime(2022, 10, 7, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4944), "refael", 2 },
                    { 10, new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4946), "refael", 53 },
                    { 11, new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4948), "elal", 5 },
                    { 12, new DateTime(2022, 10, 8, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4950), "elbit", 23 },
                    { 13, new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4952), "refael", 59 },
                    { 14, new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4954), "elal", 37 },
                    { 15, new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4955), "elbit", 7 },
                    { 16, new DateTime(2022, 10, 9, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4957), "tnuva", 30 },
                    { 17, new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4959), "refael", 54 },
                    { 18, new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4961), "elal", 52 },
                    { 19, new DateTime(2022, 10, 10, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4963), "elbit", 69 },
                    { 20, new DateTime(2022, 10, 11, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4965), "refael", 35 },
                    { 21, new DateTime(2022, 10, 11, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4967), "elal", 56 },
                    { 22, new DateTime(2022, 10, 14, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4969), "refael", 58 },
                    { 23, new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4971), "refael", 35 },
                    { 24, new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4972), "elal", 27 },
                    { 25, new DateTime(2022, 10, 16, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4974), "elbit", 12 },
                    { 26, new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4976), "refael", 56 },
                    { 27, new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4978), "elal", 7 },
                    { 28, new DateTime(2022, 10, 17, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4979), "elbit", 50 },
                    { 29, new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4981), "refael", 52 },
                    { 30, new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4983), "elal", 28 },
                    { 31, new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4985), "elbit", 31 },
                    { 32, new DateTime(2022, 10, 18, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4986), "tnuva", 67 },
                    { 33, new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4988), "refael", 36 },
                    { 34, new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4991), "elal", 47 },
                    { 35, new DateTime(2022, 10, 20, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4992), "elbit", 52 },
                    { 36, new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4994), "refael", 66 },
                    { 37, new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4996), "elal", 67 },
                    { 38, new DateTime(2022, 10, 21, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4997), "elbit", 52 },
                    { 39, new DateTime(2022, 10, 22, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(4999), "refael", 43 },
                    { 40, new DateTime(2022, 10, 22, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5001), "elal", 23 },
                    { 41, new DateTime(2022, 10, 23, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5003), "refael", 58 },
                    { 42, new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5004), "refael", 65 }
                });

            migrationBuilder.InsertData(
                table: "JobWatchesPerDays",
                columns: new[] { "Id", "Date", "JobName", "NumberOfWatches" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5006), "elal", 33 },
                    { 44, new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5008), "elbit", 29 },
                    { 45, new DateTime(2022, 10, 24, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5010), "tnuva", 23 },
                    { 46, new DateTime(2022, 10, 25, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5012), "refael", 49 },
                    { 47, new DateTime(2022, 10, 26, 22, 45, 43, 238, DateTimeKind.Local).AddTicks(5013), "refael", 68 },
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 47);

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
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 22, 44, 42, 155, DateTimeKind.Local).AddTicks(3089), "El-al", 34 });

            migrationBuilder.UpdateData(
                table: "JobWatchesPerDays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "JobName", "NumberOfWatches" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Refael", 12 });
        }
    }
}
