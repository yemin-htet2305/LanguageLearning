using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguageLearning.Migrations
{
    /// <inheritdoc />
    public partial class Day116 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "393112c5-ee7b-452d-a870-5bc8db21d245", "AQAAAAIAAYagAAAAELOiouZHfaOYJtUJFDvvU8R2GJ3w40rCZi6xCxCTuFy4N8Pljx2EGj5FdxJXFbNGOA==", "f4b1f628-a842-41e3-9a32-69c006c930a1" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5306), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5316), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5317), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5319), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5320), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5321), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5322), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5324), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5325), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5326), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5328), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5329), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5330), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5331), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5333), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5334), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5335), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5453), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5455), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5457), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5458), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5460), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5461), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5463), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5464), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5466), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5467), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5469), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5470), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5472), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5473), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5475), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5476), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5478), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5479), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5481), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5482), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5484), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5485), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5487), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5488), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5490), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5491), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5493), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5494), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5496), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5497), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5499), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5500), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5502), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5503), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5505), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5506), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5508), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5509), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5511), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5512), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5514), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5518), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5520), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5521), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5522), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5524), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5525), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5527), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5528), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContentText", "DateCreated", "DateUpdated" },
                values: new object[] { "Good Morning", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5625), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Buenos días", "Greetings.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5626), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5627), 10 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Bonjour", "Greetings.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5628), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5628), 13 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ContentText", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Buongiorno", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5630), 28 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Guten Morgen", "Greetings.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5631), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5631), 7 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "おはようございます", "Greetings.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5632), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5632), 31 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Good Afternoon", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5633), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5634), 16 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Buenas tardes", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5635), 10 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Bon après-midi", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5636), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5636), 13 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated" },
                values: new object[] { "Buon pomeriggio", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5637), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Guten Nachmittag", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5639), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5639), 7 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "こんにちは", "Greetings_2.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5640), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5640), 31 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Good Night", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5641), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5642), 16 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Buenas noches", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5643), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5643), 10 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Bonne nuit", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5644), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5644), 13 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Buona notte", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5645), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5646), 28 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Gute Nacht", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5647), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5647), 7 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "おやすみなさい", "Greetings_3.jpg", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5648), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5648), 31 });

            migrationBuilder.InsertData(
                table: "LessonContent",
                columns: new[] { "Id", "ContentText", "ContentType", "CreatedBy", "DateCreated", "DateUpdated", "LessonId", "UpdatedBy" },
                values: new object[,]
                {
                    { 19, "Head", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5649), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5650), 17, "System" },
                    { 20, "Cabeza", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5651), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5651), 11, "System" },
                    { 21, "Tête", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5652), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5653), 14, "System" },
                    { 22, "Testa", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5654), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5654), 29, "System" },
                    { 23, "Kopf", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5655), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5655), 8, "System" },
                    { 24, "頭", "body.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5656), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5657), 32, "System" },
                    { 25, "Hand", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5658), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5658), 17, "System" },
                    { 26, "Mano", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5659), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5659), 11, "System" },
                    { 27, "Main", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5660), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5661), 14, "System" },
                    { 28, "Mano", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5662), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5662), 29, "System" },
                    { 29, "Hand", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5663), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5663), 8, "System" },
                    { 30, "手", "body2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5664), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5664), 32, "System" },
                    { 31, "Leg", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5665), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5666), 17, "System" },
                    { 32, "Pierna", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5667), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5667), 11, "System" },
                    { 33, "Jambe", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5668), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5669), 14, "System" },
                    { 34, "Gamba", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5670), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5670), 29, "System" },
                    { 35, "Bein", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5671), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5671), 8, "System" },
                    { 36, "足", "body3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5672), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5673), 32, "System" },
                    { 37, "Football", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5674), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5674), 18, "System" },
                    { 38, "Fútbol", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5675), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5675), 12, "System" },
                    { 39, "Football", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5676), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5677), 15, "System" },
                    { 40, "Calcio", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5678), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5678), 30, "System" },
                    { 41, "Fußball", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5679), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5679), 9, "System" },
                    { 42, "サッカー", "sport.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5680), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5681), 33, "System" },
                    { 43, "Basketball", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5681), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5682), 18, "System" },
                    { 44, "Baloncesto", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5683), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5683), 12, "System" },
                    { 45, "Basketball", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5685), 15, "System" },
                    { 46, "Pallacanestro", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5686), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5686), 30, "System" },
                    { 47, "Basketball", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5687), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5687), 9, "System" },
                    { 48, "バスケットボール", "sport2.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5689), 33, "System" },
                    { 49, "Golf", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5690), 18, "System" },
                    { 50, "Golf", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5691), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5691), 12, "System" },
                    { 51, "Golf", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5692), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5693), 15, "System" },
                    { 52, "Golf", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5694), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5694), 30, "System" },
                    { 53, "Golf", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5695), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5695), 9, "System" },
                    { 54, "ゴルフ", "sport3.jpg", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5697), 33, "System" }
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "BillingCycle", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "No Need", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5952), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5952), "Free", 0f, "System" },
                    { 2, "6 Month", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5954), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5954), "Premium", 225f, "System" },
                    { 3, "Annual", "System", new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5955), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5956), "Premium Pro", 399f, "System" }
                });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5863), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5866), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5867), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5869), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5871), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5872), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5874), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5876), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5877), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5879), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5881), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5882), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5886), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5887), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5889), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5891), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5892), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5894), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5765), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5767), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5768), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5770), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5771), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5772), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5774), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5775), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5776), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5778), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5779), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5780), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5781), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5783), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5784), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5785), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5787), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5788), new DateTime(2026, 1, 16, 22, 27, 12, 526, DateTimeKind.Local).AddTicks(5788) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b195c71d-ccd6-423e-8f91-d4f0d5481d9d", "AQAAAAIAAYagAAAAEKaOk/+Bwe5HDFlmpO4sGBvJZx+7pQLvjCURci6/QtouTGd3vkL8I02cuRWLhyDJXw==", "050f6013-09f4-4825-a78d-39dd631b5c14" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2865), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2874), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2876), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2877), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2878), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2880), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2882), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2883), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2885), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2886), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2888), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2889), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2891), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2892), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2893), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2894), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3556), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3559), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3560), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3562), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3563), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3565), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3567), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3568), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3570), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3571), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3573), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3574), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3575), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3577), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3578), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3580), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3581), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3583), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3584), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3586), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3587), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3589), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3590), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3592), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3593), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3595), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3596), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3598), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3599), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3601), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3602), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3604), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3605), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3607), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3608), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3610), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3611), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3613), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3614), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3616), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3617), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3620), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3621), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3623), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3624), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3626), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3627), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3630), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3632), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContentText", "DateCreated", "DateUpdated" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3724), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3726), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3726), 17 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3727), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3727), 18 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ContentText", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3728), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3729), 10 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3730), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3730), 11 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3731), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3731), 12 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", "Greetings.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3733), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3733), 13 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3734), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3734), 14 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3735), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3736), 15 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", "Greetings.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3737), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3738), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3738), 29 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3739), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3740), 30 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", "Greetings.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3741), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3741), 7 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3742), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3743), 8 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3744), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3744), 9 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 1: Introduction to Language Learning.", "Greetings.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3745), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3745), 31 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "In this lesson, we will cover the body parts of human beings.", "BodyParts.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3746), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3747), 32 });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ContentText", "ContentType", "DateCreated", "DateUpdated", "LessonId" },
                values: new object[] { "Welcome to Lesson 2: Many kind of sports.", "Sports.jpg", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3748), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3748), 33 });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3959), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3961), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3963), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3965), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3967), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3969), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3972), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3974), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3976), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3978), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3979), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3981), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3983), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3985), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3987), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3988), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3990), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3826), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3827), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3829), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3830), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3831), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3833), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3834), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3836), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3837), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3838), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3840), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3842), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3843), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3844), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3846), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3847), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3849), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3850), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3850) });
        }
    }
}
