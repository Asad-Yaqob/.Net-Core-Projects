using Microsoft.AspNetCore.Mvc;
using Pak_Railway_Reservation_System.Models;
using System.Diagnostics;

namespace Pak_Railway_Reservation_System.Controllers.AdminControllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _Context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(MyDbContext db, ILogger<HomeController> logger)
        {
            _Context = db;
            _logger = logger;
        }

        //Http Get Routes
        public IActionResult Index()
        {
            try
            {
                if (HttpContext.Session.GetString("UserRole") == "User")
                {
                    return RedirectToAction("Index", "SearchTrains");
                }

                if (HttpContext.Session.GetString("Email") == null)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    // Add cache-control headers to prevent caching
                    Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
                    Response.Headers["Pragma"] = "no-cache";
                    Response.Headers["Expires"] = "0";

                    var currentDate = DateTime.Today;
                   var PassengerDetails = _Context.PassengerDetails.Where(x => x.DateOfTravel == currentDate).ToList();
                    return View(PassengerDetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in HomeController/Index");
                return RedirectToAction("Error", "Home"); // Redirect to error page
            }
        }
        public IActionResult TrainStations()
        {
            try
            {
                if (HttpContext.Session.GetString("UserRole") == "User")
                {
                    return RedirectToAction("Index", "SearchTrains");
                }

                if (HttpContext.Session.GetString("Email") == null)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    return View(_Context.Stations);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in HomeController/TrainStations");
                return RedirectToAction("Error", "Home"); // Redirect to error page
            }
        }
        public IActionResult TrainDetails()
        {
            try
            {
                if (HttpContext.Session.GetString("UserRole") == "User")
                {
                    return RedirectToAction("Index", "SearchTrains");
                }

                if (HttpContext.Session.GetString("Email") == null)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    return View(_Context.TrainDetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in HomeController/TrainDetails");
                return RedirectToAction("Error", "Home"); // Redirect to error page
            }
        }
        public IActionResult PassengerDetails()
        {
            try
            {
                if (HttpContext.Session.GetString("UserRole") == "User")
                {
                    return RedirectToAction("Index", "SearchTrains");
                }

                if (HttpContext.Session.GetString("Email") == null)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    return View(_Context.PassengerDetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in HomeController/PassengerDetails");
                return RedirectToAction("Error", "Home"); // Redirect to error page
            }
        }
    }
}
