using CategoryCrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CategoryCrudMVC.Controllers
{
    public class HomeController : Controller
    {
        CategoryDbContext obj = new CategoryDbContext();
        public ActionResult Index()
        {

            List<Category> category = obj.categories.ToList();
            List<Item> item = obj.items.ToList();

            var query =
                from c in category
                join i in item
                on c.id equals i.id
                select new AllData
                {
                    ctgr = c,
                    itm = i
                };




            return View(query);
        }


        //Create and Save
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FieldClass data)
        {
            Category category = new Category();
            Item item = new Item();

            category.categoryName = data.categoryName;
            item.itemName = data.itemName;
            item.description = data.itemDescription;
            category.item = item;
            if (ModelState.IsValid)
            {
                obj.categories.Add(category);
                obj.items.Add(item);
                obj.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index");




            }

            return View();
        }


        //edit

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var data = obj.categories.Where(model => model.id == id).FirstOrDefault();

            var dataitem = obj.items.Where(model => model.id == id).FirstOrDefault();

            FieldClass alldata = new FieldClass();
            alldata.categoryId = data.id;
            alldata.categoryName = data.categoryName;
            alldata.itemDescription = dataitem.description;
            alldata.itemName = dataitem.itemName;


            return View(alldata);
        }

        [HttpPost]
        public ActionResult Edit(FieldClass data)
        {
            if (ModelState.IsValid)
            {



                var catgorys = obj.categories.Include(q => q.item).FirstOrDefault(q => q.id == data.categoryId);
                var item = catgorys.item;
                catgorys.categoryName = data.categoryName;
                item.itemName = data.itemName;
                item.description = data.itemDescription;



                obj.SaveChanges();
                return RedirectToAction("Index");

            }


            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = obj.categories.Include(q => q.item).FirstOrDefault(q => q.id == id);


            Category category = new Category();
            Item item = new Item();
            category.id = data.id;
            category.categoryName = data.categoryName;
            item.id = id;
            item.itemName = data.item.itemName;
            item.description = data.item.description;



            obj.items.Attach(item);
            obj.items.Remove(item);

            // var db = obj.categories.Where(u => u.id.Equals(category.id)).FirstOrDefault();
            // obj.categories.Remove(db);



            obj.categories.Remove(category);

            return View("Index");
        }

        //Category category = new Category();
        //Item item = new Item();

        //category.categoryName = data.categoryName;
        //    item.itemName = data.itemName;
        //    item.description = data.itemDescription;
        //    category.item = item;
        //    if (ModelState.IsValid)
        //    {
        //        obj.categories.Add(category);
        //        obj.items.Add(item);
        //        obj.SaveChanges();
        //        ModelState.Clear();
        //        return RedirectToAction("Index");




    }


}


