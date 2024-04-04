using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{
	public class TrainFare
	{
		public int TrainFareId { get; set; }

		[Required(ErrorMessage = "Train name is required")]
		public string TrainName { get; set; }

		[Required(ErrorMessage = "From station is required")]
		public string From { get; set; }

		[Required(ErrorMessage = "To station is required")]
		public string To { get; set; }

		[Required(ErrorMessage = "Class is required")]
		public string Class { get; set; }
		[Required(ErrorMessage = "Class is required")]
		public float Distance { get; set; }

		[Required(ErrorMessage = "Fare amount is required")]
		public float Fare { get; set; }
	}
}
