using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMainPractice.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Games",
                newName: "DescriptionOfGame");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriptionOfGame",
                table: "Games",
                newName: "Description");
        }
    }
}
