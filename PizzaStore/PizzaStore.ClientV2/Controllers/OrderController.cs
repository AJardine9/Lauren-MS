using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.ClientV2.Models;

namespace PizzaStore.ClientV2.Controllers
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
        public IActionResult Post(Order order)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }
    }
}