using Microsoft.AspNetCore.Mvc;
using Pak_Railway_Reservation_System.Models;

namespace Pak_Railway_Reservation_System.Controllers.ClientControllers
{
    public class ProfileController : Controller
    {
        private readonly IWebHostEnvironment _host;
        private readonly MyDbContext _dbContext;

        public ProfileController(MyDbContext dbContext, IWebHostEnvironment host)
        {
            _dbContext = dbContext;
            _host = host;
        }

        // Http Get Routes
        public IActionResult MyProfile()
        {
            try
            {
                int registerId = HttpContext.Session.GetInt32("RegisterID") ?? 0;

                if (registerId == 0)
                {
                    HttpContext.Session.SetString("returnUrl", Url.Action("MyProfile", "ClientProfile"));
                    return RedirectToAction("Login", "Home");
                }

                var profile = _dbContext.Registers.Where(p => p.RegisterId == registerId).FirstOrDefault();
                return View(profile);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }
        public IActionResult ChangePassword()
        {
            try
            {
                int registerId = HttpContext.Session.GetInt32("RegisterID") ?? 0;

                if (registerId == 0)
                {
                    HttpContext.Session.SetString("returnUrl", Url.Action("MyProfile", "ClientProfile"));
                    return RedirectToAction("Login", "Home");
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }
        public IActionResult YourBooking()
        {
            try
            {
                string userName = HttpContext.Session.GetString("UserName");

                if (userName == null)
                {
                    HttpContext.Session.SetString("returnUrl", Url.Action("MyProfile", "ClientProfile"));
                    return RedirectToAction("Login", "Home");
                }
                var passengerDetails = _dbContext.PassengerDetails.Where(x => x.Name == userName).ToList();
                return View(passengerDetails);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }

        // Http Post Routes
        [HttpPost]
        public IActionResult UpdateClientInfo(Register R)
        {
            try
            {
                Register r = _dbContext.Registers.Find(R.RegisterId);
                r.UserName = R.UserName;
                r.UserEmail = R.UserEmail;
                _dbContext.SaveChanges();
                TempData["Data"] = "User Info Change Successfully";
                return RedirectToAction("MyProfile");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdateClientPassword(int R, string OldPass, string NewPass, string C_NewPass)
        {
            try
            {
                Register r = _dbContext.Registers.Find(R);

                if (BCrypt.Net.BCrypt.Verify(OldPass, r.UserPassword))
                {
                    if (NewPass == C_NewPass)
                    {
                        string HashPassword = BCrypt.Net.BCrypt.HashPassword(NewPass);
                        r.UserPassword = HashPassword;
                        r.UserConfirmPassword = HashPassword;
                        _dbContext.SaveChanges();

                        TempData["Data"] = "User Password Change Successfully";
                        return RedirectToAction("MyProfile");
                    }
                    else
                    {
                        TempData["PNM"] = "Password Not Match";
                    }
                }
                else
                {
                    TempData["IOP"] = "Incorrect Old Password";
                }
                return RedirectToAction("ChangePassword");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }

        [HttpPost]
        public IActionResult UpdateClientImage(Register R, IFormFile UserImage)
        {
            try
            {
                Register r = _dbContext.Registers.Find(R.RegisterId);

                string File = Path.Combine(_host.WebRootPath, "images", Path.GetFileName(UserImage.FileName));
                UserImage.CopyTo(new FileStream(File, FileMode.Create));
                r.UserImage = UserImage.FileName;

                _dbContext.SaveChanges();
                TempData["Data"] = "Image Change Successfully";
                return RedirectToAction("MyProfile");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return View(ex);
            }
        }
    }
}
