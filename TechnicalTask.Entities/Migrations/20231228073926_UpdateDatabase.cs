using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalTask.Entities.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PId",
                table: "Positions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EId",
                table: "Employees",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Positions",
                newName: "PId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EId");
        }
    }
}
