using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{

	public class TrainSchedule
	{
		public int TrainScheduleId { get; set; }

		[Required(ErrorMessage = "Train name is required")]
		public string TrainName { get; set; }

		[Required(ErrorMessage = "From station is required")]
		public string Frome { get; set; }

		[Required(ErrorMessage = "To station is required")]
		public string To { get; set; }

		[Required(ErrorMessage = "Date is required")]
		[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

		[Required(ErrorMessage = "Time is required")]
		[DataType(DataType.Time)]
		public DateTime Time { get; set; }

	}
}
