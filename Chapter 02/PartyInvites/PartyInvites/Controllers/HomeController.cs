using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            } else {
                // there is a validation error
                return View();
            }
        }

        [ChildActionOnly]
        public ActionResult Attendees()
        {
            var model = from r in Repository.Responses
                        where r.WillAttend == true
                        select r;
            return View(model);
        }
    }
}