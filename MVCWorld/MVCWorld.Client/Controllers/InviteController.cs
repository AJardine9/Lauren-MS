using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWorld.Client.Models;

namespace MVCWorld.Client.Controllers
{
    [Route("[controller]")]
    public class InviteController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var i = new Invitation();
            i.Name = "fred";
            i.Message = "come to room 200B";

            return View("Invitation", i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(Invitation invite)
        {
            if (ModelState.IsValid)
            {
                if (invite.Rsvp)
                {
                    ViewBag.Name = invite.Name;
                    ViewBag.Guests = invite.Guests;
                    ViewBag.Menu = invite.Rsvp;

                    return View("ThankYou");
                }
                else
                {
                    return View("ShameOnYou");
                }
            }

            // Redirect("/invite");
            // Get(); is a server redirect and is considered to be sketchy
            return RedirectToAction("get");
        }
    }
}