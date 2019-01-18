using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;

namespace PizzaStore.Client.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            var i = new Order();
            i.Username = "TestUser";


            return View("Order", i);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return View();
        }
    }
}