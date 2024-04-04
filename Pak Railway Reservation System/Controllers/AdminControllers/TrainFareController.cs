using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Pak_Railway_Reservation_System.Models;
using System;

namespace Pak_Railway_Reservation_System.Controllers.AdminControllers
{
    public class TrainFareController : Controller
    {
        private readonly MyDbContext _Context;

        public TrainFareController(MyDbContext db)
        {
            _Context = db;
        }

        //Http Get Routes
        public IActionResult TrainFares()
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
                    return View(_Context.TrainFares);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                ViewBag.ErrMsg = "An error occurred: " + ex.Message;
                return View();
            }
        }
        public IActionResult EditTrainFares(int id)
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
                    TrainFare trainFare = _Context.TrainFares.Find(id);

                    EditTrainFare ETF = new EditTrainFare();
                    ETF.TrainFareId = id;
                    ETF.Fare = trainFare.Fare;

                    return View(ETF);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                ViewBag.ErrMsg = "An error occurred: " + ex.Message;
                return View();
            }
        }

        //Http Post Routes
        [HttpPost]
        public IActionResult EditTrainFares(EditTrainFare ETF)
        {
            try
            {
                if (HttpContext.Session.GetString("Email") == null)
                {
                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        if (ETF != null)
                        {
                            TrainFare TF = _Context.TrainFares.Find(ETF.TrainFareId);
                            TF.Fare = ETF.Fare;
                            _Context.SaveChanges();
                        }
                        else
                        {
                            ViewBag.ErrMsg = "Something Went Wrong";
                        }
                        return RedirectToAction("TrainFares");
                    }
                    return View(ETF);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                ViewBag.ErrMsg = "An error occurred: " + ex.Message;
                return View(ETF);
            }
        }
    }
}
