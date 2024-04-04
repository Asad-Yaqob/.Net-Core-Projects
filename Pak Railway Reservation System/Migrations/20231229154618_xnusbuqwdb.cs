using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PakRailwayReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class xnusbuqwdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassengerDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PNRNo = table.Column<int>(type: "int", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    CoachNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPassenger = table.Column<int>(type: "int", nullable: false),
                    DateOfTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.RegisterId);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RailwayDivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.StationId);
                });

            migrationBuilder.CreateTable(
                name: "TrainFares",
                columns: table => new
                {
                    TrainFareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<float>(type: "real", nullable: false),
                    Fare = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainFares", x => x.TrainFareId);
                });

            migrationBuilder.CreateTable(
                name: "TrainSchedules",
                columns: table => new
                {
                    TrainScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainSchedules", x => x.TrainScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "TrevellerInfos",
                columns: table => new
                {
                    TrevellerInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrevellerInfos", x => x.TrevellerInfoId);
                });

            migrationBuilder.CreateTable(
                name: "TrainDetails",
                columns: table => new
                {
                    TrainDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Compartments = table.Column<int>(type: "int", nullable: false),
                    ACLower = table.Column<int>(type: "int", nullable: false),
                    ACBusiness = table.Column<int>(type: "int", nullable: false),
                    Ecomomy = table.Column<int>(type: "int", nullable: false),
                    TrainScheduleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainDetails", x => x.TrainDetailId);
                    table.ForeignKey(
                        name: "FK_TrainDetails_TrainSchedules_TrainScheduleId",
                        column: x => x.TrainScheduleId,
                        principalTable: "TrainSchedules",
                        principalColumn: "TrainScheduleId");
                });

            migrationBuilder.InsertData(
                table: "Registers",
                columns: new[] { "RegisterId", "UserConfirmPassword", "UserEmail", "UserImage", "UserName", "UserPassword", "UserRole" },
                values: new object[] { 1, "$2a$10$AJc4UTwgw5CPgnthQUv0qulb84r/FE4dQ5bluq81JrcEys0.BBByO", "samad@gmail.com", "Default_User_Image.png", "Abdulsamad", "$2a$10$AJc4UTwgw5CPgnthQUv0qulb84r/FE4dQ5bluq81JrcEys0.BBByO", "Admin" });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "RailwayDivisionName", "StationCode", "StationImage", "StationName" },
                values: new object[,]
                {
                    { 1, "Sindh", "KHI", "karachi_image.jpg", "Karachi" },
                    { 2, "Sindh", "HYD", "hyderabad_image.jpg", "Hyderabad" },
                    { 3, "Sindh", "RHR", "rohri_image.jpg", "Rohri" },
                    { 4, "Punjab", "LHE", "lahore_image.jpg", "Lahore" },
                    { 5, "Punjab", "ISB", "islamabad_image.jpg", "Islamabad" }
                });

            migrationBuilder.InsertData(
                table: "TrainDetails",
                columns: new[] { "TrainDetailId", "ACBusiness", "ACLower", "Compartments", "Departure", "Ecomomy", "From", "To", "TrainName", "TrainScheduleId" },
                values: new object[,]
                {
                    { 1, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 30, "Karachi", "Lahore", "1UP Karakoram Express", null },
                    { 2, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 30, "Lahore", "Karachi", "2DN Karakoram Express", null },
                    { 3, 30, 30, 3, new DateTime(2023, 12, 29, 17, 3, 0, 0, DateTimeKind.Local), 30, "Haderabad", "Lahore", "1UP Karakoram Express", null },
                    { 4, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 30, "Lahore", "Haderabad", "2DN Karakoram Express", null },
                    { 5, 30, 30, 3, new DateTime(2023, 12, 29, 22, 3, 0, 0, DateTimeKind.Local), 30, "Rohri", "Lahore", "1UP Karakoram Express", null },
                    { 6, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 30, "Lahore", "Rohri", "2DN Karakoram Express", null },
                    { 7, 30, 30, 3, new DateTime(2023, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 25, "Karachi", "Islamabad", "1UP Green Line Express", null },
                    { 8, 30, 30, 3, new DateTime(2023, 12, 29, 15, 30, 0, 0, DateTimeKind.Local), 25, "Islamabad", "Karachi", "2DN Green Line Express", null },
                    { 9, 30, 30, 3, new DateTime(2023, 12, 29, 17, 0, 0, 0, DateTimeKind.Local), 25, "Hyderabad", "Islamabad", "1UP Green Line Express", null },
                    { 10, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 25, "Islamabad", "Hyderabad", "2DN Green Line Express", null },
                    { 11, 30, 30, 3, new DateTime(2023, 12, 29, 21, 0, 0, 0, DateTimeKind.Local), 25, "Rohri", "Islamabad", "1UP Green Line Express", null },
                    { 12, 30, 30, 3, new DateTime(2023, 12, 29, 15, 0, 0, 0, DateTimeKind.Local), 25, "Islamabad", "Rohri", "2DN Green Line Express", null },
                    { 13, 30, 30, 3, new DateTime(2023, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 25, "Lahore", "Islamabad", "1UP Green Line Express", null },
                    { 14, 30, 30, 3, new DateTime(2023, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 25, "Islamabad", "Lahore", "2DN Green Line Express", null },
                    { 15, 30, 30, 3, new DateTime(2023, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 35, "Karachi", "Hyderabad", "1UP Tezgam Express", null },
                    { 16, 30, 30, 3, new DateTime(2023, 12, 29, 15, 30, 0, 0, DateTimeKind.Local), 35, "Hyderabad", "Karachi", "2DN Tezgam Express", null },
                    { 17, 30, 30, 3, new DateTime(2023, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 35, "Hyderabad", "Rohri", "1UP Tezgam Express", null },
                    { 18, 30, 30, 3, new DateTime(2023, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 35, "Rohri", "Hyderabad", "2DN Tezgam Express", null },
                    { 19, 30, 30, 3, new DateTime(2023, 12, 29, 15, 30, 0, 0, DateTimeKind.Local), 35, "Karachi", "Rohri", "1UP Tezgam Express", null },
                    { 20, 30, 30, 3, new DateTime(2023, 12, 29, 17, 0, 0, 0, DateTimeKind.Local), 35, "Rohri", "Karachi", "2DN Tezgam Express", null }
                });

            migrationBuilder.InsertData(
                table: "TrainFares",
                columns: new[] { "TrainFareId", "Class", "Distance", "Fare", "From", "To", "TrainName" },
                values: new object[,]
                {
                    { 1, "AC Lower/Standard", 1200f, 7000f, "Karachi", "Lahore", "1UP Karakoram Express" },
                    { 2, "AC Business", 1200f, 9000f, "Karachi", "Lahore", "1UP Karakoram Express" },
                    { 3, "Economy", 1200f, 4000f, "Karachi", "Lahore", "1UP Karakoram Express" },
                    { 4, "AC Lower/Standard", 1036f, 6000f, "Hyderabad", "Lahore", "1UP Karakoram Express" },
                    { 5, "AC Business", 1036f, 8000f, "Hyderabad", "Lahore", "1UP Karakoram Express" },
                    { 6, "Economy", 1036f, 3000f, "Hyderabad", "Lahore", "1UP Karakoram Express" },
                    { 7, "AC Lower/Standard", 800f, 5000f, "Rohri", "Lahore", "1UP Karakoram Express" },
                    { 8, "AC Business", 800f, 6000f, "Rohri", "Lahore", "1UP Karakoram Express" },
                    { 9, "Economy", 800f, 2000f, "Rohri", "Lahore", "1UP Karakoram Express" },
                    { 10, "AC Lower/Standard", 1450f, 8000f, "Karachi", "Islamabad", "1UP Green Line Express" },
                    { 11, "AC Business", 1450f, 10000f, "Karachi", "Islamabad", "1UP Green Line Express" },
                    { 12, "Economy", 1450f, 4500f, "Karachi", "Islamabad", "1UP Green Line Express" },
                    { 13, "AC Lower/Standard", 1280f, 7000f, "Hyderabad", "Islamabad", "1UP Green Line Express" },
                    { 14, "AC Business", 1280f, 9000f, "Hyderabad", "Islamabad", "1UP Green Line Express" },
                    { 15, "Economy", 1280f, 4500f, "Hyderabad", "Islamabad", "1UP Green Line Express" },
                    { 16, "AC Lower/Standard", 1050f, 8000f, "Rohri", "Islamabad", "1UP Green Line Express" },
                    { 17, "AC Business", 1050f, 10000f, "Rohri", "Islamabad", "1UP Green Line Express" },
                    { 18, "Economy", 1050f, 4500f, "Rohri", "Islamabad", "1UP Green Line Express" },
                    { 19, "AC Lower/Standard", 375f, 5000f, "Lahore", "Islamabad", "1UP Green Line Express" },
                    { 20, "AC Business", 375f, 7000f, "Lahore", "Islamabad", "1UP Green Line Express" },
                    { 21, "Economy", 375f, 2000f, "Lahore", "Islamabad", "1UP Green Line Express" },
                    { 22, "AC Lower/Standard", 165f, 1500f, "Karachi", "Hyderabad", "1UP Tezgam Express" },
                    { 23, "AC Business", 165f, 3000f, "Karachi", "Hyderabad", "1UP Tezgam Express" },
                    { 24, "Economy", 165f, 1000f, "Karachi", "Hyderabad", "1UP Tezgam Express" },
                    { 25, "AC Lower/Stander", 480f, 3000f, "Karachi", "Rohri", "1UP Tezgam Express" },
                    { 26, "AC Business", 480f, 5000f, "Karachi", "Rohri", "1UP Tezgam Express" },
                    { 27, "Economy", 480f, 1500f, "Karachi", "Rohri", "1UP Tezgam Express" },
                    { 28, "AC Lower/Standard", 315f, 2000f, "Hyderabad", "Rohri", "1UP Tezgam Express" },
                    { 29, "AC Business", 315f, 4000f, "Hyderabad", "Rohri", "1UP Tezgam Express" },
                    { 30, "Economy", 315f, 1000f, "Hyderabad", "Rohri", "1UP Tezgam Express" },
                    { 31, "AC Lower/Standard", 1200f, 7000f, "Lahore", "Karachi", "2DN Karakoram Express" },
                    { 32, "AC Business", 1200f, 9000f, "Lahore", "Karachi", "2DN Karakoram Express" },
                    { 33, "Economy", 1200f, 4000f, "Lahore", "Karachi", "2DN Karakoram Express" },
                    { 34, "AC Lower/Standard", 1036f, 6000f, "Lahore", "Hyderabad", "2DN Karakoram Express" },
                    { 35, "AC Business", 11036f, 8000f, "Lahore", "Hyderabad", "2DN Karakoram Express" },
                    { 36, "Economy", 1036f, 3000f, "Lahore", "Hyderabad", "2DN Karakoram Express" },
                    { 37, "AC Lower/Standard", 800f, 5000f, "Lahore", "Rohri", "2DN Karakoram Express" },
                    { 38, "AC Business", 800f, 6000f, "Lahore", "Rohri", "2DN Karakoram Express" },
                    { 39, "Economy", 800f, 2000f, "Lahore", "Rohri", "2DN Karakoram Express" },
                    { 40, "AC Lower/Standard", 1450f, 8000f, "Islamabad", "Karachi", "2DN Green Line Express" },
                    { 41, "AC Business", 1450f, 10000f, "Islamabad", "Karachi", "2DN Green Line Express" },
                    { 42, "Economy", 1450f, 4500f, "Islamabad", "Karachi", "2DN Green Line Express" },
                    { 43, "AC Lower/Standard", 1280f, 7000f, "Islamabad", "Hyderabad", "2DN Green Line Express" },
                    { 44, "AC Business", 1280f, 9000f, "Islamabad", "Hyderabad", "2DN Green Line Express" },
                    { 45, "Economy", 1280f, 4500f, "Islamabad", "Hyderabad", "2DN Green Line Express" },
                    { 46, "AC Lower/Standard", 1050f, 8000f, "Islamabad", "Rohri", "2DN Green Line Express" },
                    { 47, "AC Business", 1050f, 10000f, "Islamabad", "Rohri", "2DN Green Line Express" },
                    { 48, "Economy", 1050f, 4500f, "Islamabad", "Rohri", "2DN Green Line Express" },
                    { 49, "AC Lower/Stander", 375f, 5000f, "Islamabad", "Lahore", "2DN Green Line Express" },
                    { 50, "AC Business", 375f, 7000f, "Islamabad", "Lahore", "2DN Green Line Express" },
                    { 51, "Economy", 375f, 2000f, "Islamabad", "Lahore", "2DN Green Line Express" },
                    { 52, "AC Lower/Standard", 165f, 1500f, "Hyderabad", "Karachi", "2DN Tezgam Express" },
                    { 53, "AC Business", 165f, 3000f, "Hyderabad", "Karachi", "2DN Tezgam Express" },
                    { 54, "Economy", 165f, 1000f, "Hyderabad", "Karachi", "2DN Tezgam Express" },
                    { 55, "AC Lower/Stander", 480f, 3000f, "Rohri", "Karachi", "2DN Tezgam Express" },
                    { 56, "AC Business", 480f, 5000f, "Rohri", "Karachi", "2DN Tezgam Express" },
                    { 57, "Economy", 480f, 1500f, "Rohri", "Karachi", "2DN Tezgam Express" },
                    { 58, "AC Lower/Standard", 315f, 2000f, "Rohri", "Hyderabad", "2DN Tezgam Express" },
                    { 59, "AC Business", 315f, 4000f, "Rohri", "Hyderabad", "2DN Tezgam Express" },
                    { 60, "Economy", 315f, 1000f, "Rohri", "Hyderabad", "2DN Tezgam Express" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainDetails_TrainScheduleId",
                table: "TrainDetails",
                column: "TrainScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassengerDetails");

            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "TrainDetails");

            migrationBuilder.DropTable(
                name: "TrainFares");

            migrationBuilder.DropTable(
                name: "TrevellerInfos");

            migrationBuilder.DropTable(
                name: "TrainSchedules");
        }
    }
}
