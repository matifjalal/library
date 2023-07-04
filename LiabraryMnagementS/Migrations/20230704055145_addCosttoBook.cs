using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiabraryMnagementS.Migrations
{
    /// <inheritdoc />
    public partial class addCosttoBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "books",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "books");
        }
    }
}
