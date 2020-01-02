using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;


namespace WebApplication6.Controllers
{

    public class HomeController : Controller
    {
        List<Comments> comments;
        List<Article> articles;
        const int pageSize = 9;
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

        public ActionResult Blogs(int? id)
        {
            int page = id ?? 0;
            if (Request.IsAjaxRequest())
            {
                return PartialView("Blog1part", GetItemsPage(page));
            }
            return View(GetItemsPage(0));
        }
        public ActionResult Article_gilet(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 8));
        }

        public ActionResult Dramma_style(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 15));
        }
        public ActionResult Hystory_mode(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 14));
        }
        public ActionResult Shoes_men(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 13));
        }
        public ActionResult Read_Coco(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 12));
        }
        public ActionResult Black_Friday(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 11));
        }
        public ActionResult Travel_Bagage(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 10));
        }
        public ActionResult Skin(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 9));
        }
        public ActionResult Stylist_for_photosession(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 7));
        }
        public ActionResult Dont_trust_stylist(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 6));
        }
        public ActionResult Services_stylist(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 5));
        }
        public ActionResult Grange(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 4));
        }
        public ActionResult Style_casual(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 3));
        }
        public ActionResult Base(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 2));
        }
        public ActionResult Belt(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 1));
        }
        public ActionResult Bomber(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 24));
        }
        public ActionResult Kristoal_balensiaga(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 23));
        }
        public ActionResult Serials(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 22));
        }
        public ActionResult Shirt(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 21));
        }
        public ActionResult Nechego_nadet(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 20));
        }
        public ActionResult Change_jeans(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 19));
        }
        public ActionResult Ties(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 18));
        }
        public ActionResult Style_Military(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 17));
        }
        public ActionResult Style_Safari(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 16));
        }
        public ActionResult Style_Romantic(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 25));
        }
        public ActionResult Style_Retro(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 27));
        }
        public ActionResult Style_Female(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 26));
        }
        public ActionResult History_of_bikini(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 29));
        }
        public ActionResult Views_for_millioners(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 28));
        }
        public ActionResult Online_shopping(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 30));
        }
        public ActionResult Antinorma(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 31));
        }
        public ActionResult Color_winter(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 32));
        }
        public ActionResult Famous_Dress(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 33));
        }
        public ActionResult Color_Spring(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 34));
        }
        public ActionResult Why_Women_Kills(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 35));
        }
        public ActionResult Color_Summer(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 36));
        }
        public ActionResult Summary_2019(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 37));
        }
        public ActionResult Actual_Knitwear(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 38));
        }
        public HomeController()
        {
            ViewBag.Title = "Блог о стиле и моде";
        }

        private List<Article> GetItemsPage(int page = 1)
        {
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
                     new Article { MyId = Convert.ToInt32(rdr["id"].ToString()), MyImg = rdr["img_code"].ToString(), MyName = rdr["name"].ToString(), MyHtml = rdr["html_code"].ToString(), MyAction = rdr["action_code"].ToString(), MyDate = rdr["dates"].ToString() });
            }
            var itemsToSkip = page * pageSize;
            return articles.OrderByDescending(t => t.MyId).Skip(itemsToSkip).
                Take(pageSize).ToList();
        }
        private List<Comments> GetCommentsPage(int page = 1, int idArticle = 1)
        {
            string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select * from [comments] where id =" + idArticle + " order by [ID_comment] desc ";
            SqlDataReader rdr = cmd.ExecuteReader();
            comments = new List<Comments>();
            while (rdr.Read())
            {
                comments.Add(
                     new Comments { Id = Convert.ToInt32(rdr["id"].ToString()), Comment = rdr["Comment"].ToString(), User = rdr["User"].ToString(), Dates = rdr["Dates"].ToString(), IdComment = rdr["ID_comment"].ToString(), Like = rdr["Like"].ToString(), Gender = "/img/icons/" + rdr["Gender"].ToString() + ".png" });
            }

            var itemsToSkip = page * pageSize;
            return comments.OrderByDescending(t => t.Id).Skip(itemsToSkip).
                Take(pageSize).ToList();
        }

         public ActionResult Sitemap()
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
            string name = Request.Form["Name"];
            string email = Request.Form["Email"];
            string phone = Request.Form["Phone"];
            string text = Request.Form["Texts"];
            string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO [Orders] ([Name],[Email],[Phone],[Dates],[TExts]) VALUES('" + name + "','" + email + "', '" + phone + "', GETDATE ( ), '" + text + "')";
            cmd.ExecuteNonQuery();
            return View("Thanks", guestResponse);
        }
        [HttpPost]
        public ActionResult Contact(GuestResponse guestResponse)
        {

            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                string name = Request.Form["Name"];
                string email = Request.Form["Email"];
                string phone = Request.Form["Phone"];
                string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO [Orders] ([Name],[Email],[Phone],[Dates]) VALUES('" + name + "','" + email + "', '" + phone + "', GETDATE ( )) ";
                cmd.ExecuteNonQuery();
                return View("Thanks", guestResponse);

            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        [HttpPost]
        public ActionResult Article_gilet()
        {
            return View("", DbAddComments());
        }

        [HttpPost]
        public ActionResult Dramma_style()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Hystory_mode()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Shoes_men()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Read_Coco()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Black_Friday()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Travel_Bagage()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Skin()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Stylist_for_photosession()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Dont_trust_stylist()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Services_stylist()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Grange()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_casual()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Base()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Belt()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Bomber()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Kristoal_balensiaga()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Serials()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Shirt()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Nechego_nadet()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Change_jeans()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Ties()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_Military()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_Safari()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_Romantic()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_Retro()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Style_Female()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult History_of_bikini()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Views_for_millioners()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Online_shopping()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Antinorma()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Color_winter()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Famous_Dress()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Color_Spring()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Why_Women_Kills()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Color_Summer()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Summery_2019()
        {
            return View("", DbAddComments());
        }
        [HttpPost]
        public ActionResult Actual_Knitwear()
        {
            return View("", DbAddComments());
        }

        public string DbAddComments()
        {
            string lik;
            string id = "0";
            if (Request.Browser.IsMobileDevice)
            {
                lik = "mobile";
            }
            else
            {
                lik = "globe";
            }
            string action = Request.Url.AbsolutePath.Replace("/Home/", "");

            string user = Request.Form["User"];
            string comment = Request.Form["Comment"];
            string dzen = Request.Form["dzen"];
            Random rnd = new Random();
            int value;
            if (dzen == "muz")
            {
                value = rnd.Next(1, 5);
            }
            else
            {
                value = rnd.Next(7, 12);
            }
            if (user != "" && comment != "")
            {
                // TODO: Email response to the party organizer
                string connectionString = "Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = F#edj106";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlConnection connection1 = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select id from [dbo].[table_content] where action_code='" + action + "'";
                cmd.Connection = connection;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr["id"].ToString();
                }
                rdr.Close();
                //cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO[Comments] ([Id],[Comment],[User],[Dates],[Like],[ID_comment], Gender)" +
                    " VALUES((Select id from [dbo].[table_content] where action_code='" + action + "'), '" +
                    comment + "', '" + user + "', GETDATE(), '" + lik + "'," + "(select isnull(max([ID_comment]),0)+1 FROM COMMENTS WHERE id=(Select id from[dbo].[table_content] where action_code = '" + action + "'))," + value + ")";

                cmd.ExecuteNonQuery();

            }
            Response.Redirect(Request.RawUrl);
            return "";
        }
    }
}






