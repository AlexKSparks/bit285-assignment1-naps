using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment1_naps.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {

        [HttpGet]
        public IActionResult AccountInfo()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AccountInfo(User user)
        {
            return RedirectToAction("PasswordInfo", user);
        }
        [HttpGet]
        public IActionResult PasswordInfo(User user)
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordInfo(User user, int dummy)
        {
            return RedirectToAction("SelectPassword", user);
        }
        [HttpGet]
        public IActionResult SelectPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SelectPassword(User user)
        {
            return RedirectToAction("ConfirmAccount", user);
        }

        [HttpGet]
        public IActionResult ConfirmAccount(User user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult ConfirmAccount(User user, int dummy)
        {
            return RedirectToAction("Login", user);
        }

        [HttpGet]
        public IActionResult Login(User user)
        {
            return View(user);
        }

        

    }
}
