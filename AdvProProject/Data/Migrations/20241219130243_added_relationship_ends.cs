using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvProProject.Migrations
{
    /// <inheritdoc />
    public partial class added_relationship_ends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Events_EventsId",
                table: "Venues");

            migrationBuilder.RenameColumn(
                name: "EventsId",
                table: "Venues",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Venues_EventsId",
                table: "Venues",
                newName: "IX_Venues_EventId");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Events_EventId",
                table: "Venues",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Events_EventId",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Venues",
                newName: "EventsId");

            migrationBuilder.RenameIndex(
                name: "IX_Venues_EventId",
                table: "Venues",
                newName: "IX_Venues_EventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Events_EventsId",
                table: "Venues",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
