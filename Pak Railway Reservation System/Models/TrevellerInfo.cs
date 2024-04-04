using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{
	public class TrevellerInfo
	{
		public int TrevellerInfoId { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[StringLength(100, ErrorMessage = "Name must not exceed 100 characters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Age is required")]
		[Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or greater")]
		public int Age { get; set; }

		[Required(ErrorMessage = "Gender is required")]
		public char Gender { get; set; }

		[Required(ErrorMessage = "Phone number is required")]
		[RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be 11 digits")]
		public string PhoneNo { get; set; }

		[Required(ErrorMessage = "CNIC is required")]
		[RegularExpression(@"^\d{13}$", ErrorMessage = "CNIC must be 13 digits")]
		public string CNIC { get; set; }
	}
}
