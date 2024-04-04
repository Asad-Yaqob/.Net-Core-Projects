using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pak_Railway_Reservation_System.Models;
using System;

namespace Pak_Railway_Reservation_System.Controllers.AdminControllers
{
    public class TrainScheduleController : Controller
    {
        private readonly MyDbContext _Context;

        public TrainScheduleController(MyDbContext db)
        {
            _Context = db;
        }
        //Http Get Routes
        public IActionResult TrainSchedules()
        {
            try
            {
                var trainSchedules = _Context.TrainSchedules;
                return View(trainSchedules);
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }
        public IActionResult AddTrainSchedules()
        {
            try
            {
                if (HttpContext.Session.GetString("UserRole") == "User")
                {
                    return RedirectToAction("Index", "SearchTrains");
                }

                ViewBag.stationName = new SelectList(_Context.Stations, "StationName", "StationName");
                ViewBag.trainName = _Context.TrainDetails.Select(x => x.TrainName).Distinct().ToList();

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }
        public IActionResult EditTrainSchedule(int eid)
        {
            try
            {
                ViewBag.stationName = new SelectList(_Context.Stations, "StationName", "StationName");
                ViewBag.trainName = _Context.TrainDetails.Select(x => x.TrainName).Distinct().ToList();

                TrainSchedule trainSchedule = _Context.TrainSchedules.Find(eid);
                return View(trainSchedule);
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }
        public IActionResult DeleteTrainSchedule(int id)
        {
            try
            {
                var trainSchedule = _Context.TrainSchedules.Find(id);
                _Context.TrainSchedules.Remove(trainSchedule);
                _Context.SaveChanges();

                return RedirectToAction("TrainSchedules");
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }

        //Http Post Routes

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTrainSchedules(TrainSchedule TS)
        {
            try
            {
                ViewBag.stationName = new SelectList(_Context.Stations, "StationName", "StationName");
                ViewBag.trainName = _Context.TrainDetails.Select(x => x.TrainName).Distinct().ToList();

                // checking validation
                if (ModelState.IsValid)
                {
                    if (TS != null)
                    {
                        _Context.TrainSchedules.Add(TS);
                        _Context.SaveChanges();
                        ModelState.Clear();
                        ViewBag.SuccMsg = "Train Schedule Added Successfully";
                    }
                    else
                    {
                        ViewBag.ErrMsg = "Something Went Wronge";
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTrainSchedule(TrainSchedule ETS)
        {
            try
            {
                ViewBag.stationName = new SelectList(_Context.Stations, "StationName", "StationName");
                ViewBag.trainName = _Context.TrainDetails.Select(x => x.TrainName).Distinct().ToList();

                if (ModelState.IsValid)
                {
                    if (ETS != null)
                    {
                        TrainSchedule TS = _Context.TrainSchedules.Find(ETS.TrainScheduleId);
                        TS.TrainName = ETS.TrainName;
                        TS.Frome = ETS.Frome;
                        TS.To = ETS.To;
                        TS.Date = ETS.Date;
                        TS.Time = ETS.Time;
                        _Context.SaveChanges();
                    }
                    else
                    {
                        ViewBag.ErrMsg = "Something Went Wronge";
                    }
                    return RedirectToAction("TrainSchedules");
                }
                return View(ETS);
            }
            catch (Exception ex)
            {
                ViewBag.ErrMsg($"Exception in TrainSchedules action: {ex}");
                return View();
            }
        }
    }
}
