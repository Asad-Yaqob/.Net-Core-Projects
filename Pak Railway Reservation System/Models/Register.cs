using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{
	public class Register
	{
		public int RegisterId { get; set; }

		[Required, Display(Name = "Name", Prompt = "Enter Youe UserName")]
		public string UserName { get; set; }

		[Required, Display(Name = "Email", Prompt = "Enter Your Email")]
		[EmailAddress]
		public string UserEmail { get; set; }

        [Required(ErrorMessage = "Age is required"), Display(Name = "Age", Prompt = "Enter Your Age")]
        [Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or greater")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required"), Display(Name = "Gender", Prompt = "Enter Your Gender")]
        public string Gender { get; set; } 

        [Required(ErrorMessage = "Phone number is required"), Display(Name = "Phone No", Prompt = "Enter Your Phone No"), MaxLength(11, ErrorMessage = "Phone no must be 11 digits")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be 11 digits")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "CNIC is required"), Display(Name = "CNIC", Prompt = "Enter Your CNIC"), MaxLength(13, ErrorMessage = "CNIC must be 13 digits")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "CNIC must be 13 digits")]
        public string CNIC { get; set; }


        [Required, Display(Name = "Password", Prompt = "Enter Your Password"), DataType(DataType.Password)]
		public string UserPassword { get; set; }

		[Required, Display(Name = "Password", Prompt = "Enter Your Password"),
		 DataType(DataType.Password), Compare(nameof(UserPassword))]
		[RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = " 1 numaric and alphabet character and alteast 8 characters")]
		public string UserConfirmPassword { get; set; }
		public string UserRole { get; set; } = "User";
		public string UserImage { get; set; } = "Default_User_Image.png";

	}
}
