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
        List<Article> articles;
        const int pageSize = 9;
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Style_Retro()
        {

            return View();
        }
        public ActionResult Style_Female()
        {

            return View();
        }
        public ActionResult Style_Romantic()
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
        public ActionResult Blogs(int? id)
        {
            int page = id ?? 0;
            if (Request.IsAjaxRequest())
            {
                return PartialView("Blog1part", GetItemsPage(page));
            }
            return View(GetItemsPage(0));
        }
        public HomeController()
        {
            ViewBag.Title = "Блог о стиле и моде";
            string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select * from [dbo].[table_content] order by id desc ";
            SqlDataReader rdr = cmd.ExecuteReader();
            articles = new List<Article>();
            while (rdr.Read())
            {
               articles.Add(
                    new Article { MyId = Convert.ToInt32(rdr["id"].ToString()), MyImg = rdr["img_code"].ToString(), MyName = rdr["name"].ToString(), MyHtml = rdr["html_code"].ToString(), MyAction = rdr["action_code"].ToString() });
            }
        }

        private List<Article> GetItemsPage(int page = 1)
        {
            var itemsToSkip = page * pageSize;
            return articles.OrderByDescending(t => t.MyId).Skip(itemsToSkip).
                Take(pageSize).ToList();
        }
        public ActionResult Travel_Bagage()
        {
            return View();
        }
        public ActionResult Style_Safari()
        {
            return View();
        }
        public ActionResult Bomber()
        {
            return View();
        }
        public ActionResult Kristoal_balensiaga()
        {
            return View();
        }
        public ActionResult Serials()
        {
            return View();
        }
        public ActionResult Change_Jeans()
        {
            return View();
        }
        

        public ActionResult Shirt()
        {
            return View();
        }
        
        public ActionResult Nechego_nadet()
        {
            return View();
        }
        public ActionResult Ties()
        {
            return View();
        }
        public ActionResult Sitemap()
        {
            return View();
        }
        public ActionResult Style_Military()
        {
            return View();
        }
        public ActionResult TEST()
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
        [HttpPost]
        public ActionResult Index(GuestResponse guestResponse)
        {
                    return View("Thanks", guestResponse);
        }
        [HttpPost]
        public ActionResult Contact(GuestResponse guestResponse)
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