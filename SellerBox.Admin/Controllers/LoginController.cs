using Microsoft.AspNetCore.Mvc;
using SellerBox.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerBox.Admin.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("")] 
        [Route("[action]")] 
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("[action]")]  
        public IActionResult Forgot()
        {
            return View();
        }

        [HttpGet]
        [Route("[action]")] 
        public IActionResult Register()
        {
            return View();
        }


        [HttpGet]
        [Route("[action]")] 
        public IActionResult Logout() { 
            return RedirectToAction("Login", "Login");
        }
    }
}
