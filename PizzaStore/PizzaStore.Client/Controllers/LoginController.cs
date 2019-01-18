using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;

namespace PizzaStore.Client.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var i = new Login();
            return View("Login", i);
        }

        [HttpPost]
        public IActionResult Post(Login login)
        {

            return View("Index");
        }
    }
}