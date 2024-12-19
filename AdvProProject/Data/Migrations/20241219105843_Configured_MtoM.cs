using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvProProject.Migrations
{
    /// <inheritdoc />
    public partial class Configured_MtoM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventsId",
                table: "Venues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivitiesEvents",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    EventsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesEvents", x => new { x.ActivitiesId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_ActivitiesEvents_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesEvents_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantEvent",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantEvent", x => new { x.EventId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_ParticipantEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantEvent_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venues_EventsId",
                table: "Venues",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesEvents_EventsId",
                table: "ActivitiesEvents",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantEvent_ParticipantId",
                table: "ParticipantEvent",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Events_EventsId",
                table: "Venues",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Events_EventsId",
                table: "Venues");

            migrationBuilder.DropTable(
                name: "ActivitiesEvents");

            migrationBuilder.DropTable(
                name: "ParticipantEvent");

            migrationBuilder.DropIndex(
                name: "IX_Venues_EventsId",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "EventsId",
                table: "Venues");
        }
    }
}
