using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    /// <inheritdoc />
    public partial class ProgressUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Progress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685ea58a-4277-455c-bcdb-08a11ef78d57", "AQAAAAIAAYagAAAAEG9Q4Ks5gOEYQ4VvvmWr7eCHT9voCoBGuvYbhiH7uIwuLfMXoGOHN8Gnga05CuJVag==", "f976d5b2-28a8-4cd3-a36c-a195fe5bb111" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Progress",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa3e1441-dc5c-4f76-9d76-2cbda94a8e30", "AQAAAAIAAYagAAAAEDK/Rh9EORlfZ4D8JkWL/owH4IEVF45qWFjRawiXfvPBOclRZh/ZPvBj4jn+qyLq1w==", "0326fadb-9c1e-4833-95ce-bc811876a736" });
        }
    }
}
