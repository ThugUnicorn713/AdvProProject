using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvProProject.Migrations
{
    /// <inheritdoc />
    public partial class added_venue_to_events : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Venue",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Venue",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "Events",
                type: "int",
                nullable: true);
        }
    }
}
