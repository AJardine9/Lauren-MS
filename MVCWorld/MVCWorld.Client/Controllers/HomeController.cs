using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWorld.Client.Models;

namespace MVCWorld.Client.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now; // only controller to view
            ViewBag.TimeNow = DateTime.Now; // only controller to view
            ViewBag.Name = "";


            var i = new Invite();
            i.AreYouComing("Fred");

            if (i.RSVP)
            {
                ViewBag.Name = i.Name;
                return View("Pass");
            }

            return View("Fail");
        }
        //[HttpGet]
        //public string Index()
        //{
        //    //return View();
        //    return "hello mvc";
        //}
    }
}