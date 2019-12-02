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
            ViewBag.Title = "Блог о стиле и моде";
            string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            ViewBag.MyID = new string[16];
            ViewBag.MyName = new string[16];
            ViewBag.MyImg = new string[16];
            ViewBag.MyHtml = new string[16];
            ViewBag.MyAction = new string[16];
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select top 15 * from [dbo].[table_content] order by id desc ";
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                ViewBag.MyID[i] = rdr["id"].ToString();
                ViewBag.MyName[i] = rdr["name"].ToString();
                ViewBag.MyImg[i] = rdr["img_code"].ToString();
                ViewBag.MyHtml[i] = rdr["html_code"].ToString();
                ViewBag.MyAction[i] = rdr["action_code"].ToString();
                i++;
            }
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
        public ActionResult Hystory_mode()
        {
            return View();
        }
        public ActionResult Shoes_men()
        {
            return View();
        }

        public ActionResult Dramma_style()
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