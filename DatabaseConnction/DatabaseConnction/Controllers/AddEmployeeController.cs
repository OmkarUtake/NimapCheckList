using DatabaseConnction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseConnction.Controllers
{
    public class AddEmployeeController : Controller
    {
        EmployeeDbContext employeeDbContext = new EmployeeDbContext();
        // GET: AddEmployee
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Employee add)
        {
            if (ModelState.IsValid)
            {
                employeeDbContext.Employees.Add(add);
                employeeDbContext.SaveChanges();
                return RedirectToAction("Display");
            }

            return View();
        }

        public ActionResult Display()
        {
            IEnumerable<Employee> obj= employeeDbContext.Employees;
            return View(obj);
        }
    }
}