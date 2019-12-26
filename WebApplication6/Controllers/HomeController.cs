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
        public ActionResult Article_gilet(int? id)
        {
            int page = id ?? 0;

            return View(GetCommentsPage(0, 8));
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
        public ActionResult History_of_bikini()
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
        public ActionResult Antinorma()
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
        public ActionResult Online_shopping()
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
        public ActionResult Views_for_millioners()
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






