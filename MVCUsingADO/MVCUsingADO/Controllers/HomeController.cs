using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUsingADO.Models;

namespace MVCUsingADO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = DbContext.GetData();

            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            if (ModelState.IsValid)
            {
                DbContext.Add(c);
                ModelState.Clear();
                ViewBag.message = "Category Added Succesfully";
                return RedirectToAction("Index");
            }


            return View();
        }


        public ActionResult Delete(int id)
        {
            var data = DbContext.GetData().Where(x => x.Id == id).SingleOrDefault();

            return View(data);
        }

        [HttpPost]
        public ActionResult Delete(Category c)
        {
            DbContext.Delete(c);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var data = DbContext.GetData().Where(x => x.Id == id).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            DbContext.Update(c);
            return RedirectToAction("Index");
        }

    }
}