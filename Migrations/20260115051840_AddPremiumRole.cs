using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    /// <inheritdoc />
    public partial class AddPremiumRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Premium", "PREMIUM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a74d2ca-d513-41ef-8c01-5df4c9e7f0b2", "AQAAAAIAAYagAAAAECJU/BDPalmKKbDby9bQoGKWbudFNHbA/Lo7YT7j8nShFmc1g1wR/BJKjtechDGi8g==", "f1964bdc-0da8-49af-acad-37b0f5f68133" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685ea58a-4277-455c-bcdb-08a11ef78d57", "AQAAAAIAAYagAAAAEG9Q4Ks5gOEYQ4VvvmWr7eCHT9voCoBGuvYbhiH7uIwuLfMXoGOHN8Gnga05CuJVag==", "f976d5b2-28a8-4cd3-a36c-a195fe5bb111" });
        }
    }
}
