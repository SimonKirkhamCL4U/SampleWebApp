using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using RestSharp;
using SimpleWebsite.Models;

namespace SimpleWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new RestClient(ConfigurationManager.AppSettings["ApiAddress"]);
            var request = new RestRequest("api/Users");
            var users = client.Execute<List<User>>(request);
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}