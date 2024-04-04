using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class ticketcancel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CancelTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PNRNo = table.Column<int>(type: "int", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    CoachNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPassenger = table.Column<int>(type: "int", nullable: false),
                    DateOfTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bil = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancelTickets", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 1,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 17, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 22, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 21, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                column: "Departure",
                value: new DateTime(2024, 1, 4, 17, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CancelTickets");

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 1,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 17, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 22, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 21, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                column: "Departure",
                value: new DateTime(2024, 1, 2, 17, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
