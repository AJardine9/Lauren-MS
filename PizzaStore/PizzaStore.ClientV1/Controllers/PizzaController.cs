using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.ClientV1.Models;
using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.ClientV1.Controllers
{
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index(Order o)
        {
            var x = o.Pizzas.Count();
             return View("Order", o);
        }

        [HttpPost]
        public IActionResult Post(Order o, string ConfirmPizza, string CancelPizza)
        {
            if (!string.IsNullOrWhiteSpace(ConfirmPizza))
            {
                var x = o.Pizzas.Count();
                return View("~/Views/Order/Order.cshtml", o);
            }

            if (!string.IsNullOrWhiteSpace(CancelPizza))
            {
                return View("~/ Views / Order / Order.cshtml", o);
            }

            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}