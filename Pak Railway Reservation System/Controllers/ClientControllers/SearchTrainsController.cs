using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pak_Railway_Reservation_System.Models;
using System.Diagnostics.CodeAnalysis;

namespace Pak_Railway_Reservation_System.Controllers.ClientControllers
{
	public class SearchTrainsController : Controller
	{
        private readonly MyDbContext _Context;
        public SearchTrainsController(MyDbContext db)
        {
            _Context = db;
        }
        public IActionResult Index()
		{
            ViewBag.stationName = _Context.Stations.Select(x => x.StationName);
            return View();
		}
        public IActionResult SearchTrains(string From, string To, DateTime Date)
        {
            try
            {
                int registerId = HttpContext.Session.GetInt32("RegisterID") ?? 0;

                if (registerId == 0)
                {
                    HttpContext.Session.SetString("returnUrl", Url.Action("Index", "SearchTrains"));
                    return RedirectToAction("Login", "Home");
                }
                var TS = _Context.TrainSchedules
                    .Where(t => t.Frome == From && t.To == To && t.Date.Date == Date.Date)
                    .ToList();
                // Fetch train fares
                ViewBag.Fare = _Context.TrainFares.Where(f => f.From == From && f.To == To);

                return View(TS);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View();
            }
        }
        public IActionResult CancelTicket()
        {
            try {
                int registerId = HttpContext.Session.GetInt32("RegisterID") ?? 0;

                if (registerId == 0)
                {
                    HttpContext.Session.SetString("returnUrl", Url.Action("Index", "SearchTrains"));
                    return RedirectToAction("Login", "Home");
                }
                return View();
               }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CancelTicket(int PNRNO)
        {
            try
            {
                PassengerDetail isValidPnrNo = _Context.PassengerDetails.FirstOrDefault(x => x.PNRNo == PNRNO);

                if (isValidPnrNo != null)
                {
                    ViewBag.ticketFound = "Your Ticket is here..";
                    return View(isValidPnrNo);
                }
                TempData["ErrMsg"] = "Invalid PNR No";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View();
            }
        }
        public IActionResult DeleteTicket(int id)
        {
            try
            {
                PassengerDetail PassngDetail = _Context.PassengerDetails.FirstOrDefault(x => x.PNRNo == id);

                if (PassngDetail != null)
                {
                    float FineAmount = 500;
                    _Context.PassengerDetails.Remove(PassngDetail);

                    //now inserting cancel ticket info into a table to have a record
                    CancelTicket cancelTicket = new CancelTicket();
                    cancelTicket.PNRNo = PassngDetail.PNRNo;
                    cancelTicket.Name = PassngDetail.Name;
                    cancelTicket.Age = PassngDetail.Age;
                    cancelTicket.Gender = PassngDetail.Gender;
                    cancelTicket.SeatNo = PassngDetail.SeatNo;
                    cancelTicket.CoachNo = PassngDetail.CoachNo;
                    cancelTicket.CNIC = PassngDetail.CNIC;
                    cancelTicket.PhoneNo = PassngDetail.PhoneNo;
                    cancelTicket.From = PassngDetail.From;
                    cancelTicket.To = PassngDetail.To;
                    cancelTicket.TrainName = PassngDetail.TrainName;
                    cancelTicket.DateOfTravel = PassngDetail.DateOfTravel;
                    cancelTicket.TotalPassenger = PassngDetail.TotalPassenger;
                    cancelTicket.Class = PassngDetail.Class;
                    cancelTicket.CancelationFine = PassngDetail.TotalPassenger * FineAmount;
                    cancelTicket.Bil = PassngDetail.Bil - cancelTicket.CancelationFine;
                    cancelTicket.Time = PassngDetail.Time;


                    _Context.CancelTickets.Add(cancelTicket);
                    _Context.SaveChanges();

                    TempData["SuccMsg"] = "Your Ticket has been  Canceled";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrMsg"] = "Something Went Wronge";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return RedirectToAction("SearchTrains");
            }

        }
        
        [HttpPost]
        public IActionResult ReserveSeat(string TrainName, string From, string To, DateTime Date, DateTime Time, string Class, int NOP)
        {
            try
            {
                int registerId = HttpContext.Session.GetInt32("RegisterID") ?? 0;

                var UserInfo = _Context.Registers.FirstOrDefault(u => u.RegisterId == registerId);

                var fare = _Context.TrainFares.FirstOrDefault(f => f.From == From && f.To == To && f.TrainName == TrainName && f.Class == Class);
                if (fare == null)
                {
                    return RedirectToAction("SearchTrains");
                }
                else
                {

                    // Generate unique system-assigned values
                    var systemGeneratedValues = GenerateUniqueSystemValues();

                    PassengerDetail PD = new PassengerDetail
                    {
                        PNRNo = systemGeneratedValues.PNRNo,
                        SeatNo = systemGeneratedValues.SeatNo,
                        CoachNo = systemGeneratedValues.CoachNo,
                        Name = UserInfo.UserName,
                        PhoneNo = UserInfo.PhoneNo,
                        CNIC = UserInfo.CNIC,
                        Age = UserInfo.Age,
                        Gender = UserInfo.Gender,
                        TrainName = TrainName,
                        Class = Class,
                        From = From,
                        To = To,
                        DateOfTravel = Date,
                        TotalPassenger = NOP,
                        Time = Time,
                        Bil = NOP * fare.Fare
                    };

                    _Context.PassengerDetails.Add(PD);
                    _Context.SaveChanges();

                    TempData["SuccMsg"] = "Your Ticket has been booked";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return RedirectToAction("SearchTrains");
            }
        }
        // Helper method to generate unique system-assigned values
        private SystemGeneratedValues GenerateUniqueSystemValues()
        {
            return new SystemGeneratedValues
            {
                PNRNo = GenerateRandomNumber(10000, 99999),
                SeatNo = GenerateRandomNumber(1, 30),
                CoachNo = GenerateRandomNumber(1, 3)
            };
        }

        // Generate a unique value based on timestamp and unique identifier
        private int GenerateUniqueValue()
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Guid uniqueId = Guid.NewGuid();
            string uniqueValueString = $"{timestamp}{uniqueId:N}";
            return uniqueValueString.GetHashCode();
        }

        // Generate a random number within the specified range
        private int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        // Define a class to hold system-generated values
        public class SystemGeneratedValues
        {
            public int PNRNo { get; set; }
            public int SeatNo { get; set; }
            public int CoachNo { get; set; }
        }

    }
}
