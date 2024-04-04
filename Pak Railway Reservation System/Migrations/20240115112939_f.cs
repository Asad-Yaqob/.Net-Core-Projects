using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CancelationFine",
                table: "CancelTickets",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelationFine",
                table: "CancelTickets");
        }
    }
}
