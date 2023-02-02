using HelperTags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperTags.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Students std)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View("IndexD",std);
            }

            return View("Index");

        }
        public ActionResult About(Students std)
        {

            return View(std);
        }
        public ActionResult DataTr()
        {
            TempData["mykey"] = "This is Demp Data";


            return View();
        }

        public ActionResult KeepData()
        {
            Session.Abandon();
            ViewBag.myprop = TempData.Peek("mykey");

            return View();
        }
        public ActionResult Temp()
        {
            ViewBag.myprop = TempData["mykey"];
            return View();
        }
    }
}