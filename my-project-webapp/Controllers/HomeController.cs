using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_project_webapp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace my_project_webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                
                if (model.Username == "user" && model.Password == "password")
                {
                    
                    return RedirectToAction("Dashboard", "Home");
                }

                ModelState.AddModelError("", "Invalid username or password");
            }

            return View("Index", model);
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
