using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPatterns.CQRS.Migrations
{
    /// <inheritdoc />
    public partial class mg_des_col : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Products",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Descripton");
        }
    }
}
