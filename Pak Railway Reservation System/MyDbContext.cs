using Microsoft.EntityFrameworkCore;
using Pak_Railway_Reservation_System.Models;

namespace Pak_Railway_Reservation_System
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
        public DbSet<Register> Registers { get; set; }
		public DbSet<PassengerDetail> PassengerDetails { get; set; }
		public DbSet<Station> Stations { get; set; }
		public DbSet<TrainDetail> TrainDetails { get; set; }
		public DbSet<TrainFare> TrainFares { get; set; }
		public DbSet<TrainSchedule> TrainSchedules { get; set; }
		public DbSet<TrevellerInfo> TrevellerInfos { get; set; }
		public DbSet<CancelTicket> CancelTickets { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Register>().HasData(
				new Register { RegisterId = 1, UserName = "Abdulsamad", UserEmail = "admin@gmail.com", UserPassword = "$2a$10$AJc4UTwgw5CPgnthQUv0qulb84r/FE4dQ5bluq81JrcEys0.BBByO", UserConfirmPassword = "$2a$10$AJc4UTwgw5CPgnthQUv0qulb84r/FE4dQ5bluq81JrcEys0.BBByO", UserRole = "Admin", Age = 19, CNIC = "4230169743053", Gender = "Male", PhoneNo = "03061872272" }
				);

			modelBuilder.Entity<Station>().HasData(
	            new Station { StationId = 1, StationCode = "KHI", StationName = "Karachi", RailwayDivisionName = "Sindh", StationImage = "Karachi_cantt._station_full_facade.jpg" },
	            new Station { StationId = 2, StationCode = "HYD", StationName = "Hyderabad", RailwayDivisionName = "Sindh", StationImage = "Hyderabad_Junction_railway_station_(inside_view).jpg" },
	            new Station { StationId = 3, StationCode = "RHR", StationName = "Rohri", RailwayDivisionName = "Sindh", StationImage = "rohri_image.jpg" },
	            new Station { StationId = 4, StationCode = "LHE", StationName = "Lahore", RailwayDivisionName = "Punjab", StationImage = "Lahore_Railway_Station_09.jpg" },
	            new Station { StationId = 5, StationCode = "ISB", StationName = "Islamabad", RailwayDivisionName = "Punjab", StationImage = "Islamabad_Railway_Station_8.png" }
                );

			modelBuilder.Entity<TrainDetail>().HasData(
// Karakoram Express
new TrainDetail
{
	TrainDetailId = 1,
	TrainName = "1UP Karakoram Express",
	From = "Karachi",
	To = "Lahore",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},
new TrainDetail
{
	TrainDetailId = 2,
	TrainName = "2DN Karakoram Express",
	From = "Lahore",
	To = "Karachi",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},
new TrainDetail
{
	TrainDetailId = 3,
	TrainName = "1UP Karakoram Express",
	From = "Haderabad",
	To = "Lahore",
	Departure = DateTime.Today.Add(new TimeSpan(17, 3, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},
new TrainDetail
{
	TrainDetailId = 4,
	TrainName = "2DN Karakoram Express",
	From = "Lahore",
	To = "Haderabad",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},
new TrainDetail
{
	TrainDetailId = 5,
	TrainName = "1UP Karakoram Express",
	From = "Rohri",
	To = "Lahore",
	Departure = DateTime.Today.Add(new TimeSpan(22, 3, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},
new TrainDetail
{
	TrainDetailId = 6,
	TrainName = "2DN Karakoram Express",
	From = "Lahore",
	To = "Rohri",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 30
},

// Green Line Express
new TrainDetail
{
	TrainDetailId = 7,
	TrainName = "1UP Green Line Express",
	From = "Karachi",
	To = "Islamabad",
	Departure = DateTime.Today.Add(new TimeSpan(16, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 8,
	TrainName = "2DN Green Line Express",
	From = "Islamabad",
	To = "Karachi",
	Departure = DateTime.Today.Add(new TimeSpan(15, 30, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 9,
	TrainName = "1UP Green Line Express",
	From = "Hyderabad",
	To = "Islamabad",
	Departure = DateTime.Today.Add(new TimeSpan(17, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 10,
	TrainName = "2DN Green Line Express",
	From = "Islamabad",
	To = "Hyderabad",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 11,
	TrainName = "1UP Green Line Express",
	From = "Rohri",
	To = "Islamabad",
	Departure = DateTime.Today.Add(new TimeSpan(21, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 12,
	TrainName = "2DN Green Line Express",
	From = "Islamabad",
	To = "Rohri",
	Departure = DateTime.Today.Add(new TimeSpan(15, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 13,
	TrainName = "1UP Green Line Express",
	From = "Lahore",
	To = "Islamabad",
	Departure = DateTime.Today.Add(new TimeSpan(18, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
new TrainDetail
{
	TrainDetailId = 14,
	TrainName = "2DN Green Line Express",
	From = "Islamabad",
	To = "Lahore",
	Departure = DateTime.Today.Add(new TimeSpan(16, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 25
},
// Tezgam Express
new TrainDetail
{
	TrainDetailId = 15,
	TrainName = "1UP Tezgam Express",
	From = "Karachi",
	To = "Hyderabad",
	Departure = DateTime.Today.Add(new TimeSpan(14, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
},
new TrainDetail
{
	TrainDetailId = 16,
	TrainName = "2DN Tezgam Express",
	From = "Hyderabad",
	To = "Karachi",
	Departure = DateTime.Today.Add(new TimeSpan(15, 30, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
},
new TrainDetail
{
	TrainDetailId = 17,
	TrainName = "1UP Tezgam Express",
	From = "Hyderabad",
	To = "Rohri",
	Departure = DateTime.Today.Add(new TimeSpan(16, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
},
new TrainDetail
{
	TrainDetailId = 18,
	TrainName = "2DN Tezgam Express",
	From = "Rohri",
	To = "Hyderabad",
	Departure = DateTime.Today.Add(new TimeSpan(18, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
},
new TrainDetail
{
	TrainDetailId = 19,
	TrainName = "1UP Tezgam Express",
	From = "Karachi",
	To = "Rohri",
	Departure = DateTime.Today.Add(new TimeSpan(15, 30, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
},
new TrainDetail
{
	TrainDetailId = 20,
	TrainName = "2DN Tezgam Express",
	From = "Rohri",
	To = "Karachi",
	Departure = DateTime.Today.Add(new TimeSpan(17, 0, 0)),
	Compartments = 3,
	ACLower = 30,
	ACBusiness = 30,
	Ecomomy = 35
}


);
	modelBuilder.Entity<TrainFare>().HasData(
	new TrainFare { TrainFareId = 1, TrainName = "1UP Karakoram Express", From = "Karachi", To = "Lahore", Class = "AC Lower/Standard", Distance = 1200, Fare = 7000 },
	new TrainFare { TrainFareId = 2, TrainName = "1UP Karakoram Express", From = "Karachi", To = "Lahore", Class = "AC Business", Distance = 1200, Fare = 9000 },
	new TrainFare { TrainFareId = 3, TrainName = "1UP Karakoram Express", From = "Karachi", To = "Lahore", Class = "Economy", Distance = 1200, Fare = 4000 },
	new TrainFare { TrainFareId = 4, TrainName = "1UP Karakoram Express", From = "Hyderabad", To = "Lahore", Class = "AC Lower/Standard", Distance = 1036, Fare = 6000 },
	new TrainFare { TrainFareId = 5, TrainName = "1UP Karakoram Express", From = "Hyderabad", To = "Lahore", Class = "AC Business", Distance = 1036, Fare = 8000 },
	new TrainFare { TrainFareId = 6, TrainName = "1UP Karakoram Express", From = "Hyderabad", To = "Lahore", Class = "Economy", Distance = 1036, Fare = 3000 },
	new TrainFare { TrainFareId = 7, TrainName = "1UP Karakoram Express", From = "Rohri", To = "Lahore", Class = "AC Lower/Standard", Distance = 800, Fare = 5000 },
	new TrainFare { TrainFareId = 8, TrainName = "1UP Karakoram Express", From = "Rohri", To = "Lahore", Class = "AC Business", Distance = 800, Fare = 6000 },
	new TrainFare { TrainFareId = 9, TrainName = "1UP Karakoram Express", From = "Rohri", To = "Lahore", Class = "Economy", Distance = 800, Fare = 2000 },

	new TrainFare { TrainFareId = 10, TrainName = "1UP Green Line Express", From = "Karachi", To = "Islamabad", Class = "AC Lower/Standard", Distance = 1450, Fare = 8000 },
	new TrainFare { TrainFareId = 11, TrainName = "1UP Green Line Express", From = "Karachi", To = "Islamabad", Class = "AC Business", Distance = 1450, Fare = 10000 },
	new TrainFare { TrainFareId = 12, TrainName = "1UP Green Line Express", From = "Karachi", To = "Islamabad", Class = "Economy", Distance = 1450, Fare = 4500 },
	new TrainFare { TrainFareId = 13, TrainName = "1UP Green Line Express", From = "Hyderabad", To = "Islamabad", Class = "AC Lower/Standard", Distance = 1280, Fare = 7000 },
	new TrainFare { TrainFareId = 14, TrainName = "1UP Green Line Express", From = "Hyderabad", To = "Islamabad", Class = "AC Business", Distance = 1280, Fare = 9000 },
	new TrainFare { TrainFareId = 15, TrainName = "1UP Green Line Express", From = "Hyderabad", To = "Islamabad", Class = "Economy", Distance = 1280, Fare = 4500 },
	new TrainFare { TrainFareId = 16, TrainName = "1UP Green Line Express", From = "Rohri", To = "Islamabad", Class = "AC Lower/Standard", Distance = 1050, Fare = 8000 },
	new TrainFare { TrainFareId = 17, TrainName = "1UP Green Line Express", From = "Rohri", To = "Islamabad", Class = "AC Business", Distance = 1050, Fare = 10000 },
	new TrainFare { TrainFareId = 18, TrainName = "1UP Green Line Express", From = "Rohri", To = "Islamabad", Class = "Economy", Distance = 1050, Fare = 4500 },
	new TrainFare { TrainFareId = 19, TrainName = "1UP Green Line Express", From = "Lahore", To = "Islamabad", Class = "AC Lower/Standard", Distance = 375, Fare = 5000 },
	new TrainFare { TrainFareId = 20, TrainName = "1UP Green Line Express", From = "Lahore", To = "Islamabad", Class = "AC Business", Distance = 375, Fare = 7000 },
	new TrainFare { TrainFareId = 21, TrainName = "1UP Green Line Express", From = "Lahore", To = "Islamabad", Class = "Economy", Distance = 375, Fare = 2000 },

	new TrainFare { TrainFareId = 22, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Hyderabad", Class = "AC Lower/Standard", Distance = 165, Fare = 1500 },
	new TrainFare { TrainFareId = 23, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Hyderabad", Class = "AC Business", Distance = 165, Fare = 3000 },
	new TrainFare { TrainFareId = 24, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Hyderabad", Class = "Economy", Distance = 165, Fare = 1000 },
	new TrainFare { TrainFareId = 25, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Rohri", Class = "AC Lower/Stander", Distance = 480, Fare = 3000 },
	new TrainFare { TrainFareId = 26, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Rohri", Class = "AC Business", Distance = 480, Fare = 5000 },
	new TrainFare { TrainFareId = 27, TrainName = "1UP Tezgam Express", From = "Karachi", To = "Rohri", Class = "Economy", Distance = 480, Fare = 1500 },
	new TrainFare { TrainFareId = 28, TrainName = "1UP Tezgam Express", From = "Hyderabad", To = "Rohri", Class = "AC Lower/Standard", Distance = 315, Fare = 2000 },
	new TrainFare { TrainFareId = 29, TrainName = "1UP Tezgam Express", From = "Hyderabad", To = "Rohri", Class = "AC Business", Distance = 315, Fare = 4000 },
	new TrainFare { TrainFareId = 30, TrainName = "1UP Tezgam Express", From = "Hyderabad", To = "Rohri", Class = "Economy", Distance = 315, Fare = 1000 },

	new TrainFare { TrainFareId = 31, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Karachi", Class = "AC Lower/Standard", Distance = 1200, Fare = 7000 },
	new TrainFare { TrainFareId = 32, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Karachi", Class = "AC Business", Distance = 1200, Fare = 9000 },
	new TrainFare { TrainFareId = 33, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Karachi", Class = "Economy", Distance = 1200, Fare = 4000 },
	new TrainFare { TrainFareId = 34, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Hyderabad", Class = "AC Lower/Standard", Distance = 1036, Fare = 6000 },
	new TrainFare { TrainFareId = 35, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Hyderabad", Class = "AC Business", Distance = 11036, Fare = 8000 },
	new TrainFare { TrainFareId = 36, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Hyderabad", Class = "Economy", Distance = 1036, Fare = 3000 },
	new TrainFare { TrainFareId = 37, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Rohri", Class = "AC Lower/Standard", Distance = 800, Fare = 5000 },
	new TrainFare { TrainFareId = 38, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Rohri", Class = "AC Business", Distance = 800, Fare = 6000 },
	new TrainFare { TrainFareId = 39, TrainName = "2DN Karakoram Express", From = "Lahore", To = "Rohri", Class = "Economy", Distance = 800, Fare = 2000 },

	new TrainFare { TrainFareId = 40, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Karachi", Class = "AC Lower/Standard", Distance = 1450, Fare = 8000 },
	new TrainFare { TrainFareId = 41, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Karachi", Class = "AC Business", Distance = 1450, Fare = 10000 },
	new TrainFare { TrainFareId = 42, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Karachi", Class = "Economy", Distance = 1450, Fare = 4500 },
	new TrainFare { TrainFareId = 43, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Hyderabad", Class = "AC Lower/Standard", Distance = 1280, Fare = 7000 },
	new TrainFare { TrainFareId = 44, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Hyderabad", Class = "AC Business", Distance = 1280, Fare = 9000 },
	new TrainFare { TrainFareId = 45, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Hyderabad", Class = "Economy", Distance = 1280, Fare = 4500 },
	new TrainFare { TrainFareId = 46, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Rohri", Class = "AC Lower/Standard", Distance = 1050, Fare = 8000 },
	new TrainFare { TrainFareId = 47, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Rohri", Class = "AC Business", Distance = 1050, Fare = 10000 },
	new TrainFare { TrainFareId = 48, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Rohri", Class = "Economy", Distance = 1050, Fare = 4500 },
	new TrainFare { TrainFareId = 49, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Lahore", Class = "AC Lower/Stander", Distance = 375, Fare = 5000 },
	new TrainFare { TrainFareId = 50, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Lahore", Class = "AC Business", Distance = 375, Fare = 7000 },
	new TrainFare { TrainFareId = 51, TrainName = "2DN Green Line Express", From = "Islamabad", To = "Lahore", Class = "Economy", Distance = 375, Fare = 2000 },

	new TrainFare { TrainFareId = 52, TrainName = "2DN Tezgam Express", From = "Hyderabad", To = "Karachi", Class = "AC Lower/Standard", Distance = 165, Fare = 1500 },
	new TrainFare { TrainFareId = 53, TrainName = "2DN Tezgam Express", From = "Hyderabad", To = "Karachi", Class = "AC Business", Distance = 165, Fare = 3000 },
	new TrainFare { TrainFareId = 54, TrainName = "2DN Tezgam Express", From = "Hyderabad", To = "Karachi", Class = "Economy", Distance = 165, Fare = 1000 },

    new TrainFare { TrainFareId = 55, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Karachi", Class = "AC Lower/Stander", Distance = 480, Fare = 3000 },
    new TrainFare { TrainFareId = 56, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Karachi", Class = "AC Business", Distance = 480, Fare = 5000 },
    new TrainFare { TrainFareId = 57, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Karachi", Class = "Economy", Distance = 480, Fare = 1500 },
    new TrainFare { TrainFareId = 58, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Hyderabad", Class = "AC Lower/Standard", Distance = 315, Fare = 2000 },
    new TrainFare { TrainFareId = 59, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Hyderabad", Class = "AC Business", Distance = 315, Fare = 4000 },
    new TrainFare { TrainFareId = 60, TrainName = "2DN Tezgam Express", From = "Rohri", To = "Hyderabad", Class = "Economy", Distance = 315, Fare = 1000 }


		  );

		}
	}
	
}