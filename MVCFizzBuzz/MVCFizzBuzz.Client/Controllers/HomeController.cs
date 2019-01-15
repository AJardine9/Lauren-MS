using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCFizzBuzz.Client.Models;

namespace MVCFizzBuzz.Client.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fizz = 0;
            ViewBag.Buzz = 0;
            ViewBag.FizzBuzz = 0;

            var i = new FizzBuzz();
            i.RunFizz();

            ViewBag.Fizz = i.fizz;
            ViewBag.Buzz = i.buzz;
            ViewBag.FizzBuzz = i.fizzbuzzmax;


            return View();
        }
    }
}