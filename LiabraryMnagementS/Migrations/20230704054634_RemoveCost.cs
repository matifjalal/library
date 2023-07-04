using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiabraryMnagementS.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "booksCatagories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "booksCatagories",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
