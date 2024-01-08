using coreFormsAndValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreFormsAndValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost( string username, string password)
        {
            ViewBag.Username = username;
          ViewBag.Password = password;

            return View();
        }

        public IActionResult stronglyTypedLogin() { 
        
            return View();
        
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel model)
        {
            ViewBag.name=model.UserName; ViewBag.Password=model.Password;

            return View();
        }
    }

     
}
