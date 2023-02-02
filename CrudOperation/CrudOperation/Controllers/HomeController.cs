using CrudOperation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperation.Controllers
{
    public class HomeController : Controller
    {
        CategoryContext categoryContext=new CategoryContext();
        public ActionResult Index()
        {
            IEnumerable<Category> obj = categoryContext.categories;
            IEnumerable<Item> obj2 = categoryContext.items;
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryDto cs)
        {
            if (ModelState.IsValid)
            {
                Item i = new Item();
                i.item = cs.myitem;
                Category c = new Category();
                c.name = cs.name; 
                c.description = cs.description;
                c.myitem = i;                
                categoryContext.items.Add(i);
                categoryContext.categories.Add(c);
                categoryContext.SaveChanges();


                return RedirectToAction("Index");
            }
            return View();
        }

    }
}