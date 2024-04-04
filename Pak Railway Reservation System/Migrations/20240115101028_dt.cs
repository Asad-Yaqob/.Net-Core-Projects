using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class dt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "Registers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CNIC",
                table: "Registers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "PassengerDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "CancelTickets",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 1,
                column: "StationImage",
                value: "Karachi_cantt._station_full_facade.jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 2,
                column: "StationImage",
                value: "Hyderabad_Junction_railway_station_(inside_view).jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 4,
                column: "StationImage",
                value: "Lahore_Railway_Station_09.jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 5,
                column: "StationImage",
                value: "Islamabad_Railway_Station_8.png");

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 1,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 17, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 22, 3, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 21, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 15, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                column: "Departure",
                value: new DateTime(2024, 1, 15, 17, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "CNIC",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "PassengerDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "CancelTickets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 1,
                column: "StationImage",
                value: "karachi_image.jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 2,
                column: "StationImage",
                value: "hyderabad_image.jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 4,
                column: "StationImage",
                value: "lahore_image.jpg");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: 5,
                column: "StationImage",
                value: "islamabad_image.jpg");

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
    }
}
