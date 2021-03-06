﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.ClientV1.Models;
using Microsoft.AspNetCore.Authorization;

namespace PizzaStore.ClientV1.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var i = new Order();
            i.Username = "TestUser";

            return View("Order", i);
        }

        [HttpPost]
        public IActionResult Post(Order o, string AddPizzaToOrder, string CompleteOrder)
        {
            if (!string.IsNullOrWhiteSpace(AddPizzaToOrder))
            {
                var x = o.Pizzas.Count();
                return View("~/Views/Pizza/Pizza.cshtml",  o);
            }

            if (!string.IsNullOrWhiteSpace(CompleteOrder))
            {
                return View("Complete", o);
            }
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}