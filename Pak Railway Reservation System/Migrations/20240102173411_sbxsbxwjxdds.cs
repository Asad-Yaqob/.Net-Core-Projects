using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class sbxsbxwjxdds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Registers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CNIC",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Registers",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "Age", "CNIC", "Gender", "PhoneNo" },
                values: new object[] { 19, "4230169743053", "Male", "03061872272" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "CNIC",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Registers");
        }
    }
}
