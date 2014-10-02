using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What exactly are we and what do we do?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch with us today to learn how we can help you learn to code and get a job.";

            return View();
        }
    }
}