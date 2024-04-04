using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{

	public class Station
	{
		public int StationId { get; set; }

		[Required(ErrorMessage = "Station code is required")]
		public string StationCode { get; set; }

		[Required(ErrorMessage = "Station name is required")]
		public string StationName { get; set; }

		[Required(ErrorMessage = "Railway division name is required")]
		public string RailwayDivisionName { get; set; }
		public string StationImage { get; set; }
	}
}
