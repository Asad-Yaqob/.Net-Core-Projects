using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class dd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfTravel",
                table: "PassengerDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfTravel",
                table: "CancelTickets",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 1,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 17, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 22, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 21, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                column: "Departure",
                value: new DateTime(2024, 1, 13, 17, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfTravel",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfTravel",
                table: "CancelTickets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
