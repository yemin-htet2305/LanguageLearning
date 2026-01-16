using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2865), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2872), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2874), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2875), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2876), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2876), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2877), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2877), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2878), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2879), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2880), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2880), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2882), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2882), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2883), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2883), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2885), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2885), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2886), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2887), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2888), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2888), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2889), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2890), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2891), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2891), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2892), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2892), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2893), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2894), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2894), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2895), "System" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(2896), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3556), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3557), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3559), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3559), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3560), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3561), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3562), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3562), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3563), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3564), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3565), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3565), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3567), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3567), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3568), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3568), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3570), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3570), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3571), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3571), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3573), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3573), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3574), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3574), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3575), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3576), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3577), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3577), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3578), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3579), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3580), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3580), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3581), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3582), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3583), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3583), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3584), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3585), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3586), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3586), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3587), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3588), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3589), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3589), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3590), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3591), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3592), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3592), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3593), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3594), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3595), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3595), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3596), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3597), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3598), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3598), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3599), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3599), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3601), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3601), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3602), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3602), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3604), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3604), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3605), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3605), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3607), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3607), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3608), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3608), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3610), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3610), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3611), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3611), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3613), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3613), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3614), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3614), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3616), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3616), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3617), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3617), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3619), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3620), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3620), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3621), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3622), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3623), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3623), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3624), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3625), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3626), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3626), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3627), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3628), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3629), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3630), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3631), "System" });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3632), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3632), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3724), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3724), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3726), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3726), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3727), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3727), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3728), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3729), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3730), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3730), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3731), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3731), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3733), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3733), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3734), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3734), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3735), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3736), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3737), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3737), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3738), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3738), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3739), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3740), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3741), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3741), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3742), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3743), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3744), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3744), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3745), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3745), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3746), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3747), "System" });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3748), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3748), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3959), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3959), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3961), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3962), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3963), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3964), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3965), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3965), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3967), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3967), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3969), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3969), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3971), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3972), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3972), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3974), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3974), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3976), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3976), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3978), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3978), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3979), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3980), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3981), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3982), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3983), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3983), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3985), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3985), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3987), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3987), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3988), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3989), "System" });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3990), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3990), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3826), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3826), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3827), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3828), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3829), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3829), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3830), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3830), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3831), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3832), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3833), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3833), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3834), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3835), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3836), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3836), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3837), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3837), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3838), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3839), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3840), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3840), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3842), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3842), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3843), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3843), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3844), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3845), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3846), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3846), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3847), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3848), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3849), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3849), "System" });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3850), new DateTime(2026, 1, 16, 16, 47, 11, 918, DateTimeKind.Local).AddTicks(3850), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce43eaa-c1aa-45f5-9cdd-bc5d16741774", "AQAAAAIAAYagAAAAELhZg5X5TuH585H+q1fD0AIoKKMpATXzULpnO3r4G/6o3R7fh+MBKaI94tf6XW2qpA==", "02a54682-94d3-4b5b-a9bd-63d4be7f0a89" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "LessonContent",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quession",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
