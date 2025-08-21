using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMainPractice.Migrations
{
    /// <inheritdoc />
    public partial class RemovePriceFromGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Games");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
