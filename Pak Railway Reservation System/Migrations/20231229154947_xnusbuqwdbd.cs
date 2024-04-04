using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class xnusbuqwdbd : Migration
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
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 2,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 3,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 4,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 5,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 6,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 7,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 8,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 9,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 10,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 11,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 12,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 13,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 14,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 15,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 16,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 17,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 18,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 19,
                column: "TrainScheduleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrainDetails",
                keyColumn: "TrainDetailId",
                keyValue: 20,
                column: "TrainScheduleId",
                value: null);

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
