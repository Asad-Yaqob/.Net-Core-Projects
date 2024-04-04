using Microsoft.AspNetCore.Mvc;
using Pak_Railway_Reservation_System.Models;
using System;

namespace Pak_Railway_Reservation_System.Controllers.AdminControllers
{
    public class AuthController : Controller
    {
        private readonly MyDbContext _dbContext;

        public AuthController(MyDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        //Http Get Routes 
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        /* Logout Start */
        public IActionResult Logout()
        {
            try
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Auth");
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                return RedirectToAction("Login", "Auth");
            }
        }



        //Http Post Routes 
        //user register code 
        [HttpPost]
        public IActionResult Register(Register R)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  var  currentUser = _dbContext.Registers.FirstOrDefault(x => x.UserEmail == R.UserEmail);
                    if (R.UserEmail == currentUser.UserEmail || R.CNIC == currentUser.CNIC || R.PhoneNo == currentUser.PhoneNo)
                    {
                        TempData["ErrorMessage"] = "User Already Exist";
                        return View();
                    }
                    string HashPassword = BCrypt.Net.BCrypt.HashPassword(R.UserPassword);
                    R.UserPassword = HashPassword;
                    R.UserConfirmPassword = HashPassword;
                    _dbContext.Registers.Add(R);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Login", "Home");
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
      
        //user login start 
        [HttpPost]
        public IActionResult Login(Register R)
        {
            try
            {
                var comp = _dbContext.Registers.Where(e => e.UserEmail == R.UserEmail).FirstOrDefault();

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

                    return RedirectToAction("Index", "Home");
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
