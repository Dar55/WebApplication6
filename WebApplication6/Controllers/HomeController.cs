using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Index_1()
        {
            return View();
        }
        public ActionResult Index_2()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Article_gilet()
        {
            return View();
        }
        public ActionResult Stylist_for_photosession()
        {
            return View();
        }
        public ActionResult Skin()
        {
            return View();
        }
        public ActionResult Dont_trust_stylist()
        {
            return View();
        }
        public ActionResult Services_stylist()
        {
            return View();
        }
        public ActionResult Grange()
        {
            return View();
        }
        public ActionResult Belt()
        {
            return View();
        }
        public ActionResult Base()
        {
            return View();
        }
        public ActionResult Style_casual()
        {
            return View();
        }
        public ActionResult Blogs()
        {
            return View();
        }
        public ActionResult Travel_Bagage()
        {
            return View();
        }
        public ActionResult Black_Friday()
        {
            return View();
        }
        public ActionResult Read_Coco()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            {
                if (ModelState.IsValid)
                {
                    // TODO: Email response to the party organizer
                    return View("Thanks", guestResponse);
                }
                else
                {
                    // there is a validation error
                    return View();
                }
            }
        }
    }
}