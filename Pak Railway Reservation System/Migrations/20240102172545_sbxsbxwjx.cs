using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class sbxsbxwjx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<float>(
                name: "Bil",
                table: "PassengerDetails",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bil",
                table: "PassengerDetails");

            migrationBuilder.DropColumn(
                name: "From",
                table: "PassengerDetails");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "PassengerDetails");

            migrationBuilder.DropColumn(
                name: "To",
                table: "PassengerDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PassengerDetails",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "PassengerDetails",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
