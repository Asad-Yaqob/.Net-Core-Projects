using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pak_Railway_Reservation_System.Models;

namespace Pak_Railway_Reservation_System.Controllers.ClientControllers
{
    public class ClientHomeController : Controller
    {
        private readonly MyDbContext _Context;
        public ClientHomeController(MyDbContext db)
        {
            _Context = db;
        }

        //Http get routes.
        public IActionResult BookTicket()
        {
            ViewBag.stationName = _Context.Stations.Select(x => x.StationName);
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult CalculateFare()
        {
            string registerId = HttpContext.Session.GetString("UserName");

            if (string.IsNullOrEmpty(registerId))
            {
                HttpContext.Session.SetString("returnUrl", Url.Action("Index", "SearchTrains"));
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        public IActionResult Logout()
        {
            try
            {
               
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "ClientHome");
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return RedirectToAction("Login", "ClientHome");
            }
        }

        //Http post routes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalculateFare(string trainName,string From, string To)
        {
            try
            {
                var trainsFares = _Context.TrainFares.Where(x => x.TrainName == trainName && x.From == From && x.To == To).FirstOrDefault();

                if (trainsFares == null)
                {
                    ViewBag.ErrMsg = "No Train Data found for this route";
                }

                ViewBag.Fare = _Context.TrainFares.Where(f => f.TrainName == trainName && f.From == From && f.To == To);
                return View(trainsFares);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Register(Register R)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var currentUser = _Context.Registers.FirstOrDefault(x => x.UserEmail == R.UserEmail);
                    if (R.UserEmail == currentUser.UserEmail || R.CNIC == currentUser.CNIC || R.PhoneNo == currentUser.PhoneNo)
                    {
                        TempData["ErrorMessage"] = "User Already Exist";
                        return View();
                    }
                    string HashPassword = BCrypt.Net.BCrypt.HashPassword(R.UserPassword);
                    R.UserPassword = HashPassword;
                    R.UserConfirmPassword = HashPassword;
                    _Context.Registers.Add(R);
                    _Context.SaveChanges();
                    return RedirectToAction("Login", "ClientHome");
                }
                return View(R);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(R);
            }
        }

        [HttpPost]
        public IActionResult Login(Register R)
        {
            try
            {
                var comp = _Context.Registers.Where(e => e.UserEmail == R.UserEmail).FirstOrDefault();

                if (comp != null && BCrypt.Net.BCrypt.Verify(R.UserPassword, comp.UserPassword))
                {
                    HttpContext.Session.SetString("Email", comp.UserEmail);
                    HttpContext.Session.SetInt32("RegisterID", comp.RegisterId);
                    HttpContext.Session.SetString("UserName", comp.UserName);
                    HttpContext.Session.SetString("UserImage", comp.UserImage);
                    HttpContext.Session.SetString("UserRole", comp.UserRole);

                    // Check if there is a stored URL in the session
                    string returnUrl = HttpContext.Session.GetString("returnUrl");

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        // Clear the stored URL after using it
                        HttpContext.Session.Remove("returnUrl");
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("Index", "SearchTrains");
                }
                else
                {
                    ViewBag.LoginFailed = "Incorrect password or email";
                }

                return View(R);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(R);
            }
        }
    }
}
