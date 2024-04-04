using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{
	public class TrainDetail
	{
		public int TrainDetailId { get; set; }

		[Required(ErrorMessage = "Train name is required")]
		public string TrainName { get; set; }

		[Required(ErrorMessage = "From station is required")]
		public string From { get; set; }

		[Required(ErrorMessage = "To station is required")]
		public string To { get; set; }

		[Required(ErrorMessage = "Time is required")]
		[DataType(DataType.Time)]
		public DateTime Departure { get; set; }

		[Required(ErrorMessage = "Number of compartments is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Number of compartments must be 1 or greater")]
		public int Compartments { get; set; } = 3;

		[Required(ErrorMessage = "Number of AC Lower compartments is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Number of AC Lower compartments must be 1 or greater")]
		public int ACLower { get; set; } = 30;

		[Required(ErrorMessage = "Number of AC Business compartments is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Number of AC Business compartments must be 1 or greater")]
		public int ACBusiness { get; set; } = 30;

		[Required(ErrorMessage = "Number of Economy compartments is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Number of Economy compartments must be 1 or greater")]
		public int Ecomomy { get; set; } = 30;
	}
}
