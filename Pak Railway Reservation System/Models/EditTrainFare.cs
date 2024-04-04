using System.ComponentModel.DataAnnotations;

namespace Pak_Railway_Reservation_System.Models
{
    public class EditTrainFare
    {
        public int TrainFareId { get; set; }

        [Required(ErrorMessage = "Fare amount is required")]
        public float Fare { get; set; }
    }
}
