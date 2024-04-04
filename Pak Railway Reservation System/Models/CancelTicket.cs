using NuGet.Versioning;

namespace Pak_Railway_Reservation_System.Models
{
    public class CancelTicket
    {
        public int Id { get; set; }
        public int PNRNo { get; set; }
        public int SeatNo { get; set; }
        public int CoachNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string CNIC { get; set; }
        public int TotalPassenger { get; set; }
        public DateTime DateOfTravel { get; set; }
        public DateTime Time { get; set; }
        public string Class { get; set; }
        public string TrainName { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public float Bil { get; set; }
        public float CancelationFine {  get; set; }
    }
}
