using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirst.Models;

namespace WebAppFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Myclass obj = new Myclass();
            obj.name = "Sanjay Singh";
            obj.age = 20;
            obj.email = "sanjaysinghcs9696@gmail.com";

            return View(obj);
        }

        public ActionResult Contact()
        {
            ViewBag.san = "This is Chetu India";
            ViewBag.data = 84258;
            ViewBag.data1 = 436.5f;
            ViewBag.data2 = DateTime.Now;
            ViewBag.list = new List<string>()
            {
                "Mirzapur",
                "Noida",
                "Lucknow",
            };

            ViewData["abc"] = "This is data from chetu india";
            ViewData["data"] = 14000;
            ViewData["data1"] = 500.4f;
            ViewData["data2"] = DateTime.Now;
            ViewData["list"] = new List<string>()
            {
                "Japan",
                "India",
                "Ressia",
            };

            TempData["abc"] = "This is Tempdata ";
            TempData["data"] = 123;
            TempData["data1"] = 53.4f;
            TempData["data2"] = DateTime.Now;

            Session["abc"] = "Hey Sanjay Singh Here";

            return View();
        }
    }
}