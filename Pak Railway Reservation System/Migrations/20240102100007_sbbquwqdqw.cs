using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class sbbquwqdqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainDetails_TrainSchedules_TrainScheduleId",
                table: "TrainDetails");

            migrationBuilder.DropIndex(
                name: "IX_TrainDetails_TrainScheduleId",
                table: "TrainDetails");

            migrationBuilder.DropColumn(
                name: "TrainScheduleId",
                table: "TrainDetails");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainScheduleId",
                table: "TrainDetails",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 1,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 17, 3, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 22, 3, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 30, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 17, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 21, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 30, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 15, 30, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                columns: new[] { "Departure", "TrainScheduleId" },
                values: new object[] { new DateTime(2023, 12, 30, 17, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.CreateIndex(
                name: "IX_TrainDetails_TrainScheduleId",
                table: "TrainDetails",
                column: "TrainScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainDetails_TrainSchedules_TrainScheduleId",
                table: "TrainDetails",
                column: "TrainScheduleId",
                principalTable: "TrainSchedules",
                principalColumn: "TrainScheduleId");
        }
    }
}
