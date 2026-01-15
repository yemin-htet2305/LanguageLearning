using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageLearning.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceContentText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionOrder",
                table: "LessonContent");

            migrationBuilder.AddColumn<string>(
                name: "ContentText",
                table: "LessonContent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28610dc1-aaef-4cf2-bfca-133836c38f10", "AQAAAAIAAYagAAAAEBsYUYlr4Tj1xUL0jb6o1ScavLFjjPMVzTmXjmD7jTXG0Q497BJbQ+IN9dro2Vit2g==", "5bd49c50-79b4-442b-ad19-35fd5d1052ff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentText",
                table: "LessonContent");

            migrationBuilder.AddColumn<int>(
                name: "PositionOrder",
                table: "LessonContent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a74d2ca-d513-41ef-8c01-5df4c9e7f0b2", "AQAAAAIAAYagAAAAECJU/BDPalmKKbDby9bQoGKWbudFNHbA/Lo7YT7j8nShFmc1g1wR/BJKjtechDGi8g==", "f1964bdc-0da8-49af-acad-37b0f5f68133" });
        }
    }
}
